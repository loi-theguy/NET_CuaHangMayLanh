namespace DoAn_QuanLyMayLanh
{
    partial class QuanLyNhapKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyNhapKho));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewChiTiet = new System.Windows.Forms.DataGridView();
            this.MAPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.comboBoxSanPham = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTaoPN = new System.Windows.Forms.Button();
            this.btnXoaPN = new System.Windows.Forms.Button();
            this.dataGridViewPhieuNhap = new System.Windows.Forms.DataGridView();
            this.MANHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTiet)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(763, 356);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewChiTiet);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(384, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 350);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết phiếu nhập";
            // 
            // dataGridViewChiTiet
            // 
            this.dataGridViewChiTiet.AllowUserToAddRows = false;
            this.dataGridViewChiTiet.AllowUserToDeleteRows = false;
            this.dataGridViewChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPN,
            this.MASP,
            this.TENSP,
            this.SOLUONG,
            this.DONGIA});
            this.dataGridViewChiTiet.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewChiTiet.Name = "dataGridViewChiTiet";
            this.dataGridViewChiTiet.ReadOnly = true;
            this.dataGridViewChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChiTiet.Size = new System.Drawing.Size(361, 150);
            this.dataGridViewChiTiet.TabIndex = 15;
            // 
            // MAPN
            // 
            this.MAPN.DataPropertyName = "MANHAP";
            this.MAPN.HeaderText = "Mã phiếu nhập";
            this.MAPN.Name = "MAPN";
            this.MAPN.ReadOnly = true;
            // 
            // MASP
            // 
            this.MASP.DataPropertyName = "MASP";
            this.MASP.HeaderText = "Mã sản phẩm";
            this.MASP.Name = "MASP";
            this.MASP.ReadOnly = true;
            // 
            // TENSP
            // 
            this.TENSP.DataPropertyName = "TENSP";
            this.TENSP.HeaderText = "Tên sản phẩm";
            this.TENSP.Name = "TENSP";
            this.TENSP.ReadOnly = true;
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "Số Lượng";
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.ReadOnly = true;
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "DONGIA";
            this.DONGIA.HeaderText = "Đơn giá";
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.txtMaPN);
            this.panel2.Controls.Add(this.comboBoxSanPham);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.txtSoLuong);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.txtDonGia);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 165);
            this.panel2.TabIndex = 14;
            // 
            // txtMaPN
            // 
            this.txtMaPN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaPN.Enabled = false;
            this.txtMaPN.Location = new System.Drawing.Point(24, 22);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(100, 20);
            this.txtMaPN.TabIndex = 3;
            this.txtMaPN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBoxSanPham
            // 
            this.comboBoxSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSanPham.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxSanPham.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSanPham.FormattingEnabled = true;
            this.comboBoxSanPham.Location = new System.Drawing.Point(160, 21);
            this.comboBoxSanPham.Name = "comboBoxSanPham";
            this.comboBoxSanPham.Size = new System.Drawing.Size(196, 21);
            this.comboBoxSanPham.TabIndex = 4;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(269, 120);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 33);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoLuong.Location = new System.Drawing.Point(27, 127);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuong.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(269, 78);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 34);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDonGia.Location = new System.Drawing.Point(27, 78);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(100, 20);
            this.txtDonGia.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã phiếu nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Đơn giá nhập";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.dataGridViewPhieuNhap);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 350);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu nhập";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btnTaoPN);
            this.panel1.Controls.Add(this.btnXoaPN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 165);
            this.panel1.TabIndex = 3;
            // 
            // btnTaoPN
            // 
            this.btnTaoPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTaoPN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTaoPN.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoPN.Image")));
            this.btnTaoPN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoPN.Location = new System.Drawing.Point(3, 9);
            this.btnTaoPN.Name = "btnTaoPN";
            this.btnTaoPN.Size = new System.Drawing.Size(135, 35);
            this.btnTaoPN.TabIndex = 1;
            this.btnTaoPN.Text = "Tạo phiếu nhập mới";
            this.btnTaoPN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaoPN.UseVisualStyleBackColor = false;
            this.btnTaoPN.Click += new System.EventHandler(this.btnTaoPN_Click);
            // 
            // btnXoaPN
            // 
            this.btnXoaPN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoaPN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoaPN.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaPN.Image")));
            this.btnXoaPN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaPN.Location = new System.Drawing.Point(228, 9);
            this.btnXoaPN.Name = "btnXoaPN";
            this.btnXoaPN.Size = new System.Drawing.Size(135, 35);
            this.btnXoaPN.TabIndex = 2;
            this.btnXoaPN.Text = "Xóa phiếu nhập";
            this.btnXoaPN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaPN.UseVisualStyleBackColor = false;
            this.btnXoaPN.Click += new System.EventHandler(this.btnXoaPN_Click);
            // 
            // dataGridViewPhieuNhap
            // 
            this.dataGridViewPhieuNhap.AllowUserToAddRows = false;
            this.dataGridViewPhieuNhap.AllowUserToDeleteRows = false;
            this.dataGridViewPhieuNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANHAP,
            this.TENNV,
            this.NGAYNHAP,
            this.TONGTIEN});
            this.dataGridViewPhieuNhap.Location = new System.Drawing.Point(9, 19);
            this.dataGridViewPhieuNhap.Name = "dataGridViewPhieuNhap";
            this.dataGridViewPhieuNhap.ReadOnly = true;
            this.dataGridViewPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPhieuNhap.Size = new System.Drawing.Size(360, 150);
            this.dataGridViewPhieuNhap.TabIndex = 0;
            this.dataGridViewPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPhieuNhap_CellClick);
            this.dataGridViewPhieuNhap.SelectionChanged += new System.EventHandler(this.dataGridViewPhieuNhap_SelectionChanged);
            // 
            // MANHAP
            // 
            this.MANHAP.DataPropertyName = "MANHAP";
            this.MANHAP.HeaderText = "Mã phiếu nhập";
            this.MANHAP.Name = "MANHAP";
            this.MANHAP.ReadOnly = true;
            // 
            // TENNV
            // 
            this.TENNV.DataPropertyName = "HOTEN";
            this.TENNV.HeaderText = "Nhân viên";
            this.TENNV.Name = "TENNV";
            this.TENNV.ReadOnly = true;
            // 
            // NGAYNHAP
            // 
            this.NGAYNHAP.DataPropertyName = "NGAYNHAP";
            this.NGAYNHAP.HeaderText = "Ngày nhập";
            this.NGAYNHAP.Name = "NGAYNHAP";
            this.NGAYNHAP.ReadOnly = true;
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.DataPropertyName = "TONGTIEN";
            this.TONGTIEN.HeaderText = "Tổng tiền";
            this.TONGTIEN.Name = "TONGTIEN";
            this.TONGTIEN.ReadOnly = true;
            // 
            // QuanLyNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 356);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "QuanLyNhapKho";
            this.Text = "QuanLyNhapKho";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTiet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhieuNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewPhieuNhap;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox comboBoxSanPham;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.Button btnXoaPN;
        private System.Windows.Forms.Button btnTaoPN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
        private System.Windows.Forms.DataGridView dataGridViewChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
    }
}