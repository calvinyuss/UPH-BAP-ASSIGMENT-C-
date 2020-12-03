using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dapper;
using Excel = Microsoft.Office.Interop.Excel;

namespace Pertemuan15
{
    public partial class Form1 : Form
    {

        private List<Order> orders = new List<Order>();
        private string connString = @"data source=localhost\SQLEXPRESS01;initial catalog=DB_IMS;integrated security=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);
            string query = "SELECT \"Order\".Nomor, OrderDetail.NomorUrut, Tanggal, Supplier, Keterangan, Barang.KodeBarang, Quantity, NamaBarang, Satuan FROM \"Order\" JOIN OrderDetail on OrderDetail.NomorUrut = \"Order\".Nomor JOIN Barang on OrderDetail.KodeBarang = Barang.KodeBarang";
            orders = conn.Query<Order>(query).ToList();

            // insert to table
            foreach (Order order in orders)
            {
                this.dataGridView1.Rows.Add(
                    order.Nomor, 
                    order.Tanggal.Date.ToString("d"), 
                    order.Supplier, 
                    order.Quantity, 
                    order.Keterangan
                    );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (orders != null && orders.Any())
            {
                try
                {
                    // 1. create object Excel.Application
                    Excel.Application app = new Excel.Application();

                    // 2. create object workbook
                    Excel.Workbook book = app.Workbooks.Add();

                    // 3. create object worksheet
                    Excel.Worksheet sheet = book.ActiveSheet as Excel.Worksheet;

                    // 4. write data to worksheet

                    // tampilkan aplikasi excelnya
                    app.Visible = true;
                    app.WindowState = Excel.XlWindowState.xlMaximized;

                    // header
                    sheet.Cells[1, 1] = "Data Order";

                    sheet.Cells[3, 1] = "Nomor";
                    sheet.Cells[3, 2] = "Tanggal";
                    sheet.Cells[3, 3] = "Supplier";

                    // kolom header
                    sheet.Cells[4, 2] = "Kode Barang";
                    sheet.Cells[4, 3] = "Nama Barang";
                    sheet.Cells[4, 4] = "Quantity";
                    sheet.Cells[4, 5] = "Satuan";

                    int row = 5;

                    int orderId = orders[0].NomorUrut;
                    sheet.Cells[row, 1] = orders[0].Nomor;
                    sheet.Cells[row, 2] = orders[0].Tanggal.Date;
                    sheet.Cells[row, 3] = orders[0].Supplier;

                    row += 1;

                    foreach (Order order in orders)
                    {
                        if (orderId != order.NomorUrut)
                        {
                            sheet.Cells[row, 1] = order.Nomor;
                            sheet.Cells[row, 2] = order.Tanggal.Date;
                            sheet.Cells[row, 3] = order.Supplier;
                            orderId = order.NomorUrut;
                            row += 1;
                        }

                        sheet.Cells[row, 2] = order.KodeBarang;
                        sheet.Cells[row, 3] = order.NamaBarang;
                        sheet.Cells[row, 4] = order.Quantity;
                        sheet.Cells[row, 5] = order.Satuan;
                        row += 1;
                    }

                    sheet.Range["A1", "E4"].Font.Bold = true;
                    sheet.Range["A1", "E4"].EntireColumn.AutoFit();

                    sheet.Range["A3", "C3"].Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = 3d;
                    sheet.Range["B4", "E4"].Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = 3d;

                    sheet.Range["A5", "B"+row].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                    // rename sheet
                    sheet.Name = "Order";

                    // buat user bisa handle app excel tsb
                    app.UserControl = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Sorry, tidak ada data yang bisa diexport ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
