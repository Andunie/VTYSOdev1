using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTYSOdev1
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            string connectionString = "data source=HIZZ\\SQLEXPRESS01; database=libraryDB; integrated security=True"; // Veritabanı bağlantı dizesi

            // Kullanıcının girdiği değerleri al
            string kullaniciAdi = username.Text;
            string sifre = password.Text;
            string ad = name.Text;
            string soyad = lastname.Text;
            string eposta = email.Text;
            string telefon = telno.Text;

            // Veritabanına ekleme sorgusu
            string query = "INSERT INTO Kullanicilar (KullaniciAdi, Sifre, Ad, Soyad, Email, TelefonNumarasi, RolID) " +
                           "VALUES (@KullaniciAdi, @Sifre, @Ad, @Soyad, @Email, @TelefonNumarasi, 3)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Parametreleri ekleme
                command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                command.Parameters.AddWithValue("@Sifre", sifre);
                command.Parameters.AddWithValue("@Ad", ad);
                command.Parameters.AddWithValue("@Soyad", soyad);
                command.Parameters.AddWithValue("@Email", eposta);
                command.Parameters.AddWithValue("@TelefonNumarasi", telefon);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Kayıt başarıyla eklendi.");
                    }
                    else
                    {
                        MessageBox.Show("Kayıt eklenirken bir hata oluştu.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri ekleme hatası: " + ex.Message);
                }
            }
        }

        private void telno_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
