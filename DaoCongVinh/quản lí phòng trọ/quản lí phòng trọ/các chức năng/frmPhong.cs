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
    public partial class frmPhong : Form
    {

        string strCon = @"Data Source=VINH28\TESTDB;Initial Catalog=quanlyphongtro;Integrated Security=True";
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        SqlDataReader sqlRe;//Tự nghiên cứu
        SqlDataAdapter sqlAdap;
        DataSet ds;
        DataTable dt;
        clsDatabase cl = new clsDatabase();
        int trangthai;
        public frmPhong()
        {
            InitializeComponent();

        }

        private void frmPhong_Load(object sender, EventArgs e)
        {

            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            sqlAdap = new SqlDataAdapter("select * from LOAIPHONG", sqlCon);

            dt = new DataTable();
            sqlAdap.Fill(dt);
            cbloaiphong.DataSource = dt;
            cbloaiphong.DisplayMember = "TENLOAIPHONG";
            cbloaiphong.ValueMember = "IDLOAIPHONG";
            sqlCon.Close();
            dgPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPhong.DataSource = cl.GetDataTable("select P.IDPHONG,P.TENPHONG,P.IDLOAIPHONG,LP.TENLOAIPHONG,LP.DONGIA,\r\ncase\r\n\twhen P.TRANGTHAI = 1 then N'Hoạt động'\r\n\telse N'Không hoạt động'\r\nend as TRANGTHAI\r\nfrom PHONG P inner join LOAIPHONG LP on P.IDLOAIPHONG = LP.IDLOAIPHONG ");
            DatTenCot();

            dgLoaiphongHT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgLoaiphongHT.DataSource = cl.GetDataTable("select * from LOAIPHONG");
            dgLoaiphongHT.Columns["IDLOAIPHONG"].HeaderText = "ID LOẠI PHÒNG";
            dgLoaiphongHT.Columns["TENLOAIPHONG"].HeaderText = "TÊN LOẠI PHÒNG";
            dgLoaiphongHT.Columns["DONGIA"].HeaderText = "ĐƠN GIÁ";

        }

        private void btnthemphong_Click(object sender, EventArgs e)
        {
            if (ckbtrangthai.Checked == true)
            {
                trangthai = 1;
            }
            else
            {
                trangthai = 0;
            }
            sqlCon.Open();
            using (SqlCommand cmd = new SqlCommand("insert into PHONG(TENPHONG,IDLOAIPHONG,TRANGTHAI) values(N'" + txtTenphong.Text.Trim() + "','" + cbloaiphong.SelectedValue.ToString().Trim() + "', @TRANGTHAI)", sqlCon))
            {
                // Sử dụng SqlParameter để tránh lỗ hổng SQL Injection và đảm bảo an toàn về kiểu dữ liệu.
                cmd.Parameters.Add("@TRANGTHAI", SqlDbType.Int).Value = trangthai;

                // Thực hiện câu lệnh SQL để chèn ngày và tháng vào cơ sở dữ liệu
                cmd.ExecuteNonQuery();
            }
            sqlCon.Close();
            dgPhong.DataSource = cl.GetDataTable("select P.IDPHONG,P.TENPHONG,P.IDLOAIPHONG,LP.TENLOAIPHONG,LP.DONGIA,\r\ncase\r\n\twhen P.TRANGTHAI = 1 then N'Hoạt động'\r\n\telse N'Không hoạt động'\r\nend as TRANGTHAI\r\nfrom PHONG P inner join LOAIPHONG LP on P.IDLOAIPHONG = LP.IDLOAIPHONG ");
            MessageBox.Show("Thêm phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DatTenCot();
        }



        private void btntimkiemphong_Click(object sender, EventArgs e)
        {
            sqlAdap = new SqlDataAdapter("select P.IDPHONG,P.TENPHONG,P.IDLOAIPHONG,LP.TENLOAIPHONG,LP.DONGIA from PHONG P inner join LOAIPHONG LP on P.IDLOAIPHONG = LP.IDLOAIPHONG where P.TENPHONG = N'" + txtTenphong.Text.Trim() + "' and P.IDLOAIPHONG = '" + cbloaiphong.SelectedValue.ToString().Trim() + "'", strCon);
            //B2
            dt = new DataTable();
            sqlAdap.Fill(dt);

            dgPhong.DataSource = dt;
            if (dt.Rows.Count > 1)
            {
                MessageBox.Show("Có " + dt.Rows.Count + " phòng có tên trùng nhau trong danh sách phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dgPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hangdoi = e.RowIndex;
                txtTenphong.Text = dgPhong[1, hangdoi].Value.ToString().Trim();
                cbloaiphong.Text = dgPhong[3, hangdoi].Value.ToString().Trim();
                txtmaphong.Text = dgPhong[0, hangdoi].Value.ToString().Trim();
            }
            catch (Exception i)
            {

            }


        }

        

        void xoatxt()
        {
            txtTenphong.Text = "";
            
            txtmaphong.Text = "";
            ckbtrangthai.Checked = false;
        }

        void DatTenCot()
        {
            dgPhong.Columns["IDPHONG"].HeaderText = "ID PHÒNG";
            dgPhong.Columns["TENPHONG"].HeaderText = "TÊN PHÒNG";
            dgPhong.Columns["IDLOAIPHONG"].HeaderText = "ID LOẠI PHÒNG";
            dgPhong.Columns["TENLOAIPHONG"].HeaderText = "TÊN LOẠI PHÒNG";
            dgPhong.Columns["DONGIA"].HeaderText = "ĐƠN GIÁ";
            dgPhong.Columns["TRANGTHAI"].HeaderText = "TRẠNG THÁI";

        }

        private void btnxoaphong_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtmaphong.Text, out int n))
                {
                    cl.ThucThi("delete from PHONG where IDPHONG = '" + txtmaphong.Text.Trim() + "' ");
                    MessageBox.Show("Xóa phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgPhong.DataSource = cl.GetDataTable("select P.IDPHONG,P.TENPHONG,P.IDLOAIPHONG,LP.TENLOAIPHONG,LP.DONGIA,\r\ncase\r\n\twhen P.TRANGTHAI = 1 then N'Hoạt động'\r\n\telse N'Không hoạt động'\r\nend as TRANGTHAI\r\nfrom PHONG P inner join LOAIPHONG LP on P.IDLOAIPHONG = LP.IDLOAIPHONG ");
                    xoatxt();
                }
                else
                {
                    MessageBox.Show("Định dạng dữ liệu nhập vào không hợp lệ, vui lòng nhập lại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Không thể xóa do có khách đang thuê phòng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnupdatetrangthai_Click(object sender, EventArgs e)
        {
            if (ckbtrangthai2.Checked == true)
            {
                trangthai = 1;
            }
            else
            {
                trangthai = 0;
            }
            if (int.TryParse(txtmaphong.Text, out int n))
            {
                sqlCon.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE PHONG\r\nSET TRANGTHAI = @TRANGTHAI\r\nFROM PHONG\r\nWHERE IDPHONG = '" + txtmaphong.Text.Trim() + "'", sqlCon))
                {
                    // Sử dụng SqlParameter để tránh lỗ hổng SQL Injection và đảm bảo an toàn về kiểu dữ liệu.
                    cmd.Parameters.Add("@TRANGTHAI", SqlDbType.Int).Value = trangthai;

                    // Thực hiện câu lệnh SQL để chèn ngày và tháng vào cơ sở dữ liệu
                    cmd.ExecuteNonQuery();
                }
                sqlCon.Close();
                MessageBox.Show("Cập nhật trạng thái phòng thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Định dạng dữ liệu nhập vào không hợp lệ, vui lòng nhập lại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dgPhong.DataSource = cl.GetDataTable("select P.IDPHONG,P.TENPHONG,P.IDLOAIPHONG,LP.TENLOAIPHONG,LP.DONGIA,\r\ncase\r\n\twhen P.TRANGTHAI = 1 then N'Hoạt động'\r\n\telse N'Không hoạt động'\r\nend as TRANGTHAI\r\nfrom PHONG P inner join LOAIPHONG LP on P.IDLOAIPHONG = LP.IDLOAIPHONG ");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmaphong.Text))
            {
                btnxoaphong.Enabled = false;
                btnupdatetrangthai.Enabled = false;
            }
            else
            {
                btnxoaphong.Enabled = true;
                btnupdatetrangthai.Enabled = true;
            }

            if (string.IsNullOrEmpty(txtTenphong.Text))
            {
                btnthemphong.Enabled = false;
            }
            else
            {
                btnthemphong.Enabled = true;
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            dgPhong.DataSource = cl.GetDataTable("select P.IDPHONG,P.TENPHONG,P.IDLOAIPHONG,LP.TENLOAIPHONG,LP.DONGIA,\r\ncase\r\n\twhen P.TRANGTHAI = 1 then N'Hoạt động'\r\n\telse N'Không hoạt động'\r\nend as TRANGTHAI\r\nfrom PHONG P inner join LOAIPHONG LP on P.IDLOAIPHONG = LP.IDLOAIPHONG ");
            xoatxt();
        }
    }

}
