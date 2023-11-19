namespace QLNhanSu
{
    partial class Form1
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cbomachucvu = new System.Windows.Forms.ComboBox();
            this.cboMaPhong = new System.Windows.Forms.ComboBox();
            this.btndau = new System.Windows.Forms.Button();
            this.btntruoc = new System.Windows.Forms.Button();
            this.btnsau = new System.Windows.Forms.Button();
            this.btncuoi = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnkhong = new System.Windows.Forms.Button();
            this.btnghi = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnthemphong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cbomachucvu
            // 
            this.cbomachucvu.FormattingEnabled = true;
            this.cbomachucvu.Location = new System.Drawing.Point(214, 309);
            this.cbomachucvu.Name = "cbomachucvu";
            this.cbomachucvu.Size = new System.Drawing.Size(163, 24);
            this.cbomachucvu.TabIndex = 140;
            // 
            // cboMaPhong
            // 
            this.cboMaPhong.FormattingEnabled = true;
            this.cboMaPhong.Location = new System.Drawing.Point(214, 248);
            this.cboMaPhong.Margin = new System.Windows.Forms.Padding(5);
            this.cboMaPhong.Name = "cboMaPhong";
            this.cboMaPhong.Size = new System.Drawing.Size(163, 24);
            this.cboMaPhong.TabIndex = 139;
            // 
            // btndau
            // 
            this.btndau.Location = new System.Drawing.Point(61, 412);
            this.btndau.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btndau.Name = "btndau";
            this.btndau.Size = new System.Drawing.Size(75, 34);
            this.btndau.TabIndex = 138;
            this.btndau.Text = "Đầu";
            this.btndau.UseVisualStyleBackColor = true;
            this.btndau.Click += new System.EventHandler(this.btndau_Click);
            // 
            // btntruoc
            // 
            this.btntruoc.Location = new System.Drawing.Point(183, 412);
            this.btntruoc.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btntruoc.Name = "btntruoc";
            this.btntruoc.Size = new System.Drawing.Size(75, 34);
            this.btntruoc.TabIndex = 137;
            this.btntruoc.Text = "Trước";
            this.btntruoc.UseVisualStyleBackColor = true;
            this.btntruoc.Click += new System.EventHandler(this.btntruoc_Click);
            // 
            // btnsau
            // 
            this.btnsau.Location = new System.Drawing.Point(294, 412);
            this.btnsau.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnsau.Name = "btnsau";
            this.btnsau.Size = new System.Drawing.Size(75, 34);
            this.btnsau.TabIndex = 136;
            this.btnsau.Text = "Sau";
            this.btnsau.UseVisualStyleBackColor = true;
            this.btnsau.Click += new System.EventHandler(this.btnsau_Click);
            // 
            // btncuoi
            // 
            this.btncuoi.Location = new System.Drawing.Point(407, 412);
            this.btncuoi.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btncuoi.Name = "btncuoi";
            this.btncuoi.Size = new System.Drawing.Size(75, 34);
            this.btncuoi.TabIndex = 135;
            this.btncuoi.Text = "Cuối";
            this.btncuoi.UseVisualStyleBackColor = true;
            this.btncuoi.Click += new System.EventHandler(this.btncuoi_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(512, 412);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 34);
            this.btnthoat.TabIndex = 134;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnkhong
            // 
            this.btnkhong.Location = new System.Drawing.Point(512, 338);
            this.btnkhong.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnkhong.Name = "btnkhong";
            this.btnkhong.Size = new System.Drawing.Size(75, 34);
            this.btnkhong.TabIndex = 133;
            this.btnkhong.Text = "Không";
            this.btnkhong.UseVisualStyleBackColor = true;
            this.btnkhong.Click += new System.EventHandler(this.btnkhong_Click);
            // 
            // btnghi
            // 
            this.btnghi.Location = new System.Drawing.Point(512, 278);
            this.btnghi.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnghi.Name = "btnghi";
            this.btnghi.Size = new System.Drawing.Size(75, 34);
            this.btnghi.TabIndex = 132;
            this.btnghi.Text = "Ghi";
            this.btnghi.UseVisualStyleBackColor = true;
            this.btnghi.Click += new System.EventHandler(this.btnghi_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(512, 219);
            this.btnhuy.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 34);
            this.btnhuy.TabIndex = 131;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(512, 153);
            this.btnthem.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 34);
            this.btnthem.TabIndex = 130;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(216, 370);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(268, 22);
            this.txtLuong.TabIndex = 129;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(216, 186);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(268, 22);
            this.txtHoTen.TabIndex = 128;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(214, 120);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(269, 22);
            this.txtMaNV.TabIndex = 127;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 370);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 126;
            this.label6.Text = "Lương";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 309);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 125;
            this.label5.Text = "Chức vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 248);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 124;
            this.label4.Text = "Tên Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 123;
            this.label3.Text = "Họ tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 122;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(706, 94);
            this.label1.TabIndex = 121;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnthemphong
            // 
            this.btnthemphong.Location = new System.Drawing.Point(407, 238);
            this.btnthemphong.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnthemphong.Name = "btnthemphong";
            this.btnthemphong.Size = new System.Drawing.Size(75, 34);
            this.btnthemphong.TabIndex = 130;
            this.btnthemphong.Text = "Thêm";
            this.btnthemphong.UseVisualStyleBackColor = true;
            this.btnthemphong.Click += new System.EventHandler(this.btnthemphong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 513);
            this.Controls.Add(this.cbomachucvu);
            this.Controls.Add(this.cboMaPhong);
            this.Controls.Add(this.btndau);
            this.Controls.Add(this.btntruoc);
            this.Controls.Add(this.btnsau);
            this.Controls.Add(this.btncuoi);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnkhong);
            this.Controls.Add(this.btnghi);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnthemphong);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox cbomachucvu;
        private System.Windows.Forms.ComboBox cboMaPhong;
        private System.Windows.Forms.Button btndau;
        private System.Windows.Forms.Button btntruoc;
        private System.Windows.Forms.Button btnsau;
        private System.Windows.Forms.Button btncuoi;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnkhong;
        private System.Windows.Forms.Button btnghi;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnthemphong;
    }
}

