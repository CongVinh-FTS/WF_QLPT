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

namespace BÀI_TẬP_LỚN.các_chức_năng
{
    public partial class frmTraphong : Form
    {
        string strCon = @"Data Source=VINH28\TESTDB;Initial Catalog=quanlyphongtro;Integrated Security=True";
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        SqlDataReader sqlRe;//Tự nghiên cứu
        SqlDataAdapter sqlAdap;
        DataSet ds;
        DataTable dt;
        clsDatabase cl = new clsDatabase();
        public frmTraphong()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmTraphong_Load(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            sqlAdap = new SqlDataAdapter("SELECT TP.IDTHUE,P.TENPHONG,TP.NGAYTHUE,TP.THANGTHUE\r\nFROM THUEPHONG TP\r\nINNER JOIN PHONG P ON TP.IDPHONG = P.IDPHONG where P.TRANGTHAI = 1", sqlCon);

            dt = new DataTable();
            sqlAdap.Fill(dt);
            cbTenphong.DataSource = dt;
            cbTenphong.DisplayMember = "TENPHONG";
            cbTenphong.ValueMember = "IDTHUE";
            sqlCon.Close();
            cbTenphong_SelectedIndexChanged(sender, e);

            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            sqlAdap = new SqlDataAdapter("select * from DICHVU", sqlCon);
            dt = new DataTable();
            sqlAdap.Fill(dt);
            cbDV.DataSource = dt;
            cbDV.DisplayMember = "TENDICHVU";
            cbDV.ValueMember = "IDDICHVU";
            sqlCon.Close();

            dgHtdichvu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgHtdichvu.DataSource = cl.GetDataTable("select TT.IDHOADON,DV.TENDICHVU,DV.GIATIENDV,TT.SOLUONG,DV.GIATIENDV * TT.SOLUONG AS TONGDV from TINHTIENDV TT inner join DICHVU DV ON TT.IDDICHVU = DV.IDDICHVU");

            themgiadvvaotxt();
            
        }

        private void cbTenphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                txtIDthue.Text = cbTenphong.SelectedValue.ToString();

