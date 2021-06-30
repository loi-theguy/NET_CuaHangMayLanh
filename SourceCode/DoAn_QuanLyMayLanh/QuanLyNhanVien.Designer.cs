namespace DoAn_QuanLyMayLanh
{
    partial class QuanLyNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyNhanVien));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewNhanVien = new System.Windows.Forms.DataGridView();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYVL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblXacNhanMK = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtMatKhau_XacNhan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxLoaiNV = new System.Windows.Forms.ComboBox();
            this.mtxtNgayVaoLam = new System.Windows.Forms.MaskedTextBox();
            this.mtxtNgaySinh = new System.Windows.Forms.MaskedTextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(678, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(113, 22);
            this.btnThem.Text = "Thêm nhân viên";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(98, 22);
            this.btnSua.Text = "Sửa thông tin";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 22);
            this.btnXoa.Text = "Xóa nhân viên";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(93, 22);
            this.btnLuu.Text = "Lưu thay đổi";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewNhanVien);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 425);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhân viên";
            // 
            // dataGridViewNhanVien
            // 
            this.dataGridViewNhanVien.AllowUserToAddRows = false;
            this.dataGridViewNhanVien.AllowUserToDeleteRows = false;
            this.dataGridViewNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANV,
            this.HOTEN,
            this.NGAYSINH,
            this.NGAYVL,
            this.USERNAME,
            this.LOAI});
            this.dataGridViewNhanVien.Location = new System.Drawing.Point(12, 30);
            this.dataGridViewNhanVien.Name = "dataGridViewNhanVien";
            this.dataGridViewNhanVien.ReadOnly = true;
            this.dataGridViewNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNhanVien.Size = new System.Drawing.Size(654, 194);
            this.dataGridViewNhanVien.TabIndex = 0;
            this.dataGridViewNhanVien.Click += new System.EventHandler(this.dataGridViewNhanVien_Click);
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã nhân viên";
            this.MANV.Name = "MANV";
            this.MANV.ReadOnly = true;
            // 
            // HOTEN
            // 
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "Họ tên";
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.ReadOnly = true;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "Ngày sinh";
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.ReadOnly = true;
            // 
            // NGAYVL
            // 
            this.NGAYVL.DataPropertyName = "NGAYVL";
            this.NGAYVL.HeaderText = "Ngày vào làm";
            this.NGAYVL.Name = "NGAYVL";
            this.NGAYVL.ReadOnly = true;
            // 
            // USERNAME
            // 
            this.USERNAME.DataPropertyName = "USERNAME";
            this.USERNAME.HeaderText = "Tên đăng nhập";
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.ReadOnly = true;
            // 
            // LOAI
            // 
            this.LOAI.DataPropertyName = "TENLOAI";
            this.LOAI.HeaderText = "Loại nhân viên";
            this.LOAI.Name = "LOAI";
            this.LOAI.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.lblXacNhanMK);
            this.groupBox2.Controls.Add(this.lblMatKhau);
            this.groupBox2.Controls.Add(this.txtMatKhau_XacNhan);
            this.groupBox2.Controls.Add(this.txtMatKhau);
            this.groupBox2.Controls.Add(this.btnXacNhan);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBoxLoaiNV);
            this.groupBox2.Controls.Add(this.mtxtNgayVaoLam);
            this.groupBox2.Controls.Add(this.mtxtNgaySinh);
            this.groupBox2.Controls.Add(this.txtUsername);
            this.groupBox2.Controls.Add(this.txtTen);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(678, 184);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // lblXacNhanMK
            // 
            this.lblXacNhanMK.AutoSize = true;
            this.lblXacNhanMK.Location = new System.Drawing.Point(223, 146);
            this.lblXacNhanMK.Name = "lblXacNhanMK";
            this.lblXacNhanMK.Size = new System.Drawing.Size(93, 13);
            this.lblXacNhanMK.TabIndex = 15;
            this.lblXacNhanMK.Text = "Nhập lại mật khẩu";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(12, 146);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(52, 13);
            this.lblMatKhau.TabIndex = 14;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // txtMatKhau_XacNhan
            // 
            this.txtMatKhau_XacNhan.Location = new System.Drawing.Point(322, 143);
            this.txtMatKhau_XacNhan.Name = "txtMatKhau_XacNhan";
            this.txtMatKhau_XacNhan.Size = new System.Drawing.Size(100, 20);
            this.txtMatKhau_XacNhan.TabIndex = 13;
            this.txtMatKhau_XacNhan.UseSystemPasswordChar = true;
            this.txtMatKhau_XacNhan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhau_XacNhan_KeyPress);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(87, 143);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(100, 20);
            this.txtMatKhau.TabIndex = 12;
            this.txtMatKhau.UseSystemPasswordChar = true;
            this.txtMatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhau_KeyPress);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXacNhan.Location = new System.Drawing.Point(465, 93);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(75, 66);
            this.btnXacNhan.TabIndex = 11;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày vào làm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Loại nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Họ tên";
            // 
            // comboBoxLoaiNV
            // 
            this.comboBoxLoaiNV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxLoaiNV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxLoaiNV.FormattingEnabled = true;
            this.comboBoxLoaiNV.Location = new System.Drawing.Point(500, 33);
            this.comboBoxLoaiNV.Name = "comboBoxLoaiNV";
            this.comboBoxLoaiNV.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLoaiNV.TabIndex = 5;
            this.comboBoxLoaiNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxLoaiNV_KeyPress);
            // 
            // mtxtNgayVaoLam
            // 
            this.mtxtNgayVaoLam.Location = new System.Drawing.Point(301, 95);
            this.mtxtNgayVaoLam.Mask = "00/00/0000";
            this.mtxtNgayVaoLam.Name = "mtxtNgayVaoLam";
            this.mtxtNgayVaoLam.Size = new System.Drawing.Size(73, 20);
            this.mtxtNgayVaoLam.TabIndex = 4;
            this.mtxtNgayVaoLam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtNgayVaoLam_KeyPress);
            // 
            // mtxtNgaySinh
            // 
            this.mtxtNgaySinh.Location = new System.Drawing.Point(87, 95);
            this.mtxtNgaySinh.Mask = "00/00/0000";
            this.mtxtNgaySinh.Name = "mtxtNgaySinh";
            this.mtxtNgaySinh.Size = new System.Drawing.Size(75, 20);
            this.mtxtNgaySinh.TabIndex = 3;
            this.mtxtNgaySinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtNgaySinh_KeyPress);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(287, 33);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(87, 33);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 20);
            this.txtTen.TabIndex = 0;
            this.txtTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTen_KeyPress);
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "QuanLyNhanVien";
            this.Text = "QuanLyNhanVien";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewNhanVien;
        private System.Windows.Forms.MaskedTextBox mtxtNgayVaoLam;
        private System.Windows.Forms.MaskedTextBox mtxtNgaySinh;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxLoaiNV;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYVL;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOAI;
        private System.Windows.Forms.TextBox txtMatKhau_XacNhan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lblXacNhanMK;
        private System.Windows.Forms.Label lblMatKhau;

    }
}