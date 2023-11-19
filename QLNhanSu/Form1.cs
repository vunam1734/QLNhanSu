using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanSu
{
    public partial class Form1 : Form
    {
        HaHongDbContext db = new HaHongDbContext();
        BindingSource bs = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KhoiTaoDuLieu();
            LienKetDuLieu();
            bs.MoveFirst();
        }

        private void KhoiTaoDuLieu()
        {
            
            bs.DataSource = db.NHANVIENs.ToList();
            foreach (Control ctl in this.Controls)
                if (ctl is TextBox) ctl.DataBindings.Add("Text", bs, ctl.Name.Substring(3), true);
                else if (ctl is ComboBox) ctl.DataBindings.Add("SelectedValue", bs, ctl.Name.Substring(3), true);
        }

        private void LienKetDuLieu()
        {
            cboMaPhong.DisplayMember = "TenPH";
            cboMaPhong.ValueMember = "MaPhong";
            cboMaPhong.DataSource = db.PHONGBANs.ToList();
            cbomachucvu.DisplayMember = "TenChucVu";
            cbomachucvu.ValueMember = "MaChucVu";
            cbomachucvu.DataSource=db.ChucVus.ToList();
        }


        private void btnthem_Click(object sender, EventArgs e)
        {
            bs.AddNew();
            txtMaNV.ReadOnly = false;
            txtMaNV.Focus();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("", "Bạn có muốn xóa nhân viên này không ?", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                bs.RemoveCurrent();
                db.SaveChanges();
                MessageBox.Show("Xóa Thành công!!");
                txtMaNV.ReadOnly = true;
            }
            else if (dialog == DialogResult.No)
            {
                txtMaNV.Focus();
            }
        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("", "Bạn có muốn thêm nhân viên mới vào không ?", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                bs.EndEdit();
                NHANVIEN nHANVIEN = bs.Current as NHANVIEN;
                db.NHANVIENs.Add(nHANVIEN);
                db.SaveChanges();
                MessageBox.Show("Thêm Thành công!!");
                txtMaNV.ReadOnly = true;
            }
            else if (dialog == DialogResult.No)
            {
                txtMaNV.Focus();
            }
        }

        private void btnkhong_Click(object sender, EventArgs e)
        {
            bs.CancelEdit();
        }

        private void btndau_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }

        private void btntruoc_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void btnsau_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void btncuoi_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("", "Bạn có muốn thoát", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                txtMaNV.Focus();
            }
        }

        private void btnthemphong_Click(object sender, EventArgs e)
        {
            QLPhong qLPhong = new QLPhong();
            qLPhong.ShowDialog();
            LienKetDuLieu();
            KhoiTaoDuLieu();
        }
    }
}
