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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BÀI_TẬP_LỚN.formconvidu
{
    public partial class frmThemphongthue : Form
    {
        string strCon = @"Data Source=VINH28\TESTDB;Initial Catalog=quanlyphongtro;Integrated Security=True";
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        SqlDataAdapter sqlAdap, sqlAdap2, sqlAdap3;
        DataSet ds;
        DataTable dt, DT, Dt;
        clsDatabase cl = new clsDatabase();
        public frmThemphongthue()
        {
            InitializeComponent();


        }


        private void frmThemphongthue_Load(object sender, EventArgs e)
        {
            //ADD tên loại phòng vào combobox
            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            sqlAdap = new SqlDataAdapter("select * from LOAIPHONG", sqlCon);
            dt = new DataTable();
            sqlAdap.Fill(dt);
            cbLoaiphongthue.DataSource = dt;
            cbLoaiphongthue.ValueMember = "IDLOAIPHONG";
            cbLoaiphongthue.DisplayMember = "TENLOAIPHONG";
            sqlCon.Close();




            //ADD tên khách hàng vào combobox
            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            sqlAdap3 = new SqlDataAdapter("select * from KHACHHANG", sqlCon);
            Dt = new DataTable();
            sqlAdap3.Fill(Dt);
            cbKhachhang.DataSource = Dt;
            cbKhachhang.ValueMember = "IDKHACHHANG";
            cbKhachhang.DisplayMember = "HOTEN";
            sqlCon.Close();

            dtpNgaythue.CustomFormat = "dd/MM/yyyy";
            dtpNgaythue.Format = DateTimePickerFormat.Custom;
            dtpNgaythue.Text = DateTime.Now.ToString();
           
        }


        private void btnXacnhan_Click(object sender, EventArgs e)
        {

            int n, m;
            if (int.TryParse(cbtenphongthue.SelectedValue.ToString(), out n) && int.TryParse(cbKhachhang.SelectedValue.ToString(), out m))
            {
                // Chuyển đổi thành công, tiến hành thêm vào CSDL.
                cl.ThucThi("insert into THUEPHONG(IDPHONG,IDKHACHHANG,NGAYTHUE,THANGTHUE) VALUES ('" + n + "','" + m + "','" + dtpNgaythue.Value + "','" + txtThangthue.Text.Trim() + "')");
                cl.ThucThi("UPDATE PHONG\r\nSET TRANGTHAI = 1\r\nFROM PHONG P\r\nINNER JOIN THUEPHONG TP ON P.IDPHONG = TP.IDPHONG\r\nWHERE TP.IDPhong = '" + n + "'");
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
            else
            {
                // Xử lý lỗi nếu giá trị không hợp lệ.
                MessageBox.Show("Giá trị không hợp lệ");
            }
        }

        private void cbLoaiphongthue_SelectedIndexChanged(object sender, EventArgs e)
        {

            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            if (int.TryParse(cbLoaiphongthue.SelectedValue.ToString(), out int n))
            {
                sqlAdap2 = new SqlDataAdapter("select * from PHONG  where IDLOAIPHONG = '" + n + "' and TRANGTHAI = 0" , sqlCon);
                DT = new DataTable();
                sqlAdap2.Fill(DT);
            }
            cbtenphongthue.DataSource = DT;
            cbtenphongthue.DisplayMember = "TENPHONG";
            cbtenphongthue.ValueMember = "IDPHONG";
            sqlCon.Close();
        }

        private void btnAddkhachhang_Click(object sender, EventArgs e)
        {

            Form f = new frmAddKhachhang();
            f.ShowDialog();
            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            sqlAdap3 = new SqlDataAdapter("select * from KHACHHANG", sqlCon);
            Dt = new DataTable();
            sqlAdap3.Fill(Dt);
            cbKhachhang.DataSource = Dt;
            cbKhachhang.ValueMember = "IDKHACHHANG";
            cbKhachhang.DisplayMember = "HOTEN";
            sqlCon.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtThangthue.Text) || string.IsNullOrEmpty(cbKhachhang.Text) || string.IsNullOrEmpty(cbLoaiphongthue.Text) || string.IsNullOrEmpty(cbtenphongthue.Text))
            {
                btnXacnhan.Enabled = false;
            }
            else
            {
                btnXacnhan.Enabled=true;
            }
        }
    }

}
