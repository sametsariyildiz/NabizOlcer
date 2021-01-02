namespace NabizOlcer
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnBaglan = new System.Windows.Forms.Button();
            this.lblPort = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewHastalar = new System.Windows.Forms.DataGridView();
            this.lblData = new System.Windows.Forms.Label();
            this.chartNabiz = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDurum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxHastalar = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxHemsire = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxYas = new System.Windows.Forms.TextBox();
            this.textBoxSonOlcum = new System.Windows.Forms.TextBox();
            this.textBoxHastaAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHastalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNabiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.DropDownHeight = 120;
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxPorts.IntegralHeight = false;
            this.comboBoxPorts.Location = new System.Drawing.Point(519, 51);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPorts.TabIndex = 1;
            this.comboBoxPorts.SelectedIndexChanged += new System.EventHandler(this.comboBoxPorts_SelectedIndexChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btnBaglan
            // 
            this.btnBaglan.Location = new System.Drawing.Point(341, 78);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(299, 41);
            this.btnBaglan.TabIndex = 2;
            this.btnBaglan.Text = "BAĞLAN";
            this.btnBaglan.UseVisualStyleBackColor = true;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(447, 129);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(85, 13);
            this.lblPort.TabIndex = 0;
            this.lblPort.Text = "Bağlantı Durumu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(383, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Arduino Cihazına Bağlan";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonKaydet);
            this.panel1.Controls.Add(this.dataGridViewHastalar);
            this.panel1.Controls.Add(this.lblData);
            this.panel1.Location = new System.Drawing.Point(12, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 326);
            this.panel1.TabIndex = 7;
            // 
            // dataGridViewHastalar
            // 
            this.dataGridViewHastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHastalar.Location = new System.Drawing.Point(265, 18);
            this.dataGridViewHastalar.Name = "dataGridViewHastalar";
            this.dataGridViewHastalar.Size = new System.Drawing.Size(375, 285);
            this.dataGridViewHastalar.TabIndex = 1;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblData.Location = new System.Drawing.Point(16, 18);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(243, 25);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Nabız ölçümü bekleniyor..";
            // 
            // chartNabiz
            // 
            this.chartNabiz.BorderlineColor = System.Drawing.Color.Silver;
            this.chartNabiz.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Raised;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Name = "ChartArea1";
            this.chartNabiz.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartNabiz.Legends.Add(legend1);
            this.chartNabiz.Location = new System.Drawing.Point(683, 265);
            this.chartNabiz.Name = "chartNabiz";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartNabiz.Series.Add(series1);
            this.chartNabiz.Size = new System.Drawing.Size(489, 275);
            this.chartNabiz.TabIndex = 8;
            this.chartNabiz.Text = "chart1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NabizOlcer.Properties.Resources.profile__1_;
            this.pictureBox1.Location = new System.Drawing.Point(3, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // chart1
            // 
            this.chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Raised;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(683, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Nabiz";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(489, 246);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hastanın Adı Soyadı";
            // 
            // labelDurum
            // 
            this.labelDurum.AutoSize = true;
            this.labelDurum.Location = new System.Drawing.Point(3, 169);
            this.labelDurum.Name = "labelDurum";
            this.labelDurum.Size = new System.Drawing.Size(48, 13);
            this.labelDurum.TabIndex = 11;
            this.labelDurum.Text = "DURUM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Yaş";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.comboBoxHastalar);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.textBoxHemsire);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblPort);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.comboBoxPorts);
            this.panel2.Controls.Add(this.textBoxYas);
            this.panel2.Controls.Add(this.btnBaglan);
            this.panel2.Controls.Add(this.textBoxSonOlcum);
            this.panel2.Controls.Add(this.textBoxHastaAdi);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelDurum);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(648, 196);
            this.panel2.TabIndex = 13;
            // 
            // comboBoxHastalar
            // 
            this.comboBoxHastalar.FormattingEnabled = true;
            this.comboBoxHastalar.Location = new System.Drawing.Point(91, 12);
            this.comboBoxHastalar.Name = "comboBoxHastalar";
            this.comboBoxHastalar.Size = new System.Drawing.Size(194, 21);
            this.comboBoxHastalar.TabIndex = 20;
            this.comboBoxHastalar.Text = "Listeden Hasta Seçiniz";
            this.comboBoxHastalar.SelectedIndexChanged += new System.EventHandler(this.comboBoxHastalar_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(338, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Listeden bağlanılacak portu seçiniz:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Location = new System.Drawing.Point(309, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 193);
            this.panel3.TabIndex = 18;
            // 
            // textBoxHemsire
            // 
            this.textBoxHemsire.Location = new System.Drawing.Point(91, 103);
            this.textBoxHemsire.Name = "textBoxHemsire";
            this.textBoxHemsire.Size = new System.Drawing.Size(194, 20);
            this.textBoxHemsire.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ölçüm Yapacak Hemşire";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBoxYas
            // 
            this.textBoxYas.Location = new System.Drawing.Point(3, 103);
            this.textBoxYas.Name = "textBoxYas";
            this.textBoxYas.Size = new System.Drawing.Size(64, 20);
            this.textBoxYas.TabIndex = 15;
            // 
            // textBoxSonOlcum
            // 
            this.textBoxSonOlcum.Location = new System.Drawing.Point(3, 146);
            this.textBoxSonOlcum.Name = "textBoxSonOlcum";
            this.textBoxSonOlcum.Size = new System.Drawing.Size(285, 20);
            this.textBoxSonOlcum.TabIndex = 14;
            // 
            // textBoxHastaAdi
            // 
            this.textBoxHastaAdi.Location = new System.Drawing.Point(91, 61);
            this.textBoxHastaAdi.Name = "textBoxHastaAdi";
            this.textBoxHastaAdi.Size = new System.Drawing.Size(194, 20);
            this.textBoxHastaAdi.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Son Ölçüm Tarihi";
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(6, 256);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(253, 47);
            this.buttonKaydet.TabIndex = 2;
            this.buttonKaydet.Text = "Ölçümü Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.chartNabiz);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nabız Ölçer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHastalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNabiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNabiz;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDurum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxHemsire;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxYas;
        private System.Windows.Forms.TextBox textBoxSonOlcum;
        private System.Windows.Forms.TextBox textBoxHastaAdi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewHastalar;
        private System.Windows.Forms.ComboBox comboBoxHastalar;
        private System.Windows.Forms.Button buttonKaydet;
    }
}

