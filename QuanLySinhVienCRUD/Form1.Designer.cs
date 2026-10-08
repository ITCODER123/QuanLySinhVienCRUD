namespace QuanLySinhVienCRUD
{
    partial class Form1
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
            txtHoTen = new TextBox();
            txtDiem = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            bntTaiLai = new Button();
            dgvSinhVien = new DataGridView();
            lblTrangThai = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnLocDat = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(79, 55);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(198, 23);
            txtHoTen.TabIndex = 0;
            // 
            // txtDiem
            // 
            txtDiem.Location = new Point(387, 55);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(177, 23);
            txtDiem.TabIndex = 1;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(70, 129);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 2;
            btnThem.Text = "+ Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(195, 129);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(409, 129);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // bntTaiLai
            // 
            bntTaiLai.Location = new Point(511, 129);
            bntTaiLai.Name = "bntTaiLai";
            bntTaiLai.Size = new Size(106, 23);
            bntTaiLai.TabIndex = 5;
            bntTaiLai.Text = "Tai lai danh sach";
            bntTaiLai.UseVisualStyleBackColor = true;
            bntTaiLai.Click += btnTaiLai_Click;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Location = new Point(70, 187);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.Size = new Size(524, 150);
            dgvSinhVien.TabIndex = 6;
            dgvSinhVien.SelectionChanged += dgvSinhVien_SelectionChanged;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(70, 364);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(94, 15);
            lblTrangThai.TabIndex = 7;
            lblTrangThai.Text = "Hien thi ket qua:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(120, 9);
            label2.Name = "label2";
            label2.Size = new Size(550, 32);
            label2.TabIndex = 8;
            label2.Text = "QUAN LY SINH VIEN - EF CORE (CRUD DAY DU)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 63);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 9;
            label3.Text = "Ho Ten";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(330, 63);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 10;
            label4.Text = "Diem";
            // 
            // btnLocDat
            // 
            btnLocDat.Location = new Point(653, 129);
            btnLocDat.Name = "btnLocDat";
            btnLocDat.Size = new Size(75, 23);
            btnLocDat.TabIndex = 11;
            btnLocDat.Text = "Loc SV dat (LINQ)";
            btnLocDat.UseVisualStyleBackColor = true;
            btnLocDat.Click += btnLocDat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLocDat);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblTrangThai);
            Controls.Add(dgvSinhVien);
            Controls.Add(bntTaiLai);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtDiem);
            Controls.Add(txtHoTen);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Click += btnXoa_Click;
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoTen;
        private TextBox txtDiem;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button bntTaiLai;
        private DataGridView dgvSinhVien;
        private Label lblTrangThai;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnLocDat;
    }
}
