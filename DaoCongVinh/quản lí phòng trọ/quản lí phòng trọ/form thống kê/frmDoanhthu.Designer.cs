namespace BÀI_TẬP_LỚN.form_thống_kê
{
    partial class frmDoanhthu
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgthongke = new System.Windows.Forms.DataGridView();
            this.txttongdoanhthu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXoathanhtoan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgthongke)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(418, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "LỊCH SỬ THANH TOÁN\n";
            // 
            // dgthongke
            // 
            this.dgthongke.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgthongke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgthongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgthongke.Location = new System.Drawing.Point(168, 150);
            this.dgthongke.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgthongke.Name = "dgthongke";
            this.dgthongke.RowHeadersWidth = 51;
            this.dgthongke.RowTemplate.Height = 24;
            this.dgthongke.Size = new System.Drawing.Size(689, 145);
            this.dgthongke.TabIndex = 3;
            this.dgthongke.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgthongke_CellClick);
            this.dgthongke.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgthongke_CellContentClick);
            // 
            // txttongdoanhthu
            // 
            this.txttongdoanhthu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txttongdoanhthu.Location = new System.Drawing.Point(491, 333);
            this.txttongdoanhthu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttongdoanhthu.Name = "txttongdoanhthu";
            this.txttongdoanhthu.Size = new System.Drawing.Size(175, 20);
            this.txttongdoanhthu.TabIndex = 4;
            this.txttongdoanhthu.TextChanged += new System.EventHandler(this.txttongdoanhthu_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 336);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "tổng doanh thu";
            // 
            // btnXoathanhtoan
            // 
            this.btnXoathanhtoan.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnXoathanhtoan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoathanhtoan.Location = new System.Drawing.Point(472, 393);
            this.btnXoathanhtoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoathanhtoan.Name = "btnXoathanhtoan";
            this.btnXoathanhtoan.Size = new System.Drawing.Size(86, 34);
            this.btnXoathanhtoan.TabIndex = 6;
            this.btnXoathanhtoan.Text = "Xóa lịch sử";
            this.btnXoathanhtoan.UseVisualStyleBackColor = false;
            this.btnXoathanhtoan.Click += new System.EventHandler(this.btnXoathanhtoan_Click);
            // 
            // frmDoanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 533);
            this.Controls.Add(this.btnXoathanhtoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttongdoanhthu);
            this.Controls.Add(this.dgthongke);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDoanhthu";
            this.Text = "frmDoanhthu";
            this.Load += new System.EventHandler(this.frmDoanhthu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgthongke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgthongke;
        private System.Windows.Forms.TextBox txttongdoanhthu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXoathanhtoan;
    }
}