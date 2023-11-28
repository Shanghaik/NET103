namespace DBFirstDemo
{
    partial class Form_Products
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
            this.btn_Show = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.tbt_ID = new System.Windows.Forms.TextBox();
            this.tbt_Ten = new System.Windows.Forms.TextBox();
            this.tbt_Gia = new System.Windows.Forms.TextBox();
            this.tbt_Soluong = new System.Windows.Forms.TextBox();
            this.tbt_Trangthai = new System.Windows.Forms.TextBox();
            this.tbt_NhaSX = new System.Windows.Forms.TextBox();
            this.tbt_Mota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Show)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_Show
            // 
            this.dtg_Show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Show.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Show.Location = new System.Drawing.Point(12, 12);
            this.dtg_Show.Name = "dtg_Show";
            this.dtg_Show.RowHeadersWidth = 51;
            this.dtg_Show.RowTemplate.Height = 29;
            this.dtg_Show.Size = new System.Drawing.Size(934, 276);
            this.dtg_Show.TabIndex = 0;
            this.dtg_Show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Show_CellClick);
            this.dtg_Show.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Show_CellContentClick);
            // 
            // btn_Show
            // 
            this.btn_Show.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Show.Location = new System.Drawing.Point(12, 305);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(157, 54);
            this.btn_Show.TabIndex = 1;
            this.btn_Show.Text = "Hiển thị";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Add.Location = new System.Drawing.Point(211, 305);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(157, 54);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Update.Location = new System.Drawing.Point(414, 305);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(157, 54);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Delete.Location = new System.Drawing.Point(626, 305);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(157, 54);
            this.btn_Delete.TabIndex = 1;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // tbt_ID
            // 
            this.tbt_ID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbt_ID.Location = new System.Drawing.Point(203, 401);
            this.tbt_ID.Name = "tbt_ID";
            this.tbt_ID.Size = new System.Drawing.Size(639, 30);
            this.tbt_ID.TabIndex = 2;
            // 
            // tbt_Ten
            // 
            this.tbt_Ten.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbt_Ten.Location = new System.Drawing.Point(203, 445);
            this.tbt_Ten.Name = "tbt_Ten";
            this.tbt_Ten.Size = new System.Drawing.Size(639, 30);
            this.tbt_Ten.TabIndex = 2;
            // 
            // tbt_Gia
            // 
            this.tbt_Gia.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbt_Gia.Location = new System.Drawing.Point(203, 491);
            this.tbt_Gia.Name = "tbt_Gia";
            this.tbt_Gia.Size = new System.Drawing.Size(639, 30);
            this.tbt_Gia.TabIndex = 2;
            // 
            // tbt_Soluong
            // 
            this.tbt_Soluong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbt_Soluong.Location = new System.Drawing.Point(203, 533);
            this.tbt_Soluong.Name = "tbt_Soluong";
            this.tbt_Soluong.Size = new System.Drawing.Size(639, 30);
            this.tbt_Soluong.TabIndex = 2;
            // 
            // tbt_Trangthai
            // 
            this.tbt_Trangthai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbt_Trangthai.Location = new System.Drawing.Point(203, 574);
            this.tbt_Trangthai.Name = "tbt_Trangthai";
            this.tbt_Trangthai.Size = new System.Drawing.Size(639, 30);
            this.tbt_Trangthai.TabIndex = 2;
            // 
            // tbt_NhaSX
            // 
            this.tbt_NhaSX.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbt_NhaSX.Location = new System.Drawing.Point(203, 613);
            this.tbt_NhaSX.Name = "tbt_NhaSX";
            this.tbt_NhaSX.Size = new System.Drawing.Size(639, 30);
            this.tbt_NhaSX.TabIndex = 2;
            // 
            // tbt_Mota
            // 
            this.tbt_Mota.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbt_Mota.Location = new System.Drawing.Point(203, 653);
            this.tbt_Mota.Name = "tbt_Mota";
            this.tbt_Mota.Size = new System.Drawing.Size(639, 30);
            this.tbt_Mota.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(51, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(51, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(51, 540);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(51, 576);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tráng thái";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(51, 620);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nhà SX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(51, 660);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Mô tả";
            // 
            // Form_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 706);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbt_Mota);
            this.Controls.Add(this.tbt_NhaSX);
            this.Controls.Add(this.tbt_Trangthai);
            this.Controls.Add(this.tbt_Soluong);
            this.Controls.Add(this.tbt_Gia);
            this.Controls.Add(this.tbt_Ten);
            this.Controls.Add(this.tbt_ID);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.dtg_Show);
            this.Name = "Form_Products";
            this.Text = "Form_Products";
            this.Load += new System.EventHandler(this.Form_Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtg_Show;
        private Button btn_Show;
        private Button btn_Add;
        private Button btn_Update;
        private Button btn_Delete;
        private TextBox tbt_ID;
        private TextBox tbt_Ten;
        private TextBox tbt_Gia;
        private TextBox tbt_Soluong;
        private TextBox tbt_Trangthai;
        private TextBox tbt_NhaSX;
        private TextBox tbt_Mota;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}