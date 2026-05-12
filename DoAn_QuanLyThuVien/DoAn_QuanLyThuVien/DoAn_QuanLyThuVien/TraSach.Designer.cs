namespace DoAn_QuanLyThuVien
{
    partial class TraSach
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
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.txtMaMuonSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(135, 78);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(267, 26);
            this.dateTimePicker2.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Ngày trả";
            // 
            // btnTraSach
            // 
            this.btnTraSach.BackColor = System.Drawing.Color.LawnGreen;
            this.btnTraSach.Location = new System.Drawing.Point(559, 16);
            this.btnTraSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(100, 39);
            this.btnTraSach.TabIndex = 27;
            this.btnTraSach.Text = "Trả sách";
            this.btnTraSach.UseVisualStyleBackColor = false;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.LawnGreen;
            this.btnthoat.Location = new System.Drawing.Point(557, 85);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(102, 39);
            this.btnthoat.TabIndex = 28;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMaMuonSach
            // 
            this.txtMaMuonSach.Location = new System.Drawing.Point(135, 9);
            this.txtMaMuonSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaMuonSach.Name = "txtMaMuonSach";
            this.txtMaMuonSach.Size = new System.Drawing.Size(267, 26);
            this.txtMaMuonSach.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Mã Mượn Sách";
            // 
            // TraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(693, 142);
            this.Controls.Add(this.txtMaMuonSach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnTraSach);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label8);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TraSach";
            this.Text = "TraSach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txtMaMuonSach;
        private System.Windows.Forms.Label label2;
    }
}