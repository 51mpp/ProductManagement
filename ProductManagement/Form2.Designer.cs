namespace ProductManagement
{
    partial class ImportExportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportExportForm));
            label1 = new Label();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            button1 = new Button();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox4 = new TextBox();
            panel1 = new Panel();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 21);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "ฟอร์มรับสินค้าเข้า  ";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(45, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(644, 388);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "รายละเอียดสินค้า";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.73913F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.26087F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 4);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(label6, 0, 4);
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 1, 3);
            tableLayoutPanel1.Controls.Add(textBox4, 1, 1);
            tableLayoutPanel1.Controls.Add(panel1, 1, 2);
            tableLayoutPanel1.Location = new Point(20, 62);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.00001F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.9999981F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.9999981F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.9999981F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(597, 320);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox3);
            panel2.Location = new Point(144, 3);
            panel2.Margin = new Padding(15, 3, 3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(418, 38);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(321, 4);
            button1.Margin = new Padding(3, 3, 15, 3);
            button1.Name = "button1";
            button1.Size = new Size(32, 28);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left;
            textBox3.Location = new Point(2, 8);
            textBox3.Margin = new Padding(0, 3, 3, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(290, 23);
            textBox3.TabIndex = 10;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(39, 14);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 0;
            label2.Text = "รหัสสินค้า";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(144, 192);
            textBox1.Margin = new Padding(15);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(437, 111);
            textBox1.TabIndex = 7;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(42, 58);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 1;
            label3.Text = "ชื่อสินค้า";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(29, 102);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 2;
            label4.Text = "จำนวนที่รับเข้า";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(38, 146);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 3;
            label5.Text = "วันที่รับเข้า";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(40, 240);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 4;
            label6.Text = "หมายเหตุ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.Location = new Point(144, 142);
            dateTimePicker1.Margin = new Padding(15, 3, 15, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(438, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Location = new Point(146, 54);
            textBox4.Margin = new Padding(15, 3, 15, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(433, 23);
            textBox4.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left;
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox2);
            panel1.Location = new Point(132, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 37);
            panel1.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Left;
            textBox5.Location = new Point(181, 8);
            textBox5.Margin = new Padding(15, 3, 3, 3);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(131, 11);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 10;
            label7.Text = "หน่วย";
            label7.Click += label7_Click;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left;
            textBox2.Location = new Point(14, 8);
            textBox2.Margin = new Padding(15, 3, 3, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 9;
            textBox2.KeyPress += numberBox_KeyPress;
            // 
            // button2
            // 
            button2.Location = new Point(507, 584);
            button2.Name = "button2";
            button2.Size = new Size(75, 37);
            button2.TabIndex = 2;
            button2.Text = "บันทึก";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(634, 584);
            button3.Name = "button3";
            button3.Size = new Size(75, 37);
            button3.TabIndex = 3;
            button3.Text = "ยกเลิก";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ImportExportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 633);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "ImportExportForm";
            Text = "รับสินค้าเข้า";
            Load += ImportForm_Load;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox4;
        private Panel panel1;
        private TextBox textBox2;
        private Label label7;
        private TextBox textBox5;
        private Panel panel2;
        private Button button1;
        private TextBox textBox3;
        private Button button2;
        private Button button3;
    }
}