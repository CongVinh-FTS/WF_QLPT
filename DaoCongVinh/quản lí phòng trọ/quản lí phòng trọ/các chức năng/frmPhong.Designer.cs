namespace BÀI_TẬP_LỚN
{
    partial class frmPhong
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgLoaiphongHT = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btntimkiemphong = new System.Windows.Forms.Button();
            this.btnthemphong = new System.Windows.Forms.Button();
            this.ckbtrangthai = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenphong = new System.Windows.Forms.TextBox();
            this.cbloaiphong = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ckbtrangthai2 = new System.Windows.Forms.CheckBox();
            this.btnupdatetrangthai = new System.Windows.Forms.Button();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.btnxoaphong = new System.Windows.Forms.Button();
            this.txtmaphong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgPhong = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLoaiphongHT)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPhong)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.dgPhong);
            this.splitContainer1.Size = new System.Drawing.Size(1071, 515);
            this.splitContainer1.SplitterDistance = 292;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgLoaiphongHT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1071, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dgLoaiphongHT
            // 
            this.dgLoaiphongHT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgLoaiphongHT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLoaiphongHT.Location = new System.Drawing.Point(564, 21);
            this.dgLoaiphongHT.Name = "dgLoaiphongHT";
            this.dgLoaiphongHT.RowHeadersWidth = 51;
            this.dgLoaiphongHT.RowTemplate.Height = 24;
            this.dgLoaiphongHT.Size = new System.Drawing.Size(501, 250);
            this.dgLoaiphongHT.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÍ DANH MỤC PHÒNG";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btntimkiemphong);
            this.groupBox2.Controls.Add(this.btnthemphong);
            this.groupBox2.Controls.Add(this.ckbtrangthai);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTenphong);
            this.groupBox2.Controls.Add(this.cbloaiphong);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 271);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // btntimkiemphong
            // 
            this.btntimkiemphong.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btntimkiemphong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntimkiemphong.Location = new System.Drawing.Point(209, 191);
            this.btntimkiemphong.Name = "btntimkiemphong";
            this.btntimkiemphong.Size = new System.Drawing.Size(84, 32);
            this.btntimkiemphong.TabIndex = 4;
            this.btntimkiemphong.Text = "Tìm kiếm";
            this.btntimkiemphong.UseVisualStyleBackColor = false;
            this.btntimkiemphong.Click += new System.EventHandler(this.btntimkiemphong_Click);
            // 
            // btnthemphong
            // 
            this.btnthemphong.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnthemphong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnthemphong.Location = new System.Drawing.Point(59, 191);
            this.btnthemphong.Name = "btnthemphong";
            this.btnthemphong.Size = new System.Drawing.Size(84, 32);
            this.btnthemphong.TabIndex = 3;
            this.btnthemphong.Text = "thêm";
            this.btnthemphong.UseVisualStyleBackColor = false;
            this.btnthemphong.Click += new System.EventHandler(this.btnthemphong_Click);
            // 
            // ckbtrangthai
            // 
            this.ckbtrangthai.AutoSize = true;
            this.ckbtrangthai.Location = new System.Drawing.Point(43, 154);
            this.ckbtrangthai.Name = "ckbtrangthai";
            this.ckbtrangthai.Size = new System.Drawing.Size(107, 20);
            this.ckbtrangthai.TabIndex = 5;
            this.ckbtrangthai.Text = "Đã được thuê";
            this.ckbtrangthai.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Thêm và tìm kiếm phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Loại phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tên phòng";
            // 
            // txtTenphong
            // 
            this.txtTenphong.Location = new System.Drawing.Point(148, 113);
            this.txtTenphong.Name = "txtTenphong";
            this.txtTenphong.Size = new System.Drawing.Size(191, 22);
            this.txtTenphong.TabIndex = 7;
            // 
            // cbloaiphong
            // 
            this.cbloaiphong.FormattingEnabled = true;
            this.cbloaiphong.Location = new System.Drawing.Point(148, 75);
            this.cbloaiphong.Name = "cbloaiphong";
            this.cbloaiphong.Size = new System.Drawing.Size(191, 24);
            this.cbloaiphong.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.ckbtrangthai2);
            this.groupBox3.Controls.Add(this.btnupdatetrangthai);
            this.groupBox3.Controls.Add(this.btnlammoi);
            this.groupBox3.Controls.Add(this.btnxoaphong);
            this.groupBox3.Controls.Add(this.txtmaphong);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(357, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 268);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xóa phòng theo mã";
            // 
            // ckbtrangthai2
            // 
            this.ckbtrangthai2.AutoSize = true;
            this.ckbtrangthai2.Location = new System.Drawing.Point(18, 99);
            this.ckbtrangthai2.Name = "ckbtrangthai2";
            this.ckbtrangthai2.Size = new System.Drawing.Size(107, 20);
            this.ckbtrangthai2.TabIndex = 10;
            this.ckbtrangthai2.Text = "Đã được thuê";
            this.ckbtrangthai2.UseVisualStyleBackColor = true;
            // 
            // btnupdatetrangthai
            // 
            this.btnupdatetrangthai.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnupdatetrangthai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdatetrangthai.Location = new System.Drawing.Point(48, 198);
            this.btnupdatetrangthai.Name = "btnupdatetrangthai";
            this.btnupdatetrangthai.Size = new System.Drawing.Size(110, 42);
            this.btnupdatetrangthai.TabIndex = 10;
            this.btnupdatetrangthai.Text = "Cập nhật trạng thái phòng";
            this.btnupdatetrangthai.UseVisualStyleBackColor = false;
            this.btnupdatetrangthai.Click += new System.EventHandler(this.btnupdatetrangthai_Click);
            // 
            // btnlammoi
            // 
            this.btnlammoi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnlammoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlammoi.Location = new System.Drawing.Point(119, 150);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(75, 29);
            this.btnlammoi.TabIndex = 11;
            this.btnlammoi.Text = "làm mới danh sách";
            this.btnlammoi.UseVisualStyleBackColor = false;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // btnxoaphong
            // 
            this.btnxoaphong.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnxoaphong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnxoaphong.Location = new System.Drawing.Point(13, 150);
            this.btnxoaphong.Name = "btnxoaphong";
            this.btnxoaphong.Size = new System.Drawing.Size(75, 29);
            this.btnxoaphong.TabIndex = 12;
            this.btnxoaphong.Text = "Xóa";
            this.btnxoaphong.UseVisualStyleBackColor = false;
            this.btnxoaphong.Click += new System.EventHandler(this.btnxoaphong_Click);
            // 
            // txtmaphong
            // 
            this.txtmaphong.Location = new System.Drawing.Point(94, 57);
            this.txtmaphong.Name = "txtmaphong";
            this.txtmaphong.Size = new System.Drawing.Size(100, 22);
            this.txtmaphong.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mã phòng :";
            // 
            // dgPhong
            // 
            this.dgPhong.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPhong.Location = new System.Drawing.Point(0, 0);
            this.dgPhong.Name = "dgPhong";
            this.dgPhong.ReadOnly = true;
            this.dgPhong.RowHeadersWidth = 51;
            this.dgPhong.RowTemplate.Height = 24;
            this.dgPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPhong.Size = new System.Drawing.Size(1071, 219);
            this.dgPhong.TabIndex = 0;
            this.dgPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPhong_CellClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1071, 515);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmPhong";
            this.Text = "frmPhong";
            this.Load += new System.EventHandler(this.frmPhong_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLoaiphongHT)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgPhong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbtrangthai;
        private System.Windows.Forms.Button btnthemphong;
        private System.Windows.Forms.ComboBox cbloaiphong;
        private System.Windows.Forms.TextBox txtTenphong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btntimkiemphong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgLoaiphongHT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Button btnxoaphong;
        private System.Windows.Forms.TextBox txtmaphong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnupdatetrangthai;
        private System.Windows.Forms.CheckBox ckbtrangthai2;
    }
}