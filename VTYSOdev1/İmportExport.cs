using ClosedXML.Excel;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VTYSOdev1
{
    public partial class İmportExport : Form
    {
        private string selectedTableName = ""; // Seçili tablo adını saklamak için değişken

        public İmportExport()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTableName = comboBox1.SelectedItem.ToString();
            //LoadSelectedTableData(); // Combobox değiştiğinde tabloyu yükle
        }

        private void LoadSelectedTableData()
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

        private void excelexportbutton2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                dt.Columns.Add(column.HeaderText);
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataRow dw = dt.NewRow();

                foreach (DataGridViewCell cell in row.Cells)
                {
                    dw[cell.ColumnIndex] = cell.Value;
                }

                dt.Rows.Add(dw);
            }

            using (XLWorkbook workbook = new XLWorkbook())
            {
                workbook.Worksheets.Add(dt, selectedTableName);

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Dosyaları|.xlsx|Tüm Dosyalar|.*",
                    Title = "Excel'e Aktar",
                    FileName = selectedTableName+".xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Excel dosyası başarıyla oluşturuldu");
                }
            }
        }

        private void excelimportbutton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Dosyaları|*.xlsx;*.xls|Tüm Dosyalar|*.*",
                Title = "Excel Dosyası Seç"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string excelFilePath = openFileDialog.FileName;
                LoadExcelDataToDataGridView(excelFilePath);
            }
        }

        private void LoadExcelDataToDataGridView(string excelFilePath)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();

            try
            {
                using (XLWorkbook workbook = new XLWorkbook(excelFilePath))
                {
                    IXLWorksheet worksheet = workbook.Worksheet(1);
                    DataTable dt = new DataTable();

                    foreach (IXLRow row in worksheet.RowsUsed())
                    {
                        if (row.RowNumber() == 1)
                        {
                            foreach (IXLCell cell in row.Cells())
                            {
                                dt.Columns.Add(cell.Value.ToString());
                            }
                        }
                        else
                        {
                            DataRow newRow = dt.Rows.Add();
                            int i = 0;
                            foreach (IXLCell cell in row.Cells())
                            {
                                newRow[i] = cell.Value.ToString();
                                i++;
                            }
                        }
                    }

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excel dosyası yüklenirken bir hata oluştu: " + ex.Message);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            if (selectedTableName == "")
            {
                MessageBox.Show("Lütfen bir tablo seçin.");
                return;
            }

            try
            {
                string connectionString = "data source=HIZZ\\SQLEXPRESS01; database=libraryDB; integrated security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string[] tables = { "Kitap", "Kullanicilar", "OduncKitaplar", "Rol", "Yayinevi", "Yazar" };
                    string idquery = $"SET IDENTITY_INSERT {selectedTableName} ON;";
                    using (SqlCommand command = new SqlCommand(idquery, connection))
                         
                    {
                        command.ExecuteNonQuery();
                    }
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        string insertQuery = $"INSERT INTO {selectedTableName} VALUES (";

                        for (int i = 1; i < row.Cells.Count; i++)
                        {
                            insertQuery += $" '{row.Cells[i].Value?.ToString()}',";
                        }

                        insertQuery = insertQuery.TrimEnd(',') + ")";

                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                 

                    MessageBox.Show($"{selectedTableName} tablosuna veriler başarıyla eklendi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri ekleme hatası: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
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
    }
}
