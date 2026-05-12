namespace DoAn_QuanLyThuVien
{
    partial class ThongKeSach
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
            this.btnrefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSachMuonNhiueNhat = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSachMuaNhieuNhat = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.MaBaoCao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChatLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoSung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HuySach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin sách :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.BackColor = System.Drawing.Color.LawnGreen;
            this.btnrefresh.Location = new System.Drawing.Point(711, 168);
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(142, 68);
            this.btnrefresh.TabIndex = 2;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = false;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(25, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sách có lượt mượn nhiều nhất : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbSachMuonNhiueNhat
            // 
            this.lbSachMuonNhiueNhat.AutoSize = true;
            this.lbSachMuonNhiueNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSachMuonNhiueNhat.Location = new System.Drawing.Point(7, 42);
            this.lbSachMuonNhiueNhat.Name = "lbSachMuonNhiueNhat";
            this.lbSachMuonNhiueNhat.Size = new System.Drawing.Size(0, 25);
            this.lbSachMuonNhiueNhat.TabIndex = 4;
            this.lbSachMuonNhiueNhat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lbSachMuonNhiueNhat);
            this.groupBox1.Location = new System.Drawing.Point(29, 109);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(630, 196);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(25, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sách có lượt mua nhiều nhất : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(25, 604);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sách có tình trạng cũ , hỏng : ";
            // 
            // lbSachMuaNhieuNhat
            // 
            this.lbSachMuaNhieuNhat.AutoSize = true;
            this.lbSachMuaNhieuNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSachMuaNhieuNhat.Location = new System.Drawing.Point(20, 49);
            this.lbSachMuaNhieuNhat.Name = "lbSachMuaNhieuNhat";
            this.lbSachMuaNhieuNhat.Size = new System.Drawing.Size(0, 25);
            this.lbSachMuaNhieuNhat.TabIndex = 8;
            this.lbSachMuaNhieuNhat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.lbSachMuaNhieuNhat);
            this.groupBox2.Location = new System.Drawing.Point(29, 386);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(630, 189);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBaoCao,
            this.MaSach,
            this.TenSach,
            this.ChatLuong,
            this.SoLuong,
            this.BoSung,
            this.HuySach});
            this.dataGridView2.Location = new System.Drawing.Point(14, 635);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(853, 351);
            this.dataGridView2.TabIndex = 21;
            // 
            // MaBaoCao
            // 
            this.MaBaoCao.DataPropertyName = "MaBaoCao";
            this.MaBaoCao.HeaderText = "Mã báo cáo";
            this.MaBaoCao.MinimumWidth = 6;
            this.MaBaoCao.Name = "MaBaoCao";
            this.MaBaoCao.Width = 125;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.Width = 125;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.MinimumWidth = 6;
            this.TenSach.Name = "TenSach";
            this.TenSach.Width = 125;
            // 
            // ChatLuong
            // 
            this.ChatLuong.DataPropertyName = "ChatLuong";
            this.ChatLuong.HeaderText = "Chất lượng";
            this.ChatLuong.MinimumWidth = 6;
            this.ChatLuong.Name = "ChatLuong";
            this.ChatLuong.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 125;
            // 
            // BoSung
            // 
            this.BoSung.DataPropertyName = "BoSung";
            this.BoSung.HeaderText = "Bổ sung";
            this.BoSung.MinimumWidth = 6;
            this.BoSung.Name = "BoSung";
            this.BoSung.Width = 125;
            // 
            // HuySach
            // 
            this.HuySach.DataPropertyName = "HuySach";
            this.HuySach.HeaderText = "Huỷ sách";
            this.HuySach.MinimumWidth = 6;
            this.HuySach.Name = "HuySach";
            this.HuySach.Width = 125;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LawnGreen;
            this.button1.Location = new System.Drawing.Point(711, 435);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 68);
            this.button1.TabIndex = 22;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ThongKeSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(885, 976);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ThongKeSach";
            this.Text = "ThongKeSach";
            this.Load += new System.EventHandler(this.ThongKeSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSachMuonNhiueNhat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbSachMuaNhieuNhat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBaoCao;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChatLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoSung;
        private System.Windows.Forms.DataGridViewTextBoxColumn HuySach;
        private System.Windows.Forms.Button button1;
    }
}