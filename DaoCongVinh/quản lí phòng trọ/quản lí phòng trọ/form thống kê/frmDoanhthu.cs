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

namespace BÀI_TẬP_LỚN.form_thống_kê
{
    public partial class frmDoanhthu : Form
    {
        string strCon = @"Data Source=VINH28\TESTDB;Initial Catalog=quanlyphongtro;Integrated Security=True";
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        SqlDataReader sqlRe;//Tự nghiên cứu
        SqlDataAdapter sqlAdap;
        DataSet ds;
        DataTable dt;
        clsDatabase cl = new clsDatabase();
        public frmDoanhthu()
        {
            InitializeComponent();
        }

        private void dgthongke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmDoanhthu_Load(object sender, EventArgs e)
        {
            
            dgthongke.DataSource = cl.GetDataTable("select * from TONGTIEN");
            using (SqlConnection connection = new SqlConnection(strCon))
            {
                connection.Open();

                // Thực hiện truy vấn SQL để lấy dữ liệu

                string query = "select Sum(TONGTIEN) AS TONG FROM TONGTIEN";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thực hiện truy vấn và lấy dữ liệu
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // Đọc dòng đầu tiên nếu có dữ liệu
                        {
                            // Lấy giá trị từ cột "Ten" (thay "Ten" bằng tên cột bạn muốn)
                            string tongtien = reader["TONG"].ToString();

                            // Hiển thị giá trị lên TextBox
                            txttongdoanhthu.Text = tongtien;
                        }
                    }
                }

                connection.Close();
            }
        }

        private void dgthongke_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoathanhtoan_Click(object sender, EventArgs e)
        {
            
            if(MessageBox.Show("Bạn có chắc muốn xóa lịch sử các phòng đã thanh toán không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cl.ThucThi("delete from TONGTIEN");
                dgthongke.DataSource = cl.GetDataTable("select * from TONGTIEN");
                txttongdoanhthu.Text = "0";
                MessageBox.Show("Xóa phòng thành công", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txttongdoanhthu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
