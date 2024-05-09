using BÀI_TẬP_LỚN.các_chức_năng;
using BÀI_TẬP_LỚN.các_from_đăng_nhập;
using BÀI_TẬP_LỚN.form_thống_kê;
using BÀI_TẬP_LỚN.formconvidu;
using DatabaseProgramming;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BÀI_TẬP_LỚN
{
    public partial class Frmmain : Form
    {

        string strCon = @"Data Source=VINH28\TESTDB;Initial Catalog=quanlyphongtro;Integrated Security=True";
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        SqlDataReader sqlRe;//Tự nghiên cứu
        SqlDataAdapter sqlAdap;
        DataSet ds;
        DataTable dt;
        clsDatabase cl = new clsDatabase();
        public Frmmain()
        {
            InitializeComponent();
        }

        private void Frmmain_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            Form f = new frmDangnhap();
            f.Hide();
            checkTPNULL();
            cl.ThucThi("DELETE FROM TINHTIENDV");
        }

        

        

        
        private void LoaiphongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmLoaiphong();
            f.MdiParent = this;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();

        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmPhong();
            f.MdiParent = this;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmdichvu();
            f.MdiParent = this;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void thuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmThuephong();
            f.MdiParent = this;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmDSKhachhang();
            f.MdiParent = this;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmDoimatkhau();
            f.MdiParent = this;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        

        private void phòngĐangThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmPhongdgthue();
            f.MdiParent = this;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void phòngTrốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmPhongtrong();
            f.MdiParent = this;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmDoanhthu();
            f.MdiParent = this;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmTraphong();
            f.MdiParent = this;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();

        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Application.Restart();

        }

        public void checkTPNULL()
        {
            SqlConnection conn = new SqlConnection(strCon);
            conn.Open();
            DataTable dem = new DataTable();
            sqlAdap = new SqlDataAdapter("SELECT TP.IDTHUE,LP.TENLOAIPHONG,P.TENPHONG,KH.HOTEN,KH.CCCD,KH.DIENTHOAI,KH.QUEQUAN,TP.NGAYTHUE,TP.THANGTHUE\r\nFROM THUEPHONG TP\r\nINNER JOIN PHONG P ON TP.IDPHONG = P.IDPHONG\r\nINNER JOIN LOAIPHONG LP ON P.IDLOAIPHONG = LP.IDLOAIPHONG\r\nINNER JOIN KHACHHANG KH ON TP.IDKHACHHANG = KH.IDKHACHHANG", conn);
            sqlAdap.Fill(dem);
            if (dem.Rows.Count < 1)
            {
                trảPhòngToolStripMenuItem.Enabled = false;
            }
            else
            {
                trảPhòngToolStripMenuItem.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            checkTPNULL();
            
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }

    

}
