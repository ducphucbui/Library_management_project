namespace DoAn_QuanLyThuVien
{
    partial class DangNhap
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
            this.textBoxTenTK = new System.Windows.Forms.TextBox();
            this.textBoxMatKhau = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabelDangKy = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxTenTK
            // 
            this.textBoxTenTK.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxTenTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxTenTK.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxTenTK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxTenTK.Location = new System.Drawing.Point(541, 168);
            this.textBoxTenTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTenTK.Name = "textBoxTenTK";
            this.textBoxTenTK.ShortcutsEnabled = false;
            this.textBoxTenTK.Size = new System.Drawing.Size(462, 52);
            this.textBoxTenTK.TabIndex = 1;
            this.textBoxTenTK.Text = "Tài khoản";
            this.textBoxTenTK.Click += new System.EventHandler(this.textBoxTenTK_Click);
            // 
            // textBoxMatKhau
            // 
            this.textBoxMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxMatKhau.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxMatKhau.Location = new System.Drawing.Point(541, 284);
            this.textBoxMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMatKhau.Name = "textBoxMatKhau";
            this.textBoxMatKhau.Size = new System.Drawing.Size(407, 52);
            this.textBoxMatKhau.TabIndex = 2;
            this.textBoxMatKhau.Tag = "";
            this.textBoxMatKhau.Text = "Mật khẩu";
            this.textBoxMatKhau.WordWrap = false;
            this.textBoxMatKhau.Click += new System.EventHandler(this.textBoxMatKhau_Click);
            this.textBoxMatKhau.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxMatKhau_MouseClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(541, 399);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(462, 64);
            this.button1.TabIndex = 3;
            this.button1.Text = "Đăng nhập";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(600, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chưa có tài khoản?";
            // 
            // linkLabelDangKy
            // 
            this.linkLabelDangKy.AutoSize = true;
            this.linkLabelDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.linkLabelDangKy.LinkColor = System.Drawing.Color.Aqua;
            this.linkLabelDangKy.Location = new System.Drawing.Point(821, 505);
            this.linkLabelDangKy.Name = "linkLabelDangKy";
            this.linkLabelDangKy.Size = new System.Drawing.Size(91, 25);
            this.linkLabelDangKy.TabIndex = 5;
            this.linkLabelDangKy.TabStop = true;
            this.linkLabelDangKy.Text = "Đăng ký";
            this.linkLabelDangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDangKy_LinkClicked);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Image = global::DoAn_QuanLyThuVien.Properties.Resources.eye_password_hide_icon_512x512_iv45hct9__1_;
            this.button2.Location = new System.Drawing.Point(948, 284);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 56);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.BackgroundImage = global::DoAn_QuanLyThuVien.Properties.Resources._012;
            this.panel1.Location = new System.Drawing.Point(-3, -9);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 600);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(704, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1063, 592);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.linkLabelDangKy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxMatKhau);
            this.Controls.Add(this.textBoxTenTK);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DangNhap";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxTenTK;
        private System.Windows.Forms.TextBox textBoxMatKhau;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabelDangKy;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

