using ProductManagement.Models;
using ProductManagement.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProductManagement
{
    public partial class ImportExportForm : Form
    {
        private string mode = "IN";
        private string modeName = "นำเข้า";
        private readonly Action onSuccess;
        public ImportExportForm(string mode, Action onSuccess = null)
        {
            InitializeComponent();
            this.mode = mode;
            this.onSuccess = onSuccess;
            loadingForm();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ImportForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductService ps = new ProductService();
            string productCode = textBox3.Text.Trim();
            Product product = ps.GetProduct(productCode);
            if (product == null)
            {
                MessageBox.Show("ไม่เจอสินค้านี้", "เกิดข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textBox4.Text = product.ProductName;
            textBox5.Text = product.Unit;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) | string.IsNullOrWhiteSpace(textBox2.Text) | string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "ข้อมูลไม่ครบ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                StockChangeService scs = new StockChangeService();
                StockChange stockin = new StockChange
                {
                    ProductCode = textBox3.Text.Trim(),
                    ProductName = textBox4.Text.Trim(),
                    Unit = textBox5.Text.Trim(),
                    Quantity = int.Parse(textBox2.Text.Trim()),
                    StockChangeDate = dateTimePicker1.Value,
                    Note = textBox1.Text,
                    TransactionType = mode
                };

                
                try
                {
                    scs.AddStockChange(stockin);
                    onSuccess?.Invoke(); // Call the success action if provided
                    MessageBox.Show($"ทำการ{modeName}สินค้าสำเร็จ!", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาด:\n" + ex.Message, "ข้อผิดพลาด\n กรุณาเช็คว่าสินค้ามีอยู่ในระบบก่อนส่งออก \nหรือสินค้ามีพอที่จะส่งออก", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                {
                    
                }



                


            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด:\n" + ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadingForm()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm"; 
            dateTimePicker1.ShowUpDown = true;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            if (mode =="IN")
            {
                label5.Text = "วันที่รับเข้า";
                label4.Text = "จำนวนที่รับเข้า";
                this.Text = "รับเข้าสินค้า";
                this.modeName = "นำเข้า";
                this.label1.Text = "ฟอร์มรับสินค้าเข้า";
            }
            else 
            {
                label5.Text = "วันที่จ่ายออก";
                label4.Text = "จำนวนที่จ่ายออก";
                this.Text = "จ่ายออกสินค้า";
                this.modeName = "จ่ายออก";
                this.label1.Text = "ฟอร์มจ่ายสินค้าออก";
            }
        }
    }
}
