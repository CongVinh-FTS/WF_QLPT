using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BÀI_TẬP_LỚN.formconvidu
{
    public partial class formxinchao : Form
    {
        public formxinchao()
        {
            InitializeComponent();
        }

        private void formxinchao_Load(object sender, EventArgs e)
        {
            
            
            
        }

        

        private void formxinchao_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            var f = new frmDangnhap();
            this.Hide();
            
            f.ShowDialog();
        }
    }
}
