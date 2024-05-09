namespace BÀI_TẬP_LỚN
{
    partial class frmDSKhachhang
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
            this.dgDsKhach = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnXoakhach = new System.Windows.Forms.Button();
            this.txtXoaORTimkiemkhach = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnAddkhach = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgDsKhach)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgDsKhach
            // 
            this.dgDsKhach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDsKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDsKhach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDsKhach.GridColor = System.Drawing.SystemColors.Control;
            this.dgDsKhach.Location = new System.Drawing.Point(3, 18);
            this.dgDsKhach.Name = "dgDsKhach";
            this.dgDsKhach.ReadOnly = true;
            this.dgDsKhach.RowHeadersWidth = 51;
            this.dgDsKhach.RowTemplate.Height = 24;
            this.dgDsKhach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDsKhach.Size = new System.Drawing.Size(794, 261);
            this.dgDsKhach.TabIndex = 0;
            this.dgDsKhach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDsKhach_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgDsKhach);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 282);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khách hàng đã từng hoặc đang thuê phòng";
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 164;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnTimkiem);
            this.groupBox2.Controls.Add(this.btnXoakhach);
            this.groupBox2.Controls.Add(this.txtXoaORTimkiemkhach);
            this.groupBox2.Location = new System.Drawing.Point(55, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 149);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xóa hoặc tìm kiếm khách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nhập mã hoặc tên khách";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnTimkiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimkiem.Location = new System.Drawing.Point(269, 98);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(86, 27);
            this.btnTimkiem.TabIndex = 6;
            this.btnTimkiem.Text = "Tim kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnXoakhach
            // 
            this.btnXoakhach.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnXoakhach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoakhach.Location = new System.Drawing.Point(44, 98);
            this.btnXoakhach.Name = "btnXoakhach";
            this.btnXoakhach.Size = new System.Drawing.Size(86, 27);
            this.btnXoakhach.TabIndex = 0;
            this.btnXoakhach.Text = "Xóa";
            this.btnXoakhach.UseVisualStyleBackColor = false;
            this.btnXoakhach.Click += new System.EventHandler(this.btnXoakhach_Click);
            // 
            // txtXoaORTimkiemkhach
            // 
            this.txtXoaORTimkiemkhach.Location = new System.Drawing.Point(195, 49);
            this.txtXoaORTimkiemkhach.Name = "txtXoaORTimkiemkhach";
            this.txtXoaORTimkiemkhach.Size = new System.Drawing.Size(190, 22);
            this.txtXoaORTimkiemkhach.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnLammoi);
            this.groupBox3.Controls.Add(this.btnAddkhach);
            this.groupBox3.Location = new System.Drawing.Point(513, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 140);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thêm khách hàng";
            // 
            // btnLammoi
            // 
            this.btnLammoi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLammoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLammoi.Location = new System.Drawing.Point(6, 86);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(86, 27);
            this.btnLammoi.TabIndex = 7;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = false;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnAddkhach
            // 
            this.btnAddkhach.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAddkhach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddkhach.Location = new System.Drawing.Point(134, 86);
            this.btnAddkhach.Name = "btnAddkhach";
            this.btnAddkhach.Size = new System.Drawing.Size(86, 27);
            this.btnAddkhach.TabIndex = 4;
            this.btnAddkhach.Text = "Thêm";
            this.btnAddkhach.UseVisualStyleBackColor = false;
            this.btnAddkhach.Click += new System.EventHandler(this.btnAddkhach_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmDSKhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmDSKhachhang";
            this.Text = "frmDSKhachhang";
            this.Load += new System.EventHandler(this.frmDSKhachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDsKhach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDsKhach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtXoaORTimkiemkhach;
        private System.Windows.Forms.Button btnXoakhach;
        private System.Windows.Forms.Button btnAddkhach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Timer timer1;
    }
}