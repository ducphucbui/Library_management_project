namespace DoAn_QuanLyThuVien
{
    partial class QuenMatKhau
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
            this.btnDangKy = new System.Windows.Forms.Button();
            this.txtacc = new System.Windows.Forms.TextBox();
            this.txtmkcu = new System.Windows.Forms.TextBox();
            this.txtnewpass = new System.Windows.Forms.TextBox();
            this.txtxnmkmoi = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.Magenta;
            this.btnDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangKy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDangKy.Location = new System.Drawing.Point(600, 549);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(462, 64);
            this.btnDangKy.TabIndex = 9;
            this.btnDangKy.Text = "Xác nhận";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // txtacc
            // 
            this.txtacc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtacc.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtacc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtacc.Location = new System.Drawing.Point(600, 168);
            this.txtacc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtacc.Name = "txtacc";
            this.txtacc.ShortcutsEnabled = false;
            this.txtacc.Size = new System.Drawing.Size(472, 52);
            this.txtacc.TabIndex = 10;
            this.txtacc.Text = "Tên tài khoản";
            this.txtacc.Click += new System.EventHandler(this.txtacc_Click);
            // 
            // txtmkcu
            // 
            this.txtmkcu.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmkcu.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtmkcu.Location = new System.Drawing.Point(600, 258);
            this.txtmkcu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmkcu.Name = "txtmkcu";
            this.txtmkcu.Size = new System.Drawing.Size(472, 52);
            this.txtmkcu.TabIndex = 11;
            this.txtmkcu.Tag = "";
            this.txtmkcu.Text = "Mật khẩu cũ";
            this.txtmkcu.WordWrap = false;
            this.txtmkcu.Click += new System.EventHandler(this.txtmkcu_Click);
            this.txtmkcu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtmkcu_MouseClick);
            // 
            // txtnewpass
            // 
            this.txtnewpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtnewpass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtnewpass.Location = new System.Drawing.Point(600, 362);
            this.txtnewpass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.Size = new System.Drawing.Size(462, 52);
            this.txtnewpass.TabIndex = 12;
            this.txtnewpass.Tag = "";
            this.txtnewpass.Text = "Mật khẩu mới";
            this.txtnewpass.WordWrap = false;
            this.txtnewpass.Click += new System.EventHandler(this.txtnewpass_Click);
            this.txtnewpass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtnewpass_MouseClick);
            // 
            // txtxnmkmoi
            // 
            this.txtxnmkmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtxnmkmoi.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtxnmkmoi.Location = new System.Drawing.Point(600, 464);
            this.txtxnmkmoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtxnmkmoi.Name = "txtxnmkmoi";
            this.txtxnmkmoi.Size = new System.Drawing.Size(462, 52);
            this.txtxnmkmoi.TabIndex = 13;
            this.txtxnmkmoi.Tag = "";
            this.txtxnmkmoi.Text = "Xác nhận mật khẩu";
            this.txtxnmkmoi.WordWrap = false;
            this.txtxnmkmoi.Click += new System.EventHandler(this.txtxnmkmoi_Click);
            this.txtxnmkmoi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtxnmkmoi_MouseClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Image = global::DoAn_QuanLyThuVien.Properties.Resources.eye_password_hide_icon_512x512_iv45hct9__1_;
            this.button2.Location = new System.Drawing.Point(1011, 258);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 56);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = global::DoAn_QuanLyThuVien.Properties.Resources.eye_password_hide_icon_512x512_iv45hct9__1_;
            this.button1.Location = new System.Drawing.Point(1011, 362);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 56);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Image = global::DoAn_QuanLyThuVien.Properties.Resources.eye_password_hide_icon_512x512_iv45hct9__1_;
            this.button3.Location = new System.Drawing.Point(1011, 460);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 56);
            this.button3.TabIndex = 16;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.BackgroundImage = global::DoAn_QuanLyThuVien.Properties.Resources.librarys_usage;
            this.panel1.Location = new System.Drawing.Point(-4, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 650);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(688, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐỔI MẬT KHẨU";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 645);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtxnmkmoi);
            this.Controls.Add(this.txtnewpass);
            this.Controls.Add(this.txtmkcu);
            this.Controls.Add(this.txtacc);
            this.Controls.Add(this.btnDangKy);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QuenMatKhau";
            this.Text = "Change password";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.TextBox txtacc;
        private System.Windows.Forms.TextBox txtmkcu;
        private System.Windows.Forms.TextBox txtnewpass;
        private System.Windows.Forms.TextBox txtxnmkmoi;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}