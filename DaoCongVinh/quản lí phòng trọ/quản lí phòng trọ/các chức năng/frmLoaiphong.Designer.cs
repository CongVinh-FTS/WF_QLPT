namespace BÀI_TẬP_LỚN
{
    partial class frmLoaiphong
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
            this.dgloaiphong = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnxoaloaiphong = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmaorten = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnthemloaiphong = new System.Windows.Forms.Button();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.txtloaiphong = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtDongia2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btncapnhatloaiphong = new System.Windows.Forms.Button();
            this.txtMaloaiphong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLoaiphong2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgloaiphong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgloaiphong
            // 
            this.dgloaiphong.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgloaiphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgloaiphong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgloaiphong.Location = new System.Drawing.Point(0, 0);
            this.dgloaiphong.MultiSelect = false;
            this.dgloaiphong.Name = "dgloaiphong";
            this.dgloaiphong.RowHeadersWidth = 51;
            this.dgloaiphong.RowTemplate.Height = 24;
            this.dgloaiphong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgloaiphong.Size = new System.Drawing.Size(988, 193);
            this.dgloaiphong.TabIndex = 0;
            this.dgloaiphong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgloaiphong_CellClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgloaiphong);
            this.splitContainer1.Size = new System.Drawing.Size(988, 450);
            this.splitContainer1.SplitterDistance = 253;
            this.splitContainer1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lí danh mục loại phòng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(988, 253);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(364, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "* Bảng giá tính theo giá tiền 1 tháng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnxoaloaiphong);
            this.groupBox2.Controls.Add(this.btntimkiem);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtmaorten);
            this.groupBox2.Location = new System.Drawing.Point(30, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 136);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xóa, tìm kiếm theo mã hoặc tên";
            // 
            // btnxoaloaiphong
            // 
            this.btnxoaloaiphong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnxoaloaiphong.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnxoaloaiphong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnxoaloaiphong.Location = new System.Drawing.Point(20, 92);
            this.btnxoaloaiphong.Name = "btnxoaloaiphong";
            this.btnxoaloaiphong.Size = new System.Drawing.Size(85, 28);
            this.btnxoaloaiphong.TabIndex = 4;
            this.btnxoaloaiphong.Text = "xóa";
            this.btnxoaloaiphong.UseVisualStyleBackColor = false;
            this.btnxoaloaiphong.Click += new System.EventHandler(this.btnxoaloaiphong_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btntimkiem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btntimkiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntimkiem.Location = new System.Drawing.Point(184, 92);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(85, 28);
            this.btntimkiem.TabIndex = 4;
            this.btntimkiem.Text = "tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nhập mã hoặc tên";
            // 
            // txtmaorten
            // 
            this.txtmaorten.Location = new System.Drawing.Point(168, 44);
            this.txtmaorten.Name = "txtmaorten";
            this.txtmaorten.Size = new System.Drawing.Size(111, 28);
            this.txtmaorten.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnthemloaiphong);
            this.groupBox3.Controls.Add(this.txtdongia);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnlammoi);
            this.groupBox3.Controls.Add(this.txtloaiphong);
            this.groupBox3.Location = new System.Drawing.Point(640, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 166);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thêm loại phòng";
            // 
            // btnthemloaiphong
            // 
            this.btnthemloaiphong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnthemloaiphong.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnthemloaiphong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnthemloaiphong.Location = new System.Drawing.Point(222, 127);
            this.btnthemloaiphong.Name = "btnthemloaiphong";
            this.btnthemloaiphong.Size = new System.Drawing.Size(75, 28);
            this.btnthemloaiphong.TabIndex = 3;
            this.btnthemloaiphong.Text = "thêm";
            this.btnthemloaiphong.UseVisualStyleBackColor = false;
            this.btnthemloaiphong.Click += new System.EventHandler(this.btnthemloaiphong_Click);
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(135, 77);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(162, 28);
            this.txtdongia.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đơn giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại phòng";
            // 
            // btnlammoi
            // 
            this.btnlammoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlammoi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnlammoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlammoi.Location = new System.Drawing.Point(31, 127);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(88, 29);
            this.btnlammoi.TabIndex = 3;
            this.btnlammoi.Text = "làm mới";
            this.btnlammoi.UseVisualStyleBackColor = false;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // txtloaiphong
            // 
            this.txtloaiphong.Location = new System.Drawing.Point(135, 32);
            this.txtloaiphong.Name = "txtloaiphong";
            this.txtloaiphong.Size = new System.Drawing.Size(162, 28);
            this.txtloaiphong.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox4.Controls.Add(this.txtDongia2);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btncapnhatloaiphong);
            this.groupBox4.Controls.Add(this.txtMaloaiphong);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtLoaiphong2);
            this.groupBox4.Location = new System.Drawing.Point(334, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(279, 203);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cập nhật loại phòng";
            // 
            // txtDongia2
            // 
            this.txtDongia2.Location = new System.Drawing.Point(125, 114);
            this.txtDongia2.Name = "txtDongia2";
            this.txtDongia2.Size = new System.Drawing.Size(123, 28);
            this.txtDongia2.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "mã loại phòng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Đơn giá";
            // 
            // btncapnhatloaiphong
            // 
            this.btncapnhatloaiphong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncapnhatloaiphong.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btncapnhatloaiphong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncapnhatloaiphong.Location = new System.Drawing.Point(90, 160);
            this.btncapnhatloaiphong.Name = "btncapnhatloaiphong";
            this.btncapnhatloaiphong.Size = new System.Drawing.Size(88, 28);
            this.btncapnhatloaiphong.TabIndex = 4;
            this.btncapnhatloaiphong.Text = "cập nhật";
            this.btncapnhatloaiphong.UseVisualStyleBackColor = false;
            this.btncapnhatloaiphong.Click += new System.EventHandler(this.btncapnhatloaiphong_Click);
            // 
            // txtMaloaiphong
            // 
            this.txtMaloaiphong.Location = new System.Drawing.Point(125, 30);
            this.txtMaloaiphong.Name = "txtMaloaiphong";
            this.txtMaloaiphong.Size = new System.Drawing.Size(85, 28);
            this.txtMaloaiphong.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Loại phòng";
            // 
            // txtLoaiphong2
            // 
            this.txtLoaiphong2.Location = new System.Drawing.Point(125, 74);
            this.txtLoaiphong2.Name = "txtLoaiphong2";
            this.txtLoaiphong2.Size = new System.Drawing.Size(123, 28);
            this.txtLoaiphong2.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmLoaiphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(988, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmLoaiphong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí loại phòng";
            this.Load += new System.EventHandler(this.frmLoaiphong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgloaiphong)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgloaiphong;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnthemloaiphong;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.TextBox txtloaiphong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnxoaloaiphong;
        private System.Windows.Forms.Button btncapnhatloaiphong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmaorten;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtDongia2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaloaiphong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLoaiphong2;
        private System.Windows.Forms.Timer timer1;
    }
}