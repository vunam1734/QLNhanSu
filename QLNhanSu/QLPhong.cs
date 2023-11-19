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
    public partial class QLPhong : Form
    {
        HaHongDbContext db = new HaHongDbContext();
        BindingSource bs = new BindingSource();
        public QLPhong()
        {
            InitializeComponent();
        }

        private void QLPhong_Load(object sender, EventArgs e)
        {
            KhoiTaoDuLieu();
            LienKetDuLieu();
        }

        private void KhoiTaoDuLieu()
        {
            bs.DataSource = db.PHONGBANs.ToList();
            foreach (Control ctl in this.Controls)
                if (ctl is TextBox) ctl.DataBindings.Add("Text", bs, ctl.Name.Substring(3), true);
                else if (ctl is ComboBox) ctl.DataBindings.Add("SelectedValue", bs, ctl.Name.Substring(3), true);
        }

        private void LienKetDuLieu()
        {
           bs.DataSource=db.PHONGBANs.ToList();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            bs.AddNew();
            txtmaphong.ReadOnly = false;
            txtmaphong.Focus();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("", "Bạn có muốn xóa phòng này không ?", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                bs.RemoveCurrent();
                db.SaveChanges();
                MessageBox.Show("Xóa Thành công!!");
                txtmaphong.ReadOnly = true;
            }
            else if (dialog == DialogResult.No)
            {
                txtmaphong.Focus();
            }
        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("", "Bạn có muốn thêm phòng mới vào không ?", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                bs.EndEdit();
                PHONGBAN pHONGBAN = bs.Current as PHONGBAN;
                db.PHONGBANs.Add(pHONGBAN);
                db.SaveChanges();
                MessageBox.Show("Thêm Thành công!!");
                txtmaphong.ReadOnly = true;
            }
            else if (dialog == DialogResult.No)
            {
                txtmaphong.Focus();
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
            DialogResult dialog = MessageBox.Show("", "Bạn có muốn thoát ?", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                txtmaphong.Focus();
            }
        }
    }
}
