using ClosedXML.Excel;
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
    public partial class UserMenu : Form
    {
        public UserMenu()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void siralama1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listele1_Click(object sender, EventArgs e)
        {

        }

        private void artanazalan1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void siralama2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void artanazalan2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listele2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("TEST1");
           
            string selectedCriterion = siralama2.SelectedItem?.ToString();
            Console.WriteLine("TEST:"+selectedCriterion);
            string orderByClause = "";

            if (string.IsNullOrEmpty(selectedCriterion))
            {
                orderByClause = "k.KitapAdi"; // Sadece sütun adını alınacak, ORDER BY ifadesiyle birleştirilecek
            }
            else
            {
                switch (selectedCriterion)
                {
                    case "Kitap Adı":
                        orderByClause = "k.KitapAdi";
                        Console.WriteLine("KİTAPADI "+orderByClause);
                        break;
                    case "Yazar Adı":
                        orderByClause = "y.YazarAdi";
                        Console.WriteLine("YAZARADI "+ orderByClause);
                        break;
                    case "Yayın Yılı":
                        orderByClause = "k.YayinTarihi";
                        Console.WriteLine("YAYINYILI "+ orderByClause);
                        break;
                        
                    default:
                        Console.WriteLine("BOS");
                        break;
                }
            }

            string connectionString = "data source=HIZZ\\SQLEXPRESS01; database=libraryDB; integrated security=True";
            string query = "SELECT k.KitapAdi, y.YazarAdi, k.YayinTarihi" + " FROM Kitap k " + "INNER JOIN Yazar y ON k.YazarID = y.YazarID " +
            "ORDER BY " + orderByClause;




            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    dataGridView2.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata Oluştu: " + ex.Message);
                    Console.WriteLine("Hata Oluştu: " + ex.Message);
                    MessageBox.Show("Veri getirme hatası: " + ex.Message);
                    Console.WriteLine("Hata Oluştu: " + ex.StackTrace);
                }
            }
        }

        private void excelexportbutton_Click(object sender, EventArgs e)
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
                workbook.Worksheets.Add(dt, "Kitaplar");

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Dosyaları|.xlsx|Tüm Dosyalar|.*",
                    Title = "Excel'e Aktar",
                    FileName = "Kitaplar.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Excel dosyası başarıyla oluşturuldu");
                }
            }
        }

        private void excelexportbutton2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                dt.Columns.Add(column.HeaderText);
            }

            foreach (DataGridViewRow row in dataGridView2.Rows)
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
                workbook.Worksheets.Add(dt, "Kitaplar");

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Dosyaları|.xlsx|Tüm Dosyalar|.*",
                    Title = "Excel'e Aktar",
                    FileName = "Kitaplar.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Excel dosyası başarıyla oluşturuldu");
                }
            }
        }

        private void excelimportbutton_Click(object sender, EventArgs e)
        {
            string excelFilePath;
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Dosyaları|*.xlsx;*.xls|Tüm Dosyalar|*.*",
                Title = "Excel Dosyası Seç"
            };

            openFileDialog.ShowDialog();
            
               excelFilePath = openFileDialog.FileName;
               
           
            
            using (XLWorkbook workbook = new XLWorkbook(excelFilePath))
            {
                IXLWorksheet worksheet = workbook.Worksheet(1); // Excel dosyasındaki ilk sayfa

                DataTable dt = new DataTable();
                bool firstRow = true;

                foreach (IXLRow row in worksheet.RowsUsed())
                {
                    if (firstRow)
                    {
                        // Sütunları oluştur
                        foreach (IXLCell cell in row.Cells())
                        {
                            dt.Columns.Add(cell.Value.ToString());
                        }
                        firstRow = false;
                    }
                    else
                    {
                        // Verileri ekle
                        dt.Rows.Add();
                        int i = 0;
                        foreach (IXLCell cell in row.Cells())
                        {
                            dt.Rows[dt.Rows.Count - 1][i] = cell.Value.ToString();
                            i++;
                        }
                    }
                }

                string connectionString = "data source=HIZZ\\SQLEXPRESS01; database=libraryDB; integrated security=True";
                string tableName = "YourTableName"; // Verilerin ekleneceği tablo adı

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection))
                    {
                        bulkCopy.DestinationTableName = tableName;
                        foreach (DataColumn column in dt.Columns)
                        {
                            bulkCopy.ColumnMappings.Add(column.ColumnName, column.ColumnName);
                        }
                        try
                        {
                            bulkCopy.WriteToServer(dt);
                            MessageBox.Show("Excel verileri başarıyla veritabanına eklendi");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Veri ekleme hatası: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void excelimportbutton2_Click(object sender, EventArgs e)
        {
            string excelFilePath;
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Dosyaları|*.xlsx;*.xls|Tüm Dosyalar|*.*",
                Title = "Excel Dosyası Seç"
            };

            openFileDialog.ShowDialog();

            excelFilePath = openFileDialog.FileName;



            using (XLWorkbook workbook = new XLWorkbook(excelFilePath))
            {
                IXLWorksheet worksheet = workbook.Worksheet(1); // Excel dosyasındaki ilk sayfa

                DataTable dt = new DataTable();
                bool firstRow = true;

                foreach (IXLRow row in worksheet.RowsUsed())
                {
                    if (firstRow)
                    {
                        // Sütunları oluştur
                        foreach (IXLCell cell in row.Cells())
                        {
                            dt.Columns.Add(cell.Value.ToString());
                        }
                        firstRow = false;
                    }
                    else
                    {
                        // Verileri ekle
                        dt.Rows.Add();
                        int i = 0;
                        foreach (IXLCell cell in row.Cells())
                        {
                            dt.Rows[dt.Rows.Count - 1][i] = cell.Value.ToString();
                            i++;
                        }
                    }
                }

                string connectionString = "data source=HIZZ\\SQLEXPRESS01; database=libraryDB; integrated security=True";
                string tableName = "YourTableName"; // Verilerin ekleneceği tablo adı

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection))
                    {
                        bulkCopy.DestinationTableName = tableName;
                        foreach (DataColumn column in dt.Columns)
                        {
                            bulkCopy.ColumnMappings.Add(column.ColumnName, column.ColumnName);
                        }
                        try
                        {
                            bulkCopy.WriteToServer(dt);
                            MessageBox.Show("Excel verileri başarıyla veritabanına eklendi");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Veri ekleme hatası: " + ex.Message);
                        }
                    }
                }
            }
        }
    }
}
