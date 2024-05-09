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
    public partial class frmdichvu : Form
    {
        clsDatabase cl = new clsDatabase();
        public frmdichvu()
        {
            InitializeComponent();
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            

        }

        private void frmdichvu_Load(object sender, EventArgs e)
        {
            dgdichvu.DataSource = cl.GetDataTable("select * from DICHVU");
            dgdichvu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DoiTenCot();
        }

        private void btnthemdv_Click(object sender, EventArgs e)
        {
            cl.ThucThi("insert into DICHVU(TENDICHVU,GIATIENDV) values (N'" + txtTendvThem.Text.Trim() + "','" + txtGiaDVthem.Text.Trim() + "')");
            dgdichvu.DataSource = cl.GetDataTable("select * from DICHVU");
            MessageBox.Show("Thêm dịch vụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        void DoiTenCot()
        {
            dgdichvu.Columns["IDDICHVU"].HeaderText = "ID DỊCH VỤ";
            dgdichvu.Columns["TENDICHVU"].HeaderText = "TÊN DỊCH VỤ";
            dgdichvu.Columns["GIATIENDV"].HeaderText = "GIÁ DỊCH VỤ";
        }

        private void btnxoadv_Click(object sender, EventArgs e)
        {
            cl.ThucThi("delete from DICHVU where IDDICHVU = '" + txtMadv.Text.Trim() + "' and TENDICHVU = N'" + txtTendvUpdate.Text.Trim() + "'");
            dgdichvu.DataSource = cl.GetDataTable("select * from DICHVU");
            MessageBox.Show("Xóa dịch vụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTimkiemdv_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtxoaortimkiem.Text, out int n))
            {
                dgdichvu.DataSource = cl.GetDataTable("select * from DICHVU where IDDICHVU = '" + txtxoaortimkiem.Text.Trim() + "' ");
            }
            else
            {
                dgdichvu.DataSource = cl.GetDataTable("select * from DICHVU where TENDICHVU = N'" + txtxoaortimkiem.Text.Trim() + "' ");
            }
        }

        private void dgdichvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hangchon = e.RowIndex;
                txtTendvUpdate.Text = dgdichvu[1,hangchon].Value.ToString();
                txtMadv.Text = dgdichvu[0,hangchon].Value.ToString();
                txtUpdateGiaDV.Text = dgdichvu[2,hangchon].Value.ToString();
                txtxoaortimkiem.Text = dgdichvu[0, hangchon].Value.ToString();
            }
            catch
            {

            }
            
        }

        

        private void btncapnhatdv_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtMadv.Text,out int n) && int.TryParse(txtUpdateGiaDV.Text,out int h))
            {
                cl.ThucThi("update DICHVU set TENDICHVU = N'" + txtTendvUpdate.Text.Trim() + "', GIATIENDV = '" + h + "'  WHERE IDDICHVU = '" + n + "'");
                MessageBox.Show("Cập nhật dịch vụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Định dạng dữ liệu nhập vào không hợp lệ, vui lòng nhập lại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dgdichvu.DataSource = cl.GetDataTable("select * from DICHVU");
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            dgdichvu.DataSource = cl.GetDataTable("select * from DICHVU");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTendvThem.Text) || string.IsNullOrEmpty(txtGiaDVthem.Text))
            {
                btnthemdv.Enabled = false;
            }
            else
            {
                btnthemdv.Enabled = true;
            }

            if (string.IsNullOrEmpty(txtxoaortimkiem.Text))
            {
                btnxoadv.Enabled = false;
                btnTimkiemdv.Enabled = false;
            }
            else
            {
                btnxoadv.Enabled = true;
                btnTimkiemdv.Enabled = true;
            }

            if(string.IsNullOrEmpty(txtUpdateGiaDV.Text) || string.IsNullOrEmpty(txtTendvUpdate.Text) || string.IsNullOrEmpty(txtMadv.Text))
            {
                btncapnhatdv.Enabled = false;
            }
            else
            {
                btncapnhatdv.Enabled = true;
            }
        }
    }
}
