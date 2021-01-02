using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;//Seri portu dinlemek için gerekli kütüphanemiz.
using System.Threading;
using NabizOlcer.App_Code;
using System.Data.SqlClient;

namespace NabizOlcer
{
    public partial class Main : Form
    {
        DataTable tableHasta;
        SqlBaglanti baglantim = new SqlBaglanti();
        string hastaid = "";
        public Main()
        {

            InitializeComponent();
            //PC ye bağlı com portlarını dinliyoruz. Bağlı olan var ise combobox içerisine ekliyoruz.
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBoxPorts.Items.Add(port);
                comboBoxPorts.SelectedIndex = 0;
            }
            //Hastaları listele..          
            baglantim.baglan();
            string hastalar = "SELECT [YAS_GRUBU]  ,[ALT_DEGER]  ,[UST_DEGER]  ,[ORTALAMA] FROM [YELLOWSTAR].[sametsariyildiz].[TBL_NABIZ] ";
            tableHasta = baglantim.data(hastalar);
            if (tableHasta.Rows.Count > 0)
            {
                dataGridViewHastalar.DataSource = tableHasta;
              //  dataGridViewHastalar.Show();
            }
            //HASTALARI LİSTEYE AKTAR
            string hastaCek = "SELECT HASTA_ADI FROM [YELLOWSTAR].[sametsariyildiz].[TBL_HASTALAR]";
            tableHasta = baglantim.data(hastaCek);
            if (tableHasta.Rows.Count > 0)
            {
                comboBoxHastalar.Items.Clear();
                foreach (DataRow item in tableHasta.Rows)
                {
                    comboBoxHastalar.Items.Add(item.ItemArray[0].ToString());
                }

            }
            chart1Doldur();

        }

        //Listede ardunio hangi porta bağlı ise onu okuyoruz.
        private void comboBoxPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                serialPort1.PortName = comboBoxPorts.SelectedItem.ToString();
            }


        }

        //Seri Port ile ardunio verileri dinliyoruz. (read-write)
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            Thread.Sleep(1000);
            string data = serialPort1.ReadExisting();
           

            if (data != "")
            {
                lblData.Invoke(new MethodInvoker(
                    delegate
                    {
                        lblData.Text = data;
                        //dataGridViewNabiz.
                       
                    }
                    ));

            }
 


            Console.WriteLine(data);


        }

        //Bağlantıyı oluşturmak için buton aktif edilmesi.
        private void btnBaglan_Click(object sender, EventArgs e)
        {
            string port = comboBoxPorts.SelectedItem.ToString();
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            else
            {
                if (port != "")
                {
                    serialPort1.PortName = comboBoxPorts.SelectedItem.ToString();
                    serialPort1.BaudRate = 9600;
                    serialPort1.Open();
                    serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);// Data received metodunu aktif ediyoruz. Bu porttana gelen verileri dinlemek için.
                    lblPort.Text = comboBoxPorts.SelectedItem.ToString() + " portuna bağlanıldı.";
                }
                else
                {
                    MessageBox.Show("Seri portu seçiniz!.", "Hata Mesajı!");
                }

            }


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxHastalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hastaGetir = "SELECT * FROM [YELLOWSTAR].[sametsariyildiz].[TBL_HASTALAR] where HASTA_ADI ='" + comboBoxHastalar.SelectedItem.ToString() + "'";
            DataTable hasta = baglantim.data(hastaGetir);
            if (hasta.Rows.Count > 0)
            {
                foreach (DataRow item in hasta.Rows)
                {
                    hastaid= item.ItemArray[1].ToString();
                    textBoxHastaAdi.Text = item.ItemArray[2].ToString();
                    textBoxSonOlcum.Text = item.ItemArray[6].ToString();
                    textBoxYas.Text = item.ItemArray[3].ToString();
                    labelDurum.Text = "Durum '" + item.ItemArray[4] + "'  ve ortalama son nabız degeri '" + item.ItemArray[5].ToString() + "'";
                }
            }
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                string yukle = "INSERT INTO [YELLOWSTAR].[sametsariyildiz].[TBL_OLCUMLER] (HASTA_ID,OLCUM_DEGERI, KAYIT_TARIHI) SELECT '" + hastaid + "', " + lblData.Text.Substring(0, 3) + ",  GETDATE()";
                baglantim.data(yukle);
                MessageBox.Show(lblData.Text+"Ölçüm değeri başarıyla kaydedildi.", "Bilgi Mesajı!");
            }
            else {
                MessageBox.Show("Önce ölçüm değerlerini alınız!", "Hata Mesajı!");
            }
           
        }

        public void chart1Doldur()
        {
            
            DataTable chart = baglantim.data("EXEC [sametsariyildiz].[PRC_ORTALAMA_NABIZLAR]");
           
            foreach (DataRow item in chart.Rows)
            {
                chart1.Series["Nabiz"].Points.AddXY(item.ItemArray[1].ToString(), item.ItemArray[0]);                
            }     
            chart1.Titles.Add("HASTALARIN ORTALAMA NABIZ GRAFİĞİ");
        }
    }

  
}
