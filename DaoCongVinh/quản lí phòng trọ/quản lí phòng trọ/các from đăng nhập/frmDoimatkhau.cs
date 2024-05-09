using DatabaseProgramming;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BÀI_TẬP_LỚN.các_from_đăng_nhập
{
    public partial class frmDoimatkhau : Form
    {
        clsDatabase cl = new clsDatabase();
        public frmDoimatkhau()
        {
            InitializeComponent();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            cl.ThucThi("update QUANLY set MATKHAU = '" + txtNewPass.Text.Trim() + "' WHERE TAIKHOAN = '" + txtUser.Text.Trim() + "' AND MATKHAU = '" + txtOldPass.Text.Trim() + "'");
            MessageBox.Show("Mật khẩu đã được thay đổi thành công.");
            this.Close();
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
