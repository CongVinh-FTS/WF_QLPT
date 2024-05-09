using BÀI_TẬP_LỚN.formconvidu;
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

namespace BÀI_TẬP_LỚN
{
    public partial class frmThuephong : Form
    {
        clsDatabase cl = new clsDatabase();
        public frmThuephong()
        {
            InitializeComponent();
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            Form f = new frmThemphongthue();
            f.ShowDialog();
        }

        private void frmThuephong_Load(object sender, EventArgs e)
        {
            dgThuephong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgThuephong.DataSource = cl.GetDataTable("SELECT TP.IDTHUE,LP.TENLOAIPHONG,P.TENPHONG,KH.HOTEN,KH.CCCD,KH.DIENTHOAI,KH.QUEQUAN,TP.NGAYTHUE,TP.THANGTHUE\r\nFROM THUEPHONG TP\r\nINNER JOIN PHONG P ON TP.IDPHONG = P.IDPHONG\r\nINNER JOIN LOAIPHONG LP ON P.IDLOAIPHONG = LP.IDLOAIPHONG\r\nINNER JOIN KHACHHANG KH ON TP.IDKHACHHANG = KH.IDKHACHHANG");
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            dgThuephong.DataSource = cl.GetDataTable("SELECT TP.IDTHUE,LP.TENLOAIPHONG,P.TENPHONG,KH.HOTEN,KH.CCCD,KH.DIENTHOAI,KH.QUEQUAN,TP.NGAYTHUE,TP.THANGTHUE\r\nFROM THUEPHONG TP\r\nINNER JOIN PHONG P ON TP.IDPHONG = P.IDPHONG\r\nINNER JOIN LOAIPHONG LP ON P.IDLOAIPHONG = LP.IDLOAIPHONG\r\nINNER JOIN KHACHHANG KH ON TP.IDKHACHHANG = KH.IDKHACHHANG");
        }

        private void btnXoaphongthue_Click(object sender, EventArgs e)
        {
            cl.ThucThi("UPDATE PHONG\r\nSET TRANGTHAI = 0\r\nFROM PHONG P\r\nINNER JOIN THUEPHONG TP ON P.IDPHONG = TP.IDPHONG\r\nWHERE TP.IDTHUE = '" + txtMaphong.Text.Trim() + "'");
            cl.ThucThi("delete from THUEPHONG where IDTHUE = '" + txtMaphong.Text.Trim() + "'");           
            MessageBox.Show("Xóa phòng đang thuê thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnMoi_Click(sender, e);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            dgThuephong.DataSource = cl.GetDataTable("SELECT TP.IDTHUE,LP.TENLOAIPHONG,P.TENPHONG,KH.HOTEN,KH.CCCD,KH.DIENTHOAI,KH.QUEQUAN,TP.NGAYTHUE,TP.THANGTHUE\r\nFROM THUEPHONG TP\r\nINNER JOIN PHONG P ON TP.IDPHONG = P.IDPHONG\r\nINNER JOIN LOAIPHONG LP ON P.IDLOAIPHONG = LP.IDLOAIPHONG\r\nINNER JOIN KHACHHANG KH ON TP.IDKHACHHANG = KH.IDKHACHHANG where IDTHUE = '" + txtMaphong.Text.Trim() + "'");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaphong.Text.Trim()))
            {
                btnXoaphongthue.Enabled = false;
                btnTimkiem.Enabled = false;
            }
            else
            {
                btnXoaphongthue.Enabled = true;
                btnTimkiem.Enabled = true;
            }
        }
    }
}
