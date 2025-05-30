namespace ProductManagement
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            button1 = new Button();
            exportButton = new Button();
            importButton = new Button();
            previewButton = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(exportButton);
            panel1.Controls.Add(importButton);
            panel1.Controls.Add(previewButton);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(13, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(761, 139);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.Location = new Point(13, 113);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "รีเฟรช";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // exportButton
            // 
            exportButton.Image = (Image)resources.GetObject("exportButton.Image");
            exportButton.ImageAlign = ContentAlignment.MiddleRight;
            exportButton.Location = new Point(166, 56);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(127, 29);
            exportButton.TabIndex = 3;
            exportButton.Text = "จ่ายสินค้าออก";
            exportButton.UseVisualStyleBackColor = true;
            exportButton.Click += exportButton_Click;
            // 
            // importButton
            // 
            importButton.ForeColor = SystemColors.ActiveCaptionText;
            importButton.Image = (Image)resources.GetObject("importButton.Image");
            importButton.ImageAlign = ContentAlignment.MiddleRight;
            importButton.Location = new Point(13, 56);
            importButton.Name = "importButton";
            importButton.Size = new Size(127, 29);
            importButton.TabIndex = 2;
            importButton.Text = "รับสินค้าเข้า";
            importButton.UseVisualStyleBackColor = true;
            importButton.Click += button2_Click_1;
            // 
            // previewButton
            // 
            previewButton.Image = (Image)resources.GetObject("previewButton.Image");
            previewButton.ImageAlign = ContentAlignment.MiddleRight;
            previewButton.Location = new Point(319, 56);
            previewButton.Name = "previewButton";
            previewButton.Size = new Size(127, 29);
            previewButton.TabIndex = 1;
            previewButton.Text = "พรีวิวรายงาน";
            previewButton.UseVisualStyleBackColor = true;
            previewButton.Click += previewButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(224, 38);
            label1.TabIndex = 0;
            label1.Text = "ระบบจัดการสินค้า  ";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(754, 319);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 488);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "ระบบจัดการสินค้า ";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button exportButton;
        private Button importButton;
        private Button previewButton;
        private DataGridView dataGridView1;
        private Button button1;
    }
}
