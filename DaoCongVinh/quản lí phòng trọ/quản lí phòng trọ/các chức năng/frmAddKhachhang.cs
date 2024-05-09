using BÀI_TẬP_LỚN.formconvidu;
using DatabaseProgramming;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BÀI_TẬP_LỚN
{
    public partial class frmAddKhachhang : Form
    {
        clsDatabase cl = new clsDatabase();
        string strCon = @"Data Source=DESKTOP-4LS11N0\SQLEXPRESS;Initial Catalog=BAITAPLON_NGOCANH_VA_LONG;Integrated Security=True";
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        SqlDataAdapter sqlAdap, sqlAdap2, sqlAdap3;
        DataSet ds;
        DataTable dt, DT, Dt;

        private void frmAddKhachhang_Load(object sender, EventArgs e)
        {

        }

        public frmAddKhachhang()
        {
            InitializeComponent();
        }

        
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtCCCD.Text, out int n) && int.TryParse(txtSDT.Text,out int m))
            {
                cl.ThucThi("insert into KHACHHANG values(N'" + txtHoTenkhach.Text.Trim() + "','" + txtCCCD.Text.Trim() + "','" + txtSDT.Text.Trim() + "','" + txtQuequan.Text.Trim() + "')");
                MessageBox.Show("Thêm khách hàng thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            else
            {
                MessageBox.Show("Định dạng CCCD hoặc số điện thoại không hợp lệ, vui lòng nhập lại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtCCCD.Text) || String.IsNullOrEmpty(txtSDT.Text) || String.IsNullOrEmpty(txtHoTenkhach.Text))
            {
                btnXacnhan.Enabled = false;
            }
            else
            {
                btnXacnhan.Enabled = true;
            }
        }


    }
}
