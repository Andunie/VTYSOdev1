namespace VTYSOdev1
{
    partial class İmportExport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.excelimportbutton2 = new System.Windows.Forms.Button();
            this.excelexportbutton2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // excelimportbutton2
            // 
            this.excelimportbutton2.Location = new System.Drawing.Point(220, 558);
            this.excelimportbutton2.Name = "excelimportbutton2";
            this.excelimportbutton2.Size = new System.Drawing.Size(121, 36);
            this.excelimportbutton2.TabIndex = 16;
            this.excelimportbutton2.Text = "İçe Aktar (Excel)";
            this.excelimportbutton2.UseVisualStyleBackColor = true;
            this.excelimportbutton2.Click += new System.EventHandler(this.excelimportbutton2_Click);
            // 
            // excelexportbutton2
            // 
            this.excelexportbutton2.Location = new System.Drawing.Point(1050, 558);
            this.excelexportbutton2.Name = "excelexportbutton2";
            this.excelexportbutton2.Size = new System.Drawing.Size(127, 36);
            this.excelexportbutton2.TabIndex = 17;
            this.excelexportbutton2.Text = "Dışa Aktar (Excel)";
            this.excelexportbutton2.UseVisualStyleBackColor = true;
            this.excelexportbutton2.Click += new System.EventHandler(this.excelexportbutton2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(220, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(957, 473);
            this.dataGridView1.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kitap",
            "Kullanicilar",
            "OduncKitaplar",
            "Rol",
            "Yayinevi",
            "Yazar"});
            this.comboBox1.Location = new System.Drawing.Point(41, 124);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.Text = "Tablo Seçiniz";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 558);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 36);
            this.button1.TabIndex = 20;
            this.button1.Text = "Veritabanına Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(41, 207);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 34);
            this.button4.TabIndex = 24;
            this.button4.Text = "Listele";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // İmportExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 639);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.excelexportbutton2);
            this.Controls.Add(this.excelimportbutton2);
            this.Name = "İmportExport";
            this.Text = "İmportExport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button excelimportbutton2;
        private System.Windows.Forms.Button excelexportbutton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}