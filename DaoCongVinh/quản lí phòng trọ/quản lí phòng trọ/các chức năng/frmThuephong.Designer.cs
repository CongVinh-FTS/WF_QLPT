namespace BÀI_TẬP_LỚN
{
    partial class frmThuephong
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThemmoi = new System.Windows.Forms.Button();
            this.btnMoi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoaphongthue = new System.Windows.Forms.Button();
            this.txtMaphong = new System.Windows.Forms.TextBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgThuephong = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgThuephong)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.dgThuephong);
            this.splitContainer1.Size = new System.Drawing.Size(1071, 515);
            this.splitContainer1.SplitterDistance = 181;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1071, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lí chức năng thuê phòng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnThemmoi);
            this.groupBox3.Controls.Add(this.btnMoi);
            this.groupBox3.Location = new System.Drawing.Point(511, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 131);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thêm hợp đồng thuê mới";
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnThemmoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemmoi.Location = new System.Drawing.Point(32, 77);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(104, 27);
            this.btnThemmoi.TabIndex = 3;
            this.btnThemmoi.Text = "Thêm mới";
            this.btnThemmoi.UseVisualStyleBackColor = false;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click);
            // 
            // btnMoi
            // 
            this.btnMoi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnMoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMoi.Location = new System.Drawing.Point(186, 77);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(104, 27);
            this.btnMoi.TabIndex = 4;
            this.btnMoi.Text = "Làm mới";
            this.btnMoi.UseVisualStyleBackColor = false;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoaphongthue);
            this.groupBox2.Controls.Add(this.txtMaphong);
            this.groupBox2.Controls.Add(this.btnTimkiem);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(36, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 133);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xóa, tìm kiếm phòng theo mã";
            // 
            // btnXoaphongthue
            // 
            this.btnXoaphongthue.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnXoaphongthue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoaphongthue.Location = new System.Drawing.Point(24, 88);
            this.btnXoaphongthue.Name = "btnXoaphongthue";
            this.btnXoaphongthue.Size = new System.Drawing.Size(104, 27);
            this.btnXoaphongthue.TabIndex = 5;
            this.btnXoaphongthue.Text = "Xóa";
            this.btnXoaphongthue.UseVisualStyleBackColor = false;
            this.btnXoaphongthue.Click += new System.EventHandler(this.btnXoaphongthue_Click);
            // 
            // txtMaphong
            // 
            this.txtMaphong.Location = new System.Drawing.Point(144, 31);
            this.txtMaphong.Name = "txtMaphong";
            this.txtMaphong.Size = new System.Drawing.Size(122, 27);
            this.txtMaphong.TabIndex = 6;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnTimkiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimkiem.Location = new System.Drawing.Point(162, 88);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(104, 27);
            this.btnTimkiem.TabIndex = 2;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã thuê phòng";
            // 
            // dgThuephong
            // 
            this.dgThuephong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgThuephong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgThuephong.Location = new System.Drawing.Point(0, 0);
            this.dgThuephong.Name = "dgThuephong";
            this.dgThuephong.RowHeadersWidth = 51;
            this.dgThuephong.RowTemplate.Height = 24;
            this.dgThuephong.Size = new System.Drawing.Size(1071, 330);
            this.dgThuephong.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmThuephong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1071, 515);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmThuephong";
            this.Text = "frmThuephong";
            this.Load += new System.EventHandler(this.frmThuephong_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgThuephong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThemmoi;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.DataGridView dgThuephong;
        private System.Windows.Forms.Button btnMoi;
        private System.Windows.Forms.Button btnXoaphongthue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaphong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Timer timer1;
    }
}