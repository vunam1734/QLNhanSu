namespace QLNhanSu
{
    partial class QLPhong
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
            this.txttenph = new System.Windows.Forms.TextBox();
            this.txtmaphong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btndau = new System.Windows.Forms.Button();
            this.btntruoc = new System.Windows.Forms.Button();
            this.btnsau = new System.Windows.Forms.Button();
            this.btncuoi = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnkhong = new System.Windows.Forms.Button();
            this.btnghi = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txttenph
            // 
            this.txttenph.Location = new System.Drawing.Point(127, 192);
            this.txttenph.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txttenph.Name = "txttenph";
            this.txttenph.Size = new System.Drawing.Size(269, 22);
            this.txttenph.TabIndex = 132;
            this.txttenph.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtmaphong
            // 
            this.txtmaphong.Location = new System.Drawing.Point(127, 126);
            this.txtmaphong.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtmaphong.Name = "txtmaphong";
            this.txtmaphong.ReadOnly = true;
            this.txtmaphong.Size = new System.Drawing.Size(269, 22);
            this.txtmaphong.TabIndex = 131;
            this.txtmaphong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 130;
            this.label3.Text = "Tên phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 129;
            this.label2.Text = "Mã phòng";
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
            this.label1.Size = new System.Drawing.Size(631, 94);
            this.label1.TabIndex = 133;
            this.label1.Text = "QUẢN LÝ PHÒNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btndau
            // 
            this.btndau.Location = new System.Drawing.Point(25, 367);
            this.btndau.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btndau.Name = "btndau";
            this.btndau.Size = new System.Drawing.Size(75, 34);
            this.btndau.TabIndex = 147;
            this.btndau.Text = "Đầu";
            this.btndau.UseVisualStyleBackColor = true;
            this.btndau.Click += new System.EventHandler(this.btndau_Click);
            // 
            // btntruoc
            // 
            this.btntruoc.Location = new System.Drawing.Point(147, 367);
            this.btntruoc.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btntruoc.Name = "btntruoc";
            this.btntruoc.Size = new System.Drawing.Size(75, 34);
            this.btntruoc.TabIndex = 146;
            this.btntruoc.Text = "Trước";
            this.btntruoc.UseVisualStyleBackColor = true;
            this.btntruoc.Click += new System.EventHandler(this.btntruoc_Click);
            // 
            // btnsau
            // 
            this.btnsau.Location = new System.Drawing.Point(258, 367);
            this.btnsau.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnsau.Name = "btnsau";
            this.btnsau.Size = new System.Drawing.Size(75, 34);
            this.btnsau.TabIndex = 145;
            this.btnsau.Text = "Sau";
            this.btnsau.UseVisualStyleBackColor = true;
            this.btnsau.Click += new System.EventHandler(this.btnsau_Click);
            // 
            // btncuoi
            // 
            this.btncuoi.Location = new System.Drawing.Point(371, 367);
            this.btncuoi.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btncuoi.Name = "btncuoi";
            this.btncuoi.Size = new System.Drawing.Size(75, 34);
            this.btncuoi.TabIndex = 144;
            this.btncuoi.Text = "Cuối";
            this.btncuoi.UseVisualStyleBackColor = true;
            this.btncuoi.Click += new System.EventHandler(this.btncuoi_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(476, 367);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 34);
            this.btnthoat.TabIndex = 143;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnkhong
            // 
            this.btnkhong.Location = new System.Drawing.Point(476, 293);
            this.btnkhong.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnkhong.Name = "btnkhong";
            this.btnkhong.Size = new System.Drawing.Size(75, 34);
            this.btnkhong.TabIndex = 142;
            this.btnkhong.Text = "Không";
            this.btnkhong.UseVisualStyleBackColor = true;
            this.btnkhong.Click += new System.EventHandler(this.btnkhong_Click);
            // 
            // btnghi
            // 
            this.btnghi.Location = new System.Drawing.Point(476, 233);
            this.btnghi.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnghi.Name = "btnghi";
            this.btnghi.Size = new System.Drawing.Size(75, 34);
            this.btnghi.TabIndex = 141;
            this.btnghi.Text = "Ghi";
            this.btnghi.UseVisualStyleBackColor = true;
            this.btnghi.Click += new System.EventHandler(this.btnghi_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(476, 174);
            this.btnhuy.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 34);
            this.btnhuy.TabIndex = 140;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(476, 108);
            this.btnthem.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 34);
            this.btnthem.TabIndex = 139;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // QLPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 450);
            this.Controls.Add(this.btndau);
            this.Controls.Add(this.btntruoc);
            this.Controls.Add(this.btnsau);
            this.Controls.Add(this.btncuoi);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnkhong);
            this.Controls.Add(this.btnghi);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttenph);
            this.Controls.Add(this.txtmaphong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "QLPhong";
            this.Text = "QLPhong";
            this.Load += new System.EventHandler(this.QLPhong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttenph;
        private System.Windows.Forms.TextBox txtmaphong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndau;
        private System.Windows.Forms.Button btntruoc;
        private System.Windows.Forms.Button btnsau;
        private System.Windows.Forms.Button btncuoi;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnkhong;
        private System.Windows.Forms.Button btnghi;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnthem;
    }
}