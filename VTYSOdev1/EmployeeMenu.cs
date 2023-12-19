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
    public partial class EmployeeMenu : Form
    {
        string selectedTableName = "";
        public EmployeeMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(selectedTableName))
            {
                MessageBox.Show("Lütfen bir tablo seçin.");
                return;
            }

            try
            {
                string connectionString = "data source=HIZZ\\SQLEXPRESS01; database=libraryDB; integrated security=True";
                string query = $"SELECT * FROM {selectedTableName}";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    connection.Open();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri getirme hatası: " + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTableName = comboBox1.SelectedItem.ToString();
            //LoadSelectedTableData(); // Combobox değiştiğinde tabloyu yükle
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }
    }
}
