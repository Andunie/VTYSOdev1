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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VTYSOdev1
{
    public partial class LoginMenu : Form
    {
        public LoginMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        UserMenu userMenu = new UserMenu();
        EmployeeMenu employeeMenu = new EmployeeMenu();


        private void button1_Click(object sender, EventArgs e)
        {

            // Veritabanı bağlantısı oluşturma
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source=HIZZ\\SQLEXPRESS01; database=libraryDB; integrated security=True";

            // Kullanıcı giriş bilgilerini parametre olarak kullanarak sorguyu oluşturma
            string query = "SELECT RolID FROM Kullanicilar WHERE KullaniciAdi=@username OR Email=@email OR TelefonNumarasi=@phoneNumber AND Sifre=@password";

            // SqlCommand oluşturma ve bağlantı atama
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", txt_kullaniciadi.Text);
            cmd.Parameters.AddWithValue("@email", txt_kullaniciadi.Text);
            cmd.Parameters.AddWithValue("@phoneNumber", txt_kullaniciadi.Text);
            cmd.Parameters.AddWithValue("@password",txt_sifre.Text);

            // Veritabanından rol ID'sini alınması
            conn.Open();
            object roleObj = cmd.ExecuteScalar();
            conn.Close();

            int roleId = 0; // Varsayılan olarak rol ID'sini 0 olarak ayarlıyoruz

            if (roleObj != null && int.TryParse(roleObj.ToString(), out roleId) && roleId == 1)
            {
                // Eğer rol ID'si 1 ise, yani admin ise:
                AdminMenu adminMainscreen = new AdminMenu();
                adminMainscreen.Show();
                this.Hide();

            }
            else if (roleObj != null && int.TryParse(roleObj.ToString(), out roleId) && roleId == 2)
            {
                employeeMenu.Show();
                this.Hide();
            }
            else if (roleObj != null && int.TryParse(roleObj.ToString(), out roleId) && roleId == 3)
            {
                userMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız.");
            }


        }

        private void LoginMenu_Load(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }
    }
    }

