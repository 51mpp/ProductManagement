using FastReport;
using FastReport.Export.PdfSimple;
using ProductManagement.Models;
using ProductManagement.Services;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace ProductManagement
{
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();
            loadingData();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ImportExportForm importForm = new ImportExportForm("IN", loadingData);
            importForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductService ps = new ProductService();
            List<Product> products = ps.GetProducts();

        }

        //load data and set into datagridview
        private void loadingData()
        {
            ProductService ps = new ProductService();
            List<Product> products = ps.GetProducts();
            dataGridView1.DataSource = products;
            settingDataGride();


        }

        private void settingDataGride()
        {
            // ตั้งชื่อคอลัมน์
            dataGridView1.Columns["ProductCode"].HeaderText = "รหัสสินค้า";
            dataGridView1.Columns["ProductName"].HeaderText = "ชื่อสินค้า";
            dataGridView1.Columns["Quantity"].HeaderText = "จำนวน";
            dataGridView1.Columns["Unit"].HeaderText = "หน่วย";
            dataGridView1.Columns["LastStockUpdateDate"].HeaderText = "วันล่าสุดที่อัปเดท";


            // ตั้ง wrap text เฉพาะคอลัมน์ข้อความยาว
            dataGridView1.Columns["ProductName"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns["Unit"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGridView1.RowTemplate.Height = 0;

            dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

            // ปรับ DataGridView.Height ตามแถว
            int totalHeight = dataGridView1.ColumnHeadersHeight;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                totalHeight += row.Height;
            }
            dataGridView1.Height = totalHeight;

            dataGridView1.Refresh();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            StockChangeService scs = new StockChangeService();
            List<StockChange> stockList = scs.GetStockChanges();
            foreach (var sc in stockList)
            {
                if (sc.TransactionType == "IN") sc.TransactionType = "รับเข้า";
                else if (sc.TransactionType == "OUT") sc.TransactionType = "จ่ายออก";
            }

            ShowReportPreview(stockList);
        }
        private void ShowReportPreview(List<StockChange> stockList)
        {
            Report report = new Report();


            string templatePath = Path.Combine(Application.StartupPath, "Resources", "StockChange.frx");
            report.Load(templatePath);

            //order databy datetime
            var sortedList = stockList.OrderBy(s => s.StockChangeDate).ToList();


            report.RegisterData(sortedList, "StockChange");
            report.GetDataSource("StockChange").Enabled = true;


            report.Prepare();


            string pdfPath = Path.Combine(Path.GetTempPath(), $"StockChange_{Guid.NewGuid()}.pdf");
            PDFSimpleExport pdfExport = new PDFSimpleExport();
            report.Export(pdfExport, pdfPath);

            Process.Start(new ProcessStartInfo
            {
                FileName = pdfPath,
                UseShellExecute = true
            });
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.loadingData();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            ImportExportForm importForm = new ImportExportForm("OUT",loadingData);
            importForm.Show();
        }
    }
}
