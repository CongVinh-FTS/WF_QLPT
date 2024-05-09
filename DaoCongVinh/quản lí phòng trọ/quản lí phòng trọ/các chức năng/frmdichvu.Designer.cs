namespace BÀI_TẬP_LỚN
{
    partial class frmdichvu
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
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnxoadv = new System.Windows.Forms.Button();
            this.txtxoaortimkiem = new System.Windows.Forms.TextBox();
            this.btnTimkiemdv = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.txtGiaDVthem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTendvThem = new System.Windows.Forms.TextBox();
            this.btnthemdv = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUpdateGiaDV = new System.Windows.Forms.TextBox();
            this.txtMadv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btncapnhatdv = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTendvUpdate = new System.Windows.Forms.TextBox();
            this.dgdichvu = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdichvu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên dịch vụ";
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgdichvu);
            this.splitContainer1.Size = new System.Drawing.Size(1071, 515);
            this.splitContainer1.SplitterDistance = 248;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1071, 248);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lí danh mục dịch vụ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnxoadv);
            this.groupBox3.Controls.Add(this.txtxoaortimkiem);
            this.groupBox3.Controls.Add(this.btnTimkiemdv);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(747, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 222);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm và xóa dịch vụ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nhập tên hoặc mã ";
            // 
            // btnxoadv
            // 
            this.btnxoadv.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnxoadv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnxoadv.Location = new System.Drawing.Point(194, 167);
            this.btnxoadv.Name = "btnxoadv";
            this.btnxoadv.Size = new System.Drawing.Size(88, 34);
            this.btnxoadv.TabIndex = 7;
            this.btnxoadv.Text = "Xóa";
            this.btnxoadv.UseVisualStyleBackColor = false;
            this.btnxoadv.Click += new System.EventHandler(this.btnxoadv_Click);
            // 
            // txtxoaortimkiem
            // 
            this.txtxoaortimkiem.Location = new System.Drawing.Point(160, 84);
            this.txtxoaortimkiem.Name = "txtxoaortimkiem";
            this.txtxoaortimkiem.Size = new System.Drawing.Size(135, 27);
            this.txtxoaortimkiem.TabIndex = 14;
            // 
            // btnTimkiemdv
            // 
            this.btnTimkiemdv.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnTimkiemdv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimkiemdv.Location = new System.Drawing.Point(49, 167);
            this.btnTimkiemdv.Name = "btnTimkiemdv";
            this.btnTimkiemdv.Size = new System.Drawing.Size(86, 34);
            this.btnTimkiemdv.TabIndex = 7;
            this.btnTimkiemdv.Text = "Tìm kiếm";
            this.btnTimkiemdv.UseVisualStyleBackColor = false;
            this.btnTimkiemdv.Click += new System.EventHandler(this.btnTimkiemdv_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.Controls.Add(this.btnLammoi);
            this.groupBox2.Controls.Add(this.txtGiaDVthem);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTendvThem);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnthemdv);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(3, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 222);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm dịch vụ";
            // 
            // btnLammoi
            // 
            this.btnLammoi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLammoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLammoi.Location = new System.Drawing.Point(187, 182);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(94, 34);
            this.btnLammoi.TabIndex = 0;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = false;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // txtGiaDVthem
            // 
            this.txtGiaDVthem.Location = new System.Drawing.Point(139, 89);
            this.txtGiaDVthem.Name = "txtGiaDVthem";
            this.txtGiaDVthem.Size = new System.Drawing.Size(156, 27);
            this.txtGiaDVthem.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Giá dịch vụ";
            // 
            // txtTendvThem
            // 
            this.txtTendvThem.AcceptsReturn = true;
            this.txtTendvThem.Location = new System.Drawing.Point(139, 50);
            this.txtTendvThem.Multiline = true;
            this.txtTendvThem.Name = "txtTendvThem";
            this.txtTendvThem.Size = new System.Drawing.Size(156, 27);
            this.txtTendvThem.TabIndex = 1;
            // 
            // btnthemdv
            // 
            this.btnthemdv.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnthemdv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnthemdv.Location = new System.Drawing.Point(63, 182);
            this.btnthemdv.Name = "btnthemdv";
            this.btnthemdv.Size = new System.Drawing.Size(92, 34);
            this.btnthemdv.TabIndex = 2;
            this.btnthemdv.Text = "Thêm";
            this.btnthemdv.UseVisualStyleBackColor = false;
            this.btnthemdv.Click += new System.EventHandler(this.btnthemdv_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtUpdateGiaDV);
            this.groupBox4.Controls.Add(this.txtMadv);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.btncapnhatdv);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtTendvUpdate);
            this.groupBox4.Location = new System.Drawing.Point(332, 23);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(398, 219);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cập nhật thông tin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Giá dịch vụ";
            // 
            // txtUpdateGiaDV
            // 
            this.txtUpdateGiaDV.Location = new System.Drawing.Point(176, 110);
            this.txtUpdateGiaDV.Name = "txtUpdateGiaDV";
            this.txtUpdateGiaDV.Size = new System.Drawing.Size(135, 27);
            this.txtUpdateGiaDV.TabIndex = 12;
            // 
            // txtMadv
            // 
            this.txtMadv.Location = new System.Drawing.Point(176, 32);
            this.txtMadv.Name = "txtMadv";
            this.txtMadv.Size = new System.Drawing.Size(72, 27);
            this.txtMadv.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID dịch vụ";
            // 
            // btncapnhatdv
            // 
            this.btncapnhatdv.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btncapnhatdv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncapnhatdv.Location = new System.Drawing.Point(151, 167);
            this.btncapnhatdv.Name = "btncapnhatdv";
            this.btncapnhatdv.Size = new System.Drawing.Size(88, 34);
            this.btncapnhatdv.TabIndex = 6;
            this.btncapnhatdv.Text = "Cập nhật";
            this.btncapnhatdv.UseVisualStyleBackColor = false;
            this.btncapnhatdv.Click += new System.EventHandler(this.btncapnhatdv_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên dịch vụ";
            // 
            // txtTendvUpdate
            // 
            this.txtTendvUpdate.Location = new System.Drawing.Point(176, 68);
            this.txtTendvUpdate.Name = "txtTendvUpdate";
            this.txtTendvUpdate.Size = new System.Drawing.Size(210, 27);
            this.txtTendvUpdate.TabIndex = 5;
            // 
            // dgdichvu
            // 
            this.dgdichvu.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgdichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdichvu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgdichvu.Location = new System.Drawing.Point(0, 0);
            this.dgdichvu.Name = "dgdichvu";
            this.dgdichvu.ReadOnly = true;
            this.dgdichvu.RowHeadersWidth = 51;
            this.dgdichvu.RowTemplate.Height = 24;
            this.dgdichvu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdichvu.Size = new System.Drawing.Size(1071, 263);
            this.dgdichvu.TabIndex = 0;
            this.dgdichvu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdichvu_CellClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmdichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1071, 515);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmdichvu";
            this.Text = "frmdichvu";
            this.Load += new System.EventHandler(this.frmdichvu_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdichvu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnthemdv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTendvThem;
        private System.Windows.Forms.TextBox txtTendvUpdate;
        private System.Windows.Forms.Button btnxoadv;
        private System.Windows.Forms.Button btncapnhatdv;
        private System.Windows.Forms.DataGridView dgdichvu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnTimkiemdv;
        private System.Windows.Forms.TextBox txtMadv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiaDVthem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtxoaortimkiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUpdateGiaDV;
    }
}