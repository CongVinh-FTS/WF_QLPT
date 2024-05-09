using DatabaseProgramming;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BÀI_TẬP_LỚN
{
    public partial class frmDSKhachhang : Form
    {
        clsDatabase cl = new clsDatabase();
        public frmDSKhachhang()
        {
            InitializeComponent();
        }

        private void frmDSKhachhang_Load(object sender, EventArgs e)
        {
            dgDsKhach.DataSource = cl.GetDataTable("select * from KHACHHANG");
            dgDsKhach.Columns["IDKHACHHANG"].HeaderText = "ID KHÁCH HÀNG";
            dgDsKhach.Columns["HOTEN"].HeaderText = "TÊN KHÁCH HÀNG";
            dgDsKhach.Columns["DIENTHOAI"].HeaderText = "SỐ ĐIỆN THOẠI";
            dgDsKhach.Columns["QUEQUAN"].HeaderText = "QUÊ QUÁN";
        }

        private void btnXoakhach_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtXoaORTimkiemkhach.Text, out int h))
                {
                    cl.ThucThi("delete from KHACHHANG where IDKHACHHANG = '" + txtXoaORTimkiemkhach.Text.Trim() + "'");
                    dgDsKhach.DataSource = cl.GetDataTable("select * from KHACHHANG");
                    txtXoaORTimkiemkhach.Text = "";
                    MessageBox.Show("Xóa khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cl.ThucThi("delete from KHACHHANG where HOTEN = '" + txtXoaORTimkiemkhach.Text.Trim() + "'");
                    dgDsKhach.DataSource = cl.GetDataTable("select * from KHACHHANG");
                    txtXoaORTimkiemkhach.Text = "";
                    MessageBox.Show("Xóa khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Không thể xóa khách này do khách này đang thuê phòng!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnAddkhach_Click(object sender, EventArgs e)
        {
            Form f = new frmAddKhachhang();
            f.ShowDialog();
            frmDSKhachhang_Load(sender, e);
        }

        private void dgDsKhach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hangchon = e.RowIndex;
                txtXoaORTimkiemkhach.Text = dgDsKhach[0, hangchon].Value.ToString().Trim();
            }
            catch
            {

            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtXoaORTimkiemkhach.Text, out int h))
            {
                dgDsKhach.DataSource = cl.GetDataTable("select * from KHACHHANG where IDKHACHHANG = '" + txtXoaORTimkiemkhach.Text.Trim() + "'");
            }
            else
            {
                dgDsKhach.DataSource = cl.GetDataTable("select * from KHACHHANG where HOTEN = '" + txtXoaORTimkiemkhach.Text.Trim() + "'");
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            dgDsKhach.DataSource = cl.GetDataTable("select * from KHACHHANG");
            txtXoaORTimkiemkhach.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtXoaORTimkiemkhach.Text))
            {
                btnXoakhach.Enabled = false;
                btnTimkiem.Enabled = false;
            }
            else
            {
                btnXoakhach.Enabled = true;
                btnTimkiem.Enabled = true;
            }
        }
    }
}
