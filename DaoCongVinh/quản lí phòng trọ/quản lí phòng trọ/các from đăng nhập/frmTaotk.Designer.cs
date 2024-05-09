namespace BÀI_TẬP_LỚN.các_from_đăng_nhập
{
    partial class frmTaotk
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
            this.txtPasschange = new System.Windows.Forms.TextBox();
            this.txtUserchange = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXacnhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPasschange
            // 
            this.txtPasschange.Location = new System.Drawing.Point(227, 114);
            this.txtPasschange.Name = "txtPasschange";
            this.txtPasschange.PasswordChar = '*';
            this.txtPasschange.Size = new System.Drawing.Size(205, 22);
            this.txtPasschange.TabIndex = 10;
            // 
            // txtUserchange
            // 
            this.txtUserchange.Location = new System.Drawing.Point(227, 59);
            this.txtUserchange.Name = "txtUserchange";
            this.txtUserchange.Size = new System.Drawing.Size(205, 22);
            this.txtUserchange.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tài khoản mới";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(278, 194);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(105, 34);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "hủy";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXacnhan
            // 
            this.btnXacnhan.Location = new System.Drawing.Point(117, 194);
            this.btnXacnhan.Name = "btnXacnhan";
            this.btnXacnhan.Size = new System.Drawing.Size(90, 34);
            this.btnXacnhan.TabIndex = 11;
            this.btnXacnhan.Text = "Xác nhận";
            this.btnXacnhan.UseVisualStyleBackColor = true;
            this.btnXacnhan.Click += new System.EventHandler(this.btnXacnhan_Click);
            // 
            // frmTaotk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(516, 294);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXacnhan);
            this.Controls.Add(this.txtPasschange);
            this.Controls.Add(this.txtUserchange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTaotk";
            this.Text = "Tạo tài khoản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPasschange;
        private System.Windows.Forms.TextBox txtUserchange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXacnhan;
    }
}