namespace DoAn_QuanLyMayLanh
{
    partial class DoiMatKhau
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
            this.components = new System.ComponentModel.Container();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMKMoi = new System.Windows.Forms.TextBox();
            this.txtMKCu = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtMKMoi_XacNhan = new System.Windows.Forms.TextBox();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(174, 139);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(75, 23);
            this.btnXacNhan.TabIndex = 9;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mật khẩu cũ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.Location = new System.Drawing.Point(135, 59);
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.Size = new System.Drawing.Size(258, 20);
            this.txtMKMoi.TabIndex = 6;
            this.txtMKMoi.UseSystemPasswordChar = true;
            this.txtMKMoi.TextChanged += new System.EventHandler(this.txtMKMoi_TextChanged);
            // 
            // txtMKCu
            // 
            this.txtMKCu.Location = new System.Drawing.Point(135, 23);
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.Size = new System.Drawing.Size(258, 20);
            this.txtMKCu.TabIndex = 5;
            this.txtMKCu.UseSystemPasswordChar = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Xác nhận mật khẩu mới";
            // 
            // txtMKMoi_XacNhan
            // 
            this.txtMKMoi_XacNhan.Location = new System.Drawing.Point(135, 94);
            this.txtMKMoi_XacNhan.Name = "txtMKMoi_XacNhan";
            this.txtMKMoi_XacNhan.Size = new System.Drawing.Size(258, 20);
            this.txtMKMoi_XacNhan.TabIndex = 10;
            this.txtMKMoi_XacNhan.UseSystemPasswordChar = true;
            this.txtMKMoi_XacNhan.TextChanged += new System.EventHandler(this.txtMKMoi_XacNhan_TextChanged);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 174);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMKMoi_XacNhan);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMKMoi);
            this.Controls.Add(this.txtMKCu);
            this.Name = "DoiMatKhau";
            this.Text = "DoiMatKhau";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMKMoi;
        private System.Windows.Forms.TextBox txtMKCu;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMKMoi_XacNhan;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}