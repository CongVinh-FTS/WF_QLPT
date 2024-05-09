using DatabaseProgramming;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BÀI_TẬP_LỚN.các_from_đăng_nhập
{
    public partial class frmTaotk : Form
    {
        clsDatabase cl = new clsDatabase();
        public frmTaotk()
        {
            InitializeComponent();
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            cl.ThucThi("insert into QUANLY(TAIKHOAN,MATKHAU) values('" + txtUserchange.Text.Trim() + "','" + txtPasschange.Text.Trim() + "')");
            MessageBox.Show("Tạo tài khoản thành công","Thông báo");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
