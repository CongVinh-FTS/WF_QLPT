namespace BÀI_TẬP_LỚN.các_chức_năng
{
    partial class frmTraphong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnInhoadon = new System.Windows.Forms.Button();
            this.cbTenphong = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDthue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.dgHtdichvu = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDV = new System.Windows.Forms.ComboBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtThangthue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKhachhang = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNgaythue = new System.Windows.Forms.TextBox();
            this.btnXoadv = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTienphong = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTongtiendv = new System.Windows.Forms.TextBox();
            this.btnTongtien = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgHtdichvu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInhoadon
            // 
            this.btnInhoadon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnInhoadon.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnInhoadon.Location = new System.Drawing.Point(636, 535);
            this.btnInhoadon.Name = "btnInhoadon";
            this.btnInhoadon.Size = new System.Drawing.Size(117, 43);
            this.btnInhoadon.TabIndex = 0;
            this.btnInhoadon.Text = "In hóa đơn";
            this.btnInhoadon.UseVisualStyleBackColor = false;
            this.btnInhoadon.Click += new System.EventHandler(this.btnInhoadon_Click);
            // 
            // cbTenphong
            // 
            this.cbTenphong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbTenphong.FormattingEnabled = true;
            this.cbTenphong.Location = new System.Drawing.Point(243, 108);
            this.cbTenphong.Name = "cbTenphong";
            this.cbTenphong.Size = new System.Drawing.Size(113, 24);
            this.cbTenphong.TabIndex = 1;
            this.cbTenphong.SelectedIndexChanged += new System.EventHandler(this.cbTenphong_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên phòng";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(555, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "hóa đơn thanh toán";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtIDthue
            // 
            this.txtIDthue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIDthue.Location = new System.Drawing.Point(526, 147);
            this.txtIDthue.Name = "txtIDthue";
            this.txtIDthue.ReadOnly = true;
            this.txtIDthue.Size = new System.Drawing.Size(49, 22);
            this.txtIDthue.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID Thuê";
            // 
            // txtTongtien
            // 
            this.txtTongtien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTongtien.Location = new System.Drawing.Point(1065, 399);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.ReadOnly = true;
            this.txtTongtien.Size = new System.Drawing.Size(100, 22);
            this.txtTongtien.TabIndex = 6;
            
            // 
            // dgHtdichvu
            // 
            this.dgHtdichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHtdichvu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgHtdichvu.Location = new System.Drawing.Point(3, 18);
            this.dgHtdichvu.Name = "dgHtdichvu";
            this.dgHtdichvu.RowHeadersWidth = 51;
            this.dgHtdichvu.RowTemplate.Height = 24;
            this.dgHtdichvu.Size = new System.Drawing.Size(631, 195);
            this.dgHtdichvu.TabIndex = 7;
            this.dgHtdichvu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHtdichvu_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.dgHtdichvu);
            this.groupBox1.Location = new System.Drawing.Point(142, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 216);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách dịch vụ ";
            // 
            // cbDV
            // 
            this.cbDV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbDV.FormattingEnabled = true;
            this.cbDV.Location = new System.Drawing.Point(1029, 111);
            this.cbDV.Name = "cbDV";
            this.cbDV.Size = new System.Drawing.Size(121, 24);
            this.cbDV.TabIndex = 9;
            this.cbDV.SelectedIndexChanged += new System.EventHandler(this.cbDV_SelectedIndexChanged);
            // 
            // txtSoluong
            // 
            this.txtSoluong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSoluong.Location = new System.Drawing.Point(1029, 150);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(100, 22);
            this.txtSoluong.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(941, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tên dịch vụ";
            // 
            // btnThemDV
            // 
            this.btnThemDV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemDV.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnThemDV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemDV.Location = new System.Drawing.Point(1047, 202);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(91, 32);
            this.btnThemDV.TabIndex = 12;
            this.btnThemDV.Text = "thêm dịch vụ";
            this.btnThemDV.UseVisualStyleBackColor = false;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(941, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(947, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tổng tiền";
            // 
            // txtThangthue
            // 
            this.txtThangthue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtThangthue.Location = new System.Drawing.Point(243, 215);
            this.txtThangthue.Name = "txtThangthue";
            this.txtThangthue.ReadOnly = true;
            this.txtThangthue.Size = new System.Drawing.Size(67, 22);
            this.txtThangthue.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(139, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Số tháng thuê";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(139, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Khách hàng";
            // 
            // txtKhachhang
            // 
            this.txtKhachhang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtKhachhang.Location = new System.Drawing.Point(243, 147);
            this.txtKhachhang.Name = "txtKhachhang";
            this.txtKhachhang.ReadOnly = true;
            this.txtKhachhang.Size = new System.Drawing.Size(194, 22);
            this.txtKhachhang.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(375, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Số điện thoại";
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSDT.Location = new System.Drawing.Point(477, 111);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(98, 22);
            this.txtSDT.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(139, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Thuê từ ngày";
            // 
            // txtNgaythue
            // 
            this.txtNgaythue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNgaythue.Location = new System.Drawing.Point(243, 178);
            this.txtNgaythue.Name = "txtNgaythue";
            this.txtNgaythue.ReadOnly = true;
            this.txtNgaythue.Size = new System.Drawing.Size(332, 22);
            this.txtNgaythue.TabIndex = 21;
            // 
            // btnXoadv
            // 
            this.btnXoadv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoadv.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnXoadv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoadv.Location = new System.Drawing.Point(944, 202);
            this.btnXoadv.Name = "btnXoadv";
            this.btnXoadv.Size = new System.Drawing.Size(91, 32);
            this.btnXoadv.TabIndex = 23;
            this.btnXoadv.Text = "Xóa dịch vụ";
            this.btnXoadv.UseVisualStyleBackColor = false;
            this.btnXoadv.Click += new System.EventHandler(this.btnXoadv_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(947, 321);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "tiền phòng";
            // 
            // txtTienphong
            // 
            this.txtTienphong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTienphong.Location = new System.Drawing.Point(1065, 318);
            this.txtTienphong.Name = "txtTienphong";
            this.txtTienphong.ReadOnly = true;
            this.txtTienphong.Size = new System.Drawing.Size(100, 22);
            this.txtTienphong.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(945, 360);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "Tổng tiền dịch vụ";
            // 
            // txtTongtiendv
            // 
            this.txtTongtiendv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTongtiendv.Location = new System.Drawing.Point(1065, 357);
            this.txtTongtiendv.Name = "txtTongtiendv";
            this.txtTongtiendv.ReadOnly = true;
            this.txtTongtiendv.Size = new System.Drawing.Size(100, 22);
            this.txtTongtiendv.TabIndex = 26;
            // 
            // btnTongtien
            // 
            this.btnTongtien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTongtien.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnTongtien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTongtien.Location = new System.Drawing.Point(1015, 437);
            this.btnTongtien.Name = "btnTongtien";
            this.btnTongtien.Size = new System.Drawing.Size(91, 32);
            this.btnTongtien.TabIndex = 28;
            this.btnTongtien.Text = "tính tổng tiền";
            this.btnTongtien.UseVisualStyleBackColor = false;
            this.btnTongtien.Click += new System.EventHandler(this.btnTongtien_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmTraphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1333, 656);
            this.Controls.Add(this.btnTongtien);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTongtiendv);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTienphong);
            this.Controls.Add(this.btnXoadv);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNgaythue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtKhachhang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtThangthue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnThemDV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.cbDV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTongtien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIDthue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTenphong);
            this.Controls.Add(this.btnInhoadon);
            this.Name = "frmTraphong";
            this.Text = "frmTienDV";
            this.Load += new System.EventHandler(this.frmTraphong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgHtdichvu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInhoadon;
        private System.Windows.Forms.ComboBox cbTenphong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDthue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.DataGridView dgHtdichvu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbDV;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtThangthue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKhachhang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNgaythue;
        private System.Windows.Forms.Button btnXoadv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTienphong;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTongtiendv;
        private System.Windows.Forms.Button btnTongtien;
        private System.Windows.Forms.Timer timer1;
    }
}