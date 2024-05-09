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
    public partial class frmPhongdgthue : Form
    {
        clsDatabase cl = new clsDatabase();

        public frmPhongdgthue()
        {
            InitializeComponent();
        }

        private void frmPhongdgthue_Load(object sender, EventArgs e)
        {
            dgPhongdangthue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPhongdangthue.DataSource = cl.GetDataTable("select P.IDPHONG,P.TENPHONG,LP.TENLOAIPHONG,LP.DONGIA,case\r\n\twhen P.TRANGTHAI = 1 then N'Hoạt động'\r\n\telse N'Không hoạt động'\r\nend as TRANGTHAI from PHONG P inner join LOAIPHONG LP on P.IDLOAIPHONG = LP.IDLOAIPHONG where P.TRANGTHAI = 1");
            DoiTenCot();
        }

        void DoiTenCot()
        {
            dgPhongdangthue.Columns["IDPHONG"].HeaderText = "ID PHÒNG";
            dgPhongdangthue.Columns["TENPHONG"].HeaderText = "TÊN PHÒNG";
            dgPhongdangthue.Columns["TENLOAIPHONG"].HeaderText = "TÊN LOẠI PHÒNG";
            dgPhongdangthue.Columns["DONGIA"].HeaderText = "ĐƠN GIÁ";
            dgPhongdangthue.Columns["TRANGTHAI"].HeaderText = "TRẠNG THÁI";
        }
    }
}
