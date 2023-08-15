namespace hainh
{
    partial class MahForm
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
            groupBox1 = new GroupBox();
            cboSoLuong = new ComboBox();
            txtGiaNhap = new TextBox();
            txtMoTa = new TextBox();
            txtTenXe = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnXoaForm = new Button();
            btnHienThi = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            groupBox3 = new GroupBox();
            txtTimKiem = new TextBox();
            label6 = new Label();
            dgvXeMay = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvXeMay).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboSoLuong);
            groupBox1.Controls.Add(txtGiaNhap);
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Controls.Add(txtTenXe);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(10, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(537, 235);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // cboSoLuong
            // 
            cboSoLuong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSoLuong.FormattingEnabled = true;
            cboSoLuong.Location = new Point(165, 178);
            cboSoLuong.Name = "cboSoLuong";
            cboSoLuong.Size = new Size(283, 28);
            cboSoLuong.TabIndex = 7;
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.Location = new Point(165, 123);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(283, 27);
            txtGiaNhap.TabIndex = 6;
            txtGiaNhap.Validated += txtGiaNhap_Validated;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(165, 72);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(283, 27);
            txtMoTa.TabIndex = 5;
            // 
            // txtTenXe
            // 
            txtTenXe.Location = new Point(165, 32);
            txtTenXe.Name = "txtTenXe";
            txtTenXe.Size = new Size(283, 27);
            txtTenXe.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 178);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 3;
            label4.Text = "Số lượng ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 126);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Giá nhập ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 75);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 1;
            label2.Text = "Mô tả";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 32);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên xe";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnXoaForm);
            groupBox2.Controls.Add(btnHienThi);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Location = new Point(553, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(361, 232);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btnXoaForm
            // 
            btnXoaForm.FlatStyle = FlatStyle.System;
            btnXoaForm.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoaForm.Location = new Point(105, 190);
            btnXoaForm.Name = "btnXoaForm";
            btnXoaForm.Size = new Size(126, 35);
            btnXoaForm.TabIndex = 3;
            btnXoaForm.Text = "Xóa form";
            btnXoaForm.UseVisualStyleBackColor = true;
            btnXoaForm.Click += btnXoaForm_Click;
            // 
            // btnHienThi
            // 
            btnHienThi.FlatStyle = FlatStyle.System;
            btnHienThi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnHienThi.Location = new Point(105, 135);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(126, 35);
            btnHienThi.TabIndex = 2;
            btnHienThi.Text = "Hiển thị";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // btnXoa
            // 
            btnXoa.FlatStyle = FlatStyle.System;
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.Location = new Point(105, 85);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(126, 35);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.FlatStyle = FlatStyle.System;
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.Location = new Point(105, 29);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(126, 35);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtTimKiem);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(5, 243);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(909, 85);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(170, 33);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập tên để tìm kiếm";
            txtTimKiem.Size = new Size(700, 27);
            txtTimKiem.TabIndex = 9;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 33);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 4;
            label6.Text = "Tìm kiếm";
            // 
            // dgvXeMay
            // 
            dgvXeMay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvXeMay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvXeMay.Location = new Point(7, 330);
            dgvXeMay.Name = "dgvXeMay";
            dgvXeMay.ReadOnly = true;
            dgvXeMay.RowHeadersWidth = 51;
            dgvXeMay.RowTemplate.Height = 29;
            dgvXeMay.Size = new Size(907, 198);
            dgvXeMay.TabIndex = 3;
            dgvXeMay.CellClick += dgvXeMay_CellClick;
            // 
            // MahForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 540);
            Controls.Add(dgvXeMay);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MahForm";
            Text = "Form1";
            Load += MahForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvXeMay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cboSoLuong;
        private TextBox txtGiaNhap;
        private TextBox txtMoTa;
        private TextBox txtTenXe;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnThem;
        private TextBox txtTimKiem;
        private Button btnXoaForm;
        private Button btnHienThi;
        private Button btnXoa;
        private GroupBox groupBox3;
        private Label label6;
        private DataGridView dgvXeMay;
    }
}