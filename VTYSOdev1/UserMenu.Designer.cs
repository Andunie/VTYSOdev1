namespace VTYSOdev1
{
    partial class UserMenu
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.excelimportbutton = new System.Windows.Forms.Button();
            this.excelexportbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.artanazalan1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.siralama1 = new System.Windows.Forms.ComboBox();
            this.listele1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.excelexportbutton2 = new System.Windows.Forms.Button();
            this.artanazalan2 = new System.Windows.Forms.ComboBox();
            this.siralama2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listele2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.excelimportbutton2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(958, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.excelimportbutton);
            this.tabPage1.Controls.Add(this.excelexportbutton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.artanazalan1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.siralama1);
            this.tabPage1.Controls.Add(this.listele1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(950, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kitaplarım";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // excelimportbutton
            // 
            this.excelimportbutton.Location = new System.Drawing.Point(23, 294);
            this.excelimportbutton.Name = "excelimportbutton";
            this.excelimportbutton.Size = new System.Drawing.Size(121, 36);
            this.excelimportbutton.TabIndex = 7;
            this.excelimportbutton.Text = "İçe Aktar (Excel)";
            this.excelimportbutton.UseVisualStyleBackColor = true;
            this.excelimportbutton.Click += new System.EventHandler(this.excelimportbutton_Click);
            // 
            // excelexportbutton
            // 
            this.excelexportbutton.Location = new System.Drawing.Point(23, 346);
            this.excelexportbutton.Name = "excelexportbutton";
            this.excelexportbutton.Size = new System.Drawing.Size(121, 36);
            this.excelexportbutton.TabIndex = 6;
            this.excelexportbutton.Text = "Dışa Aktar (Excel)";
            this.excelexportbutton.UseVisualStyleBackColor = true;
            this.excelexportbutton.Click += new System.EventHandler(this.excelexportbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Artan / Azalan";
            // 
            // artanazalan1
            // 
            this.artanazalan1.FormattingEnabled = true;
            this.artanazalan1.Items.AddRange(new object[] {
            "Artan",
            "Azalan"});
            this.artanazalan1.Location = new System.Drawing.Point(23, 145);
            this.artanazalan1.Name = "artanazalan1";
            this.artanazalan1.Size = new System.Drawing.Size(121, 24);
            this.artanazalan1.TabIndex = 4;
            this.artanazalan1.SelectedIndexChanged += new System.EventHandler(this.artanazalan1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sıralama Ölçütü:";
            // 
            // siralama1
            // 
            this.siralama1.FormattingEnabled = true;
            this.siralama1.Items.AddRange(new object[] {
            "Kitap Adı",
            "Yazar Adı",
            "Yayın Yılı",
            "Yayınevi",
            "Alınma Tarihi"});
            this.siralama1.Location = new System.Drawing.Point(23, 65);
            this.siralama1.Name = "siralama1";
            this.siralama1.Size = new System.Drawing.Size(121, 24);
            this.siralama1.TabIndex = 2;
            this.siralama1.SelectedIndexChanged += new System.EventHandler(this.siralama1_SelectedIndexChanged);
            // 
            // listele1
            // 
            this.listele1.Location = new System.Drawing.Point(823, 355);
            this.listele1.Name = "listele1";
            this.listele1.Size = new System.Drawing.Size(95, 36);
            this.listele1.TabIndex = 1;
            this.listele1.Text = "Listele";
            this.listele1.UseVisualStyleBackColor = true;
            this.listele1.Click += new System.EventHandler(this.listele1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(161, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(757, 311);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.excelimportbutton2);
            this.tabPage2.Controls.Add(this.excelexportbutton2);
            this.tabPage2.Controls.Add(this.artanazalan2);
            this.tabPage2.Controls.Add(this.siralama2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.listele2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(950, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tüm Kitaplar";
            // 
            // excelexportbutton2
            // 
            this.excelexportbutton2.Location = new System.Drawing.Point(20, 350);
            this.excelexportbutton2.Name = "excelexportbutton2";
            this.excelexportbutton2.Size = new System.Drawing.Size(127, 36);
            this.excelexportbutton2.TabIndex = 14;
            this.excelexportbutton2.Text = "Dışa Aktar (Excel)";
            this.excelexportbutton2.UseVisualStyleBackColor = true;
            this.excelexportbutton2.Click += new System.EventHandler(this.excelexportbutton2_Click);
            // 
            // artanazalan2
            // 
            this.artanazalan2.FormattingEnabled = true;
            this.artanazalan2.Items.AddRange(new object[] {
            "Artan",
            "Azalan"});
            this.artanazalan2.Location = new System.Drawing.Point(20, 147);
            this.artanazalan2.Name = "artanazalan2";
            this.artanazalan2.Size = new System.Drawing.Size(121, 24);
            this.artanazalan2.TabIndex = 13;
            this.artanazalan2.SelectedIndexChanged += new System.EventHandler(this.artanazalan2_SelectedIndexChanged);
            // 
            // siralama2
            // 
            this.siralama2.FormattingEnabled = true;
            this.siralama2.Items.AddRange(new object[] {
            "Kitap Adı",
            "Yazar Adı",
            "Yayın Yılı"});
            this.siralama2.Location = new System.Drawing.Point(20, 60);
            this.siralama2.Name = "siralama2";
            this.siralama2.Size = new System.Drawing.Size(121, 24);
            this.siralama2.TabIndex = 12;
            this.siralama2.SelectedIndexChanged += new System.EventHandler(this.siralama2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Artan / Azalan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sıralama Ölçütü:";
            // 
            // listele2
            // 
            this.listele2.Location = new System.Drawing.Point(820, 350);
            this.listele2.Name = "listele2";
            this.listele2.Size = new System.Drawing.Size(95, 36);
            this.listele2.TabIndex = 7;
            this.listele2.Text = "Listele";
            this.listele2.UseVisualStyleBackColor = true;
            this.listele2.Click += new System.EventHandler(this.listele2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(158, 23);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(757, 311);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(950, 397);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Profil";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(134, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Düzenle";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(169, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 33);
            this.button3.TabIndex = 6;
            this.button3.Text = "Kaydet";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Email";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(169, 204);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Şifre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Kullanıcı Adı";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(169, 146);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // excelimportbutton2
            // 
            this.excelimportbutton2.Location = new System.Drawing.Point(20, 298);
            this.excelimportbutton2.Name = "excelimportbutton2";
            this.excelimportbutton2.Size = new System.Drawing.Size(121, 36);
            this.excelimportbutton2.TabIndex = 15;
            this.excelimportbutton2.Text = "İçe Aktar (Excel)";
            this.excelimportbutton2.UseVisualStyleBackColor = true;
            this.excelimportbutton2.Click += new System.EventHandler(this.excelimportbutton2_Click);
            // 
            // UserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "UserMenu";
            this.Text = "UserMenu";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button listele1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox siralama1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox artanazalan1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button listele2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox artanazalan2;
        private System.Windows.Forms.ComboBox siralama2;
        private System.Windows.Forms.Button excelexportbutton;
        private System.Windows.Forms.Button excelexportbutton2;
        private System.Windows.Forms.Button excelimportbutton;
        private System.Windows.Forms.Button excelimportbutton2;
    }
}