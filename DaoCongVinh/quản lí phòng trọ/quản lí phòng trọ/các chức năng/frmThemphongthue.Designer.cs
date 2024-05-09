namespace BÀI_TẬP_LỚN.formconvidu
{
    partial class frmThemphongthue
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
            this.cbtenphongthue = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXacnhan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtThangthue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgaythue = new System.Windows.Forms.DateTimePicker();
            this.cbLoaiphongthue = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddkhachhang = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbKhachhang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbtenphongthue
            // 
            this.cbtenphongthue.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtenphongthue.FormattingEnabled = true;
            this.cbtenphongthue.Location = new System.Drawing.Point(222, 70);
            this.cbtenphongthue.Name = "cbtenphongthue";
            this.cbtenphongthue.Size = new System.Drawing.Size(271, 25);
            this.cbtenphongthue.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên phòng";
            // 
            // btnXacnhan
            // 
            this.btnXacnhan.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnXacnhan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXacnhan.Location = new System.Drawing.Point(188, 238);
            this.btnXacnhan.Name = "btnXacnhan";
            this.btnXacnhan.Size = new System.Drawing.Size(93, 33);
            this.btnXacnhan.TabIndex = 3;
            this.btnXacnhan.Text = "Xác nhận";
            this.btnXacnhan.UseVisualStyleBackColor = false;
            this.btnXacnhan.Click += new System.EventHandler(this.btnXacnhan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Location = new System.Drawing.Point(353, 238);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(96, 33);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtThangthue);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpNgaythue);
            this.groupBox1.Controls.Add(this.cbLoaiphongthue);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnAddkhachhang);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbKhachhang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnXacnhan);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.cbtenphongthue);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 301);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm phòng thuê";
            // 
            // txtThangthue
            // 
            this.txtThangthue.Location = new System.Drawing.Point(493, 170);
            this.txtThangthue.Name = "txtThangthue";
            this.txtThangthue.Size = new System.Drawing.Size(37, 25);
            this.txtThangthue.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(410, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tháng thuê:";
            // 
            // dtpNgaythue
            // 
            this.dtpNgaythue.Location = new System.Drawing.Point(222, 152);
            this.dtpNgaythue.Name = "dtpNgaythue";
            this.dtpNgaythue.Size = new System.Drawing.Size(182, 25);
            this.dtpNgaythue.TabIndex = 16;
            // 
            // cbLoaiphongthue
            // 
            this.cbLoaiphongthue.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiphongthue.FormattingEnabled = true;
            this.cbLoaiphongthue.Location = new System.Drawing.Point(222, 28);
            this.cbLoaiphongthue.Name = "cbLoaiphongthue";
            this.cbLoaiphongthue.Size = new System.Drawing.Size(271, 25);
            this.cbLoaiphongthue.TabIndex = 13;
            this.cbLoaiphongthue.SelectedIndexChanged += new System.EventHandler(this.cbLoaiphongthue_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(119, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Loại phòng";
            // 
            // btnAddkhachhang
            // 
            this.btnAddkhachhang.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddkhachhang.Location = new System.Drawing.Point(455, 114);
            this.btnAddkhachhang.Name = "btnAddkhachhang";
            this.btnAddkhachhang.Size = new System.Drawing.Size(38, 24);
            this.btnAddkhachhang.TabIndex = 10;
            this.btnAddkhachhang.Text = "+";
            this.btnAddkhachhang.UseVisualStyleBackColor = true;
            this.btnAddkhachhang.Click += new System.EventHandler(this.btnAddkhachhang_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày thuê";
            // 
            // cbKhachhang
            // 
            this.cbKhachhang.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhachhang.FormattingEnabled = true;
            this.cbKhachhang.Location = new System.Drawing.Point(222, 113);
            this.cbKhachhang.Name = "cbKhachhang";
            this.cbKhachhang.Size = new System.Drawing.Size(227, 25);
            this.cbKhachhang.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Khách hàng";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmThemphongthue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(646, 301);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmThemphongthue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThemphongthue";
            this.Load += new System.EventHandler(this.frmThemphongthue_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbtenphongthue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXacnhan;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbKhachhang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddkhachhang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLoaiphongthue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgaythue;
        private System.Windows.Forms.TextBox txtThangthue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}