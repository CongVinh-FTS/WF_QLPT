using BÀI_TẬP_LỚN.các_from_đăng_nhập;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BÀI_TẬP_LỚN
{
    public partial class frmDangnhap : Form
    {
        private SqlConnection connection;
        private SqlCommand command;

        public frmDangnhap()
        {
            InitializeComponent();
            string connectionString = @"Data Source=VINH28\TESTDB;Initial Catalog=quanlyphongtro;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand("", connection);
        }
    

        

        private void frmDangnhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "SELECT COUNT(*) FROM QUANLY WHERE TAIKHOAN = @Username AND MATKHAU = @Password";
            command.CommandText = query;
            command.Parameters.AddWithValue("@Username", txtUser.Text);
            command.Parameters.AddWithValue("@Password", txtPass.Text);
            int userCount = (int)command.ExecuteScalar();
            connection.Close();

            if (userCount == 1)
            {
                // Đăng nhập thành công
                MessageBox.Show("Đăng nhập thành công!");
                
                var f = new Frmmain();
                f.ShowDialog();
                


            }
            else
            {
                // Đăng nhập thất bại
                MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại tên đăng nhập và mật khẩu.");
            }
        }


        

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            var f = new frmDoimatkhau();
            f.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncreateuser_Click(object sender, EventArgs e)
        {
            var f = new frmTaotk();
            f.ShowDialog();
        }
    }
}
