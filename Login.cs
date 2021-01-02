using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NabizOlcer.App_Code;

namespace NabizOlcer
{
    public partial class Login : Form
    {
        SqlBaglanti connection = new SqlBaglanti();
        String user = "";
        String pass = "";
        DataTable table;
        public Login()
        {
            InitializeComponent();
            connection.baglan();
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            user=textBoxUser.Text;
            pass = textBoxPass.Text;

            if (user=="" || pass=="")
            {
                MessageBox.Show("Kullanıcı adı veya şifresi boş geçilemez!", "Hatalı Kullanıcı Girişi");
            }
            else
            {

            string sorgu = "EXEC [sametsariyildiz].[SP_KULLANICI_ARA] '" + user + "', '" + pass + "' ";
            table = connection.data(sorgu);
            if (table.Rows.Count>0)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız!", "Hatalı Kullanıcı Girişi");
                }            
            }

        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