                using (SqlConnection connection = new SqlConnection(strCon))
                {
                    connection.Open();

                    // Thực hiện truy vấn SQL để lấy dữ liệu
                    if (int.TryParse(cbTenphong.SelectedValue.ToString(), out int h))
                    {
                        string query = "SELECT TP.IDTHUE,LP.TENLOAIPHONG,P.TENPHONG,KH.HOTEN,KH.CCCD,KH.DIENTHOAI,KH.QUEQUAN,TP.NGAYTHUE,TP.THANGTHUE,LP.DONGIA,LP.DONGIA * TP.THANGTHUE AS TONG \r\nFROM THUEPHONG TP\r\nINNER JOIN PHONG P ON TP.IDPHONG = P.IDPHONG\r\nINNER JOIN LOAIPHONG LP ON P.IDLOAIPHONG = LP.IDLOAIPHONG\r\nINNER JOIN KHACHHANG KH ON TP.IDKHACHHANG = KH.IDKHACHHANG Where IDTHUE = '" + h + "'";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Thực hiện truy vấn và lấy dữ liệu
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read()) // Đọc dòng đầu tiên nếu có dữ liệu
                                {
                                    
                                    string thangthue = reader["THANGTHUE"].ToString();
                                    string sdt = reader["DIENTHOAI"].ToString();
                                    string ngaythue = reader["NGAYTHUE"].ToString();
                                    string hoten = reader["HOTEN"].ToString();
                                    string tong = reader["TONG"].ToString();

                                    
                                    txtThangthue.Text = thangthue;
                                    txtNgaythue.Text = ngaythue;
                                    txtKhachhang.Text = hoten;
                                    txtSDT.Text = sdt;
                                    txtTienphong.Text = tong;
                                }
                            }
                        }
                    }
                    connection.Close();
                }
            
            
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            if (int.TryParse(cbTenphong.SelectedValue.ToString(), out int h) && int.TryParse(cbDV.SelectedValue.ToString(),out int m))
            {
                cl.ThucThi("insert into TINHTIENDV(IDTHUE,IDDICHVU,SOLUONG) VALUES ('" + h + "','" + m + "','" + txtSoluong.Text.Trim() + "')");
                dgHtdichvu.DataSource = cl.GetDataTable("select TT.IDHOADON,DV.TENDICHVU,DV.GIATIENDV,TT.SOLUONG,DV.GIATIENDV * TT.SOLUONG AS TONGDV from TINHTIENDV TT inner join DICHVU DV ON TT.IDDICHVU = DV.IDDICHVU");
                themgiadvvaotxt();
                txtTongtien.Text = "";
            }
        }

        private void btnXoadv_Click(object sender, EventArgs e)
        {
            if (int.TryParse(cbDV.SelectedValue.ToString(),out int h))
            {
                cl.ThucThi("delete from TINHTIENDV where IDDICHVU = '" + h + "'");
                dgHtdichvu.DataSource = cl.GetDataTable("select TT.IDHOADON,DV.TENDICHVU,DV.GIATIENDV,TT.SOLUONG,DV.GIATIENDV * TT.SOLUONG AS TONGDV from TINHTIENDV TT inner join DICHVU DV ON TT.IDDICHVU = DV.IDDICHVU");
            }
            themgiadvvaotxt() ;
            
        }

        private void dgHtdichvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hangchon = e.RowIndex;

        }

        private void cbDV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void themgiadvvaotxt()
        {
            using (SqlConnection connection = new SqlConnection(strCon))
            {
                connection.Open();

                // Thực hiện truy vấn SQL để lấy dữ liệu

                string query = "select SUM(DV.GIATIENDV * TT.SOLUONG) AS SUMALL from TINHTIENDV TT inner join DICHVU DV ON TT.IDDICHVU = DV.IDDICHVU ";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thực hiện truy vấn và lấy dữ liệu
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // Đọc dòng đầu tiên nếu có dữ liệu
                        {
                            
                            string tongtien = reader["SUMALL"].ToString();

                            
                            txtTongtiendv.Text = tongtien;
                        }
                    }
                }

                connection.Close();
            }
        }

        private void btnTongtien_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtTongtiendv.Text))
            {
                txtTongtiendv.Text = "0";
            }
            int m = Convert.ToInt32(txtTongtiendv.Text);
            int n = Convert.ToInt32(txtTienphong.Text);
            int tong = m + n;
            txtTongtien.Text = tong.ToString();
        }

        private void btnInhoadon_Click(object sender, EventArgs e)
        {
            if (int.TryParse(cbTenphong.SelectedValue.ToString(), out int h) && int.TryParse(txtTongtien.Text,out int price))
            {
                cl.ThucThi("INSERT INTO TONGTIEN(IDTHUE,THANGTHUE,TENKHACH,TONGTIEN) VALUES('" + h + "','" + txtThangthue.Text.Trim() + "','" + txtKhachhang.Text.Trim() + "','" + price + "')");
                cl.ThucThi("UPDATE PHONG\r\nSET TRANGTHAI = 0\r\nFROM PHONG P\r\nINNER JOIN THUEPHONG TP ON P.IDPHONG = TP.IDPHONG\r\nWHERE TP.IDTHUE = '" + h + "'");
                cl.ThucThi("DELETE FROM TINHTIENDV");
                cl.ThucThi("delete from THUEPHONG where IDTHUE = '" + h + "'");
                
                MessageBox.Show("In hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSoluong.Text) || string.IsNullOrEmpty(cbDV.Text))
            {
                btnThemDV.Enabled = false;
                
            }
            else
            {
                btnThemDV.Enabled = true;
                
            }

            if (string.IsNullOrEmpty(cbDV.Text))
            {
                btnXoadv.Enabled = false;

            }
            else
            {
                btnXoadv.Enabled= true;

            }
            if (string.IsNullOrEmpty(txtTongtien.Text))
            {
                btnInhoadon.Enabled = false;
            }
            else
            {
                btnInhoadon.Enabled= true;
            }
        }

        
    }
}
