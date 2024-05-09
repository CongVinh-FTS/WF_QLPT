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
    public partial class frmLoaiphong : Form
    {
        string strCon = @"Data Source=DESKTOP-4LS11N0\SQLEXPRESS;Initial Catalog=BAITAPLON_NGOCANH_VA_LONG;Integrated Security=True";
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        SqlDataReader sqlRe;//Tự nghiên cứu
        SqlDataAdapter sqlAdap;
        DataSet ds;
        DataTable dt;
        static int hangchon;
        public frmLoaiphong()
        {
            InitializeComponent();
            dgloaiphong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

        }
        clsDatabase cl = new clsDatabase();

        private void frmLoaiphong_Load(object sender, EventArgs e)
        {

            dgloaiphong.DataSource = cl.GetDataTable("select * from LOAIPHONG");
            DoiTenCot();

        }

        private void btnthemloaiphong_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtdongia.Text, out int n))
            {
                cl.ThucThi("insert into LOAIPHONG values(N'" + txtloaiphong.Text.Trim() + "', '" + txtdongia.Text.Trim() + "') ");
                MessageBox.Show("Thêm mới loại phòng thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgloaiphong.DataSource = cl.GetDataTable("select * from LOAIPHONG");
            }
            else
            {
                MessageBox.Show("Định dạng dữ liệu nhập vào không hợp lệ, vui lòng nhập lại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void dgloaiphong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                hangchon = e.RowIndex;

                txtloaiphong.Text = dgloaiphong[1, hangchon].Value.ToString().Trim();
                txtdongia.Text = dgloaiphong[2, hangchon].Value.ToString().Trim();
                txtmaorten.Text = dgloaiphong[0, hangchon].Value.ToString().Trim();
                txtDongia2.Text = dgloaiphong[2, hangchon].Value.ToString().Trim();
                txtLoaiphong2.Text = dgloaiphong[1, hangchon].Value.ToString().Trim();
                txtMaloaiphong.Text = dgloaiphong[0, hangchon].Value.ToString().Trim();
            }
            catch
            {

            }

        }

        private void btncapnhatloaiphong_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtDongia2.Text, out int n) && int.TryParse(txtMaloaiphong.Text, out int m))
            {
                cl.ThucThi("update LOAIPHONG set TENLOAIPHONG = N'" + txtLoaiphong2.Text.Trim() + "',DONGIA = '" + txtDongia2.Text.Trim() + "' where IDLOAIPHONG = '" + txtMaloaiphong.Text.Trim() + "'");
                dgloaiphong.DataSource = cl.GetDataTable("select * from LOAIPHONG");
                MessageBox.Show("Cập nhật loại phòng thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                xoaTxt();
            }
            else
            {
                MessageBox.Show("Định dạng dữ liệu nhập vào không hợp lệ, vui lòng nhập lại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        private void btnxoaloaiphong_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtmaorten.Text, out int n))
                {
                    cl.ThucThi("delete from LOAIPHONG where IDLOAIPHONG = '" + txtmaorten.Text.Trim() + "' ");
                    dgloaiphong.DataSource = cl.GetDataTable("select * from LOAIPHONG");
                    MessageBox.Show("Xóa loại phòng thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cl.ThucThi("delete from LOAIPHONG where TENLOAIPHONG = '" + txtmaorten.Text.Trim() + "' ");
                    dgloaiphong.DataSource = cl.GetDataTable("select * from LOAIPHONG");
                    MessageBox.Show("Xóa loại phòng thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Không thể xóa do có phòng thuộc loại này đang tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            dgloaiphong.DataSource = cl.GetDataTable("select * from LOAIPHONG");
            xoaTxt();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtmaorten.Text, out int n))
            {
                dgloaiphong.DataSource = cl.GetDataTable("select * from LOAIPHONG where IDLOAIPHONG = '" + txtmaorten.Text.Trim() + "'");
            }
            else
            {
                
                dgloaiphong.DataSource = cl.GetDataTable("select * from LOAIPHONG where TENLOAIPHONG = '" + txtmaorten.Text.Trim() + "'");
            }
        }

        void DoiTenCot()
        {
            dgloaiphong.Columns["IDLOAIPHONG"].HeaderText = "ID LOẠI PHÒNG";
            dgloaiphong.Columns["TENLOAIPHONG"].HeaderText = "TÊN LOẠI PHÒNG";
            dgloaiphong.Columns["DONGIA"].HeaderText = "ĐƠN GIÁ";
        }

        void xoaTxt()
        {
            txtloaiphong.Text = "";
            txtmaorten.Text = "";
            txtdongia.Text = "";
            txtDongia2.Text = "";
            txtLoaiphong2.Text = "";
            txtMaloaiphong.Text = "";
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtmaorten.Text))
            {
                btnxoaloaiphong.Enabled = false;
                btntimkiem.Enabled = false;
            }
            else
            {
                btnxoaloaiphong.Enabled = true;
                btntimkiem.Enabled = true;
            }

            if (string.IsNullOrEmpty(txtLoaiphong2.Text) || string.IsNullOrEmpty(txtDongia2.Text) || string.IsNullOrEmpty(txtMaloaiphong.Text))
            {
                btncapnhatloaiphong.Enabled = false;
            }
            else
            {
                btncapnhatloaiphong.Enabled = true;

            }

            if (string.IsNullOrEmpty(txtloaiphong.Text) || string.IsNullOrEmpty(txtdongia.Text))
            {
                btnthemloaiphong.Enabled = false;
            }
            else
            {
                btnthemloaiphong.Enabled = true;
            }
        }

        
    }
}



