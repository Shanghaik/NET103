namespace Three_Layer.Views_PRL
{
    partial class Chuongtrinh
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
            this.dtg_Show = new System.Windows.Forms.DataGridView();
            this.bt_Hien = new System.Windows.Forms.Button();
            this.bt_Them = new System.Windows.Forms.Button();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.tbt_Tim = new System.Windows.Forms.TextBox();
            this.tb_Ten = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_SDT = new System.Windows.Forms.TextBox();
            this.cbb_Truong = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Show)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_Show
            // 
            this.dtg_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Show.Location = new System.Drawing.Point(12, 55);
            this.dtg_Show.Name = "dtg_Show";
            this.dtg_Show.RowHeadersWidth = 51;
            this.dtg_Show.RowTemplate.Height = 29;
            this.dtg_Show.Size = new System.Drawing.Size(1008, 322);
            this.dtg_Show.TabIndex = 0;
            // 
            // bt_Hien
            // 
            this.bt_Hien.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_Hien.Location = new System.Drawing.Point(16, 398);
            this.bt_Hien.Name = "bt_Hien";
            this.bt_Hien.Size = new System.Drawing.Size(228, 49);
            this.bt_Hien.TabIndex = 1;
            this.bt_Hien.Text = "Hiển thị";
            this.bt_Hien.UseVisualStyleBackColor = true;
            this.bt_Hien.Click += new System.EventHandler(this.bt_Hien_Click);
            // 
            // bt_Them
            // 
            this.bt_Them.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_Them.Location = new System.Drawing.Point(276, 398);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(228, 49);
            this.bt_Them.TabIndex = 1;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.UseVisualStyleBackColor = true;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // bt_Sua
            // 
            this.bt_Sua.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_Sua.Location = new System.Drawing.Point(532, 398);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(228, 49);
            this.bt_Sua.TabIndex = 1;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.UseVisualStyleBackColor = true;
            this.bt_Sua.Click += new System.EventHandler(this.button3_Click);
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_Xoa.Location = new System.Drawing.Point(792, 398);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(228, 49);
            this.bt_Xoa.TabIndex = 1;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.UseVisualStyleBackColor = true;
            this.bt_Xoa.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbt_Tim
            // 
            this.tbt_Tim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_Tim.Location = new System.Drawing.Point(12, 14);
            this.tbt_Tim.Name = "tbt_Tim";
            this.tbt_Tim.PlaceholderText = "Nhập thông tin tìm kiếm";
            this.tbt_Tim.Size = new System.Drawing.Size(540, 34);
            this.tbt_Tim.TabIndex = 2;
            // 
            // tb_Ten
            // 
            this.tb_Ten.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_Ten.Location = new System.Drawing.Point(219, 493);
            this.tb_Ten.Name = "tb_Ten";
            this.tb_Ten.Size = new System.Drawing.Size(801, 31);
            this.tb_Ten.TabIndex = 2;
            // 
            // tb_Email
            // 
            this.tb_Email.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_Email.Location = new System.Drawing.Point(219, 539);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(801, 31);
            this.tb_Email.TabIndex = 2;
            // 
            // tb_SDT
            // 
            this.tb_SDT.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_SDT.Location = new System.Drawing.Point(219, 591);
            this.tb_SDT.Name = "tb_SDT";
            this.tb_SDT.Size = new System.Drawing.Size(801, 31);
            this.tb_SDT.TabIndex = 2;
            // 
            // cbb_Truong
            // 
            this.cbb_Truong.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbb_Truong.FormattingEnabled = true;
            this.cbb_Truong.Location = new System.Drawing.Point(220, 643);
            this.cbb_Truong.Name = "cbb_Truong";
            this.cbb_Truong.Size = new System.Drawing.Size(415, 33);
            this.cbb_Truong.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.email.Location = new System.Drawing.Point(20, 539);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(58, 25);
            this.email.TabIndex = 4;
            this.email.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(20, 591);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "SDT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(20, 643);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "ID Trường";
            // 
            // Chuongtrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 701);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_Truong);
            this.Controls.Add(this.tb_SDT);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.tb_Ten);
            this.Controls.Add(this.tbt_Tim);
            this.Controls.Add(this.bt_Xoa);
            this.Controls.Add(this.bt_Sua);
            this.Controls.Add(this.bt_Them);
            this.Controls.Add(this.bt_Hien);
            this.Controls.Add(this.dtg_Show);
            this.Name = "Chuongtrinh";
            this.Text = "Chuongtrinh";
            this.Load += new System.EventHandler(this.Chuongtrinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtg_Show;
        private Button bt_Hien;
        private Button bt_Them;
        private Button bt_Sua;
        private Button bt_Xoa;
        private TextBox tbt_Tim;
        private TextBox tb_Ten;
        private TextBox tb_Email;
        private TextBox tb_SDT;
        private ComboBox cbb_Truong;
        private Label label1;
        private Label email;
        private Label label3;
        private Label label4;
    }
}