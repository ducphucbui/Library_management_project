namespace DoAn_QuanLyThuVien
{
    partial class DangKy
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
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtXacNhanMK = new System.Windows.Forms.TextBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btncheckemail = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatKhau.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMatKhau.Location = new System.Drawing.Point(719, 214);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(400, 52);
            this.txtMatKhau.TabIndex = 4;
            this.txtMatKhau.Text = "Mật khẩu";
            this.txtMatKhau.Click += new System.EventHandler(this.txtMatKhau_Click);
            this.txtMatKhau.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMatKhau_MouseClick_1);
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            // 
            // txtTenTK
            // 
            this.txtTenTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenTK.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTenTK.Location = new System.Drawing.Point(719, 112);
            this.txtTenTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(462, 52);
            this.txtTenTK.TabIndex = 3;
            this.txtTenTK.Text = "Tài khoản";
            this.txtTenTK.Click += new System.EventHandler(this.txtTenTK_Click);
            this.txtTenTK.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMatKhau_MouseClick_1);
            this.txtTenTK.TextChanged += new System.EventHandler(this.txtTenTK_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtEmail.Location = new System.Drawing.Point(719, 416);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(400, 52);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.Text = "Email";
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            this.txtEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMatKhau_MouseClick_1);
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged_1);
            // 
            // txtXacNhanMK
            // 
            this.txtXacNhanMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtXacNhanMK.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtXacNhanMK.Location = new System.Drawing.Point(719, 315);
            this.txtXacNhanMK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtXacNhanMK.Name = "txtXacNhanMK";
            this.txtXacNhanMK.Size = new System.Drawing.Size(400, 52);
            this.txtXacNhanMK.TabIndex = 5;
            this.txtXacNhanMK.Text = "Xác nhận mật khẩu";
            this.txtXacNhanMK.Click += new System.EventHandler(this.txtXacNhanMK_Click);
            this.txtXacNhanMK.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtXacNhanMK_MouseClick);
            this.txtXacNhanMK.TextChanged += new System.EventHandler(this.txtXacNhanMK_TextChanged);
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangKy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDangKy.Location = new System.Drawing.Point(719, 518);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(462, 64);
            this.btnDangKy.TabIndex = 7;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            this.btnDangKy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMatKhau_MouseClick_1);
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.Location = new System.Drawing.Point(719, 485);
            this.checkBoxAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(78, 24);
            this.checkBoxAdmin.TabIndex = 10;
            this.checkBoxAdmin.Text = "admin";
            this.checkBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chartreuse;
            this.panel1.BackgroundImage = global::DoAn_QuanLyThuVien.Properties.Resources.lovepik_library_picture_501562414;
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 651);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(867, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng ký";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btncheckemail
            // 
            this.btncheckemail.BackColor = System.Drawing.Color.White;
            this.btncheckemail.Image = global::DoAn_QuanLyThuVien.Properties.Resources.Ảnh_chụp_màn_hình_2024_05_28_201514;
            this.btncheckemail.Location = new System.Drawing.Point(1121, 416);
            this.btncheckemail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btncheckemail.Name = "btncheckemail";
            this.btncheckemail.Size = new System.Drawing.Size(61, 56);
            this.btncheckemail.TabIndex = 11;
            this.btncheckemail.UseVisualStyleBackColor = false;
            this.btncheckemail.Click += new System.EventHandler(this.btncheckemail_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = global::DoAn_QuanLyThuVien.Properties.Resources.eye_password_hide_icon_512x512_iv45hct9__1_;
            this.button1.Location = new System.Drawing.Point(1121, 315);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 56);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Image = global::DoAn_QuanLyThuVien.Properties.Resources.eye_password_hide_icon_512x512_iv45hct9__1_;
            this.button2.Location = new System.Drawing.Point(1121, 214);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 56);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 650);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btncheckemail);
            this.Controls.Add(this.checkBoxAdmin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtXacNhanMK);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenTK);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DangKy";
            this.Text = "Sign up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtXacNhanMK;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxAdmin;
        private System.Windows.Forms.Button btncheckemail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}