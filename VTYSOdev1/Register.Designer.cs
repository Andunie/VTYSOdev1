namespace VTYSOdev1
{
    partial class Register
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
            this.name = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.telno = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(319, 65);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(129, 22);
            this.name.TabIndex = 0;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(319, 288);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(129, 22);
            this.password.TabIndex = 1;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(319, 240);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(129, 22);
            this.username.TabIndex = 2;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // telno
            // 
            this.telno.Location = new System.Drawing.Point(319, 194);
            this.telno.Name = "telno";
            this.telno.Size = new System.Drawing.Size(129, 22);
            this.telno.TabIndex = 3;
            this.telno.TextChanged += new System.EventHandler(this.telno_TextChanged);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(319, 156);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(129, 22);
            this.email.TabIndex = 4;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(319, 107);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(129, 22);
            this.lastname.TabIndex = 5;
            this.lastname.TextChanged += new System.EventHandler(this.lastname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kullanıcı Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Şifre";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Telefon Numarası";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(319, 367);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(104, 43);
            this.save.TabIndex = 12;
            this.save.Text = "Kaydet";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.email);
            this.Controls.Add(this.telno);
            this.Controls.Add(this.username);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox telno;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button save;
    }
}