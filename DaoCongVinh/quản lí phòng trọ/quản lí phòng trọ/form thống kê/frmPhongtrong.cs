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

namespace BÀI_TẬP_LỚN.form_thống_kê
{
    public partial class frmPhongtrong : Form
    {
        clsDatabase cl = new clsDatabase();
        public frmPhongtrong()
        {
            InitializeComponent();
        }

        private void frmPhongtrong_Load(object sender, EventArgs e)
        {
            dgPhongtrong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPhongtrong.DataSource = cl.GetDataTable("select P.IDPHONG,P.TENPHONG,LP.TENLOAIPHONG,LP.DONGIA,case\r\n\twhen P.TRANGTHAI = 1 then N'Hoạt động'\r\n\telse N'Không hoạt động'\r\nend as TRANGTHAI from PHONG P inner join LOAIPHONG LP on P.IDLOAIPHONG = LP.IDLOAIPHONG where P.TRANGTHAI = 0");
            DoiTenCot();
        }

        void DoiTenCot()
        {
            dgPhongtrong.Columns["IDPHONG"].HeaderText = "ID PHÒNG";
            dgPhongtrong.Columns["TENPHONG"].HeaderText = "TÊN PHÒNG";
            dgPhongtrong.Columns["TENLOAIPHONG"].HeaderText = "TÊN LOẠI PHÒNG";
            dgPhongtrong.Columns["DONGIA"].HeaderText = "ĐƠN GIÁ";
            dgPhongtrong.Columns["TRANGTHAI"].HeaderText = "TRẠNG THÁI";
        }
    }
}
