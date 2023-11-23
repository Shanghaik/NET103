namespace QLNguoiYeuCu._3_PRL
{
    partial class Form_QuanLyNYC
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
            this.btn_ADO = new System.Windows.Forms.Button();
            this.cbb_Table = new System.Windows.Forms.ComboBox();
            this.ms_CRUD = new System.Windows.Forms.MenuStrip();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONGVIECToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dEANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nHANVIENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHONGBANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pn_Add = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Show)).BeginInit();
            this.ms_CRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_Show
            // 
            this.dtg_Show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Show.Location = new System.Drawing.Point(12, 51);
            this.dtg_Show.Name = "dtg_Show";
            this.dtg_Show.RowHeadersWidth = 51;
            this.dtg_Show.RowTemplate.Height = 29;
            this.dtg_Show.Size = new System.Drawing.Size(853, 258);
            this.dtg_Show.TabIndex = 0;
            this.dtg_Show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Show_CellClick);
            // 
            // btn_Show
            // 
            this.btn_Show.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Show.Location = new System.Drawing.Point(17, 325);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(238, 52);
            this.btn_Show.TabIndex = 1;
            this.btn_Show.Text = "Hiện";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // btn_ADO
            // 
            this.btn_ADO.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ADO.Location = new System.Drawing.Point(323, 325);
            this.btn_ADO.Name = "btn_ADO";
            this.btn_ADO.Size = new System.Drawing.Size(238, 52);
            this.btn_ADO.TabIndex = 1;
            this.btn_ADO.Text = "Load từ CSDL";
            this.btn_ADO.UseVisualStyleBackColor = true;
            this.btn_ADO.Click += new System.EventHandler(this.btn_ADO_Click);
            // 
            // cbb_Table
            // 
            this.cbb_Table.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb_Table.FormattingEnabled = true;
            this.cbb_Table.Items.AddRange(new object[] {
            "CONGVIEC",
            "DEAN",
            "DIADIEM_PHG",
            "NHANVIEN",
            "PHANCONG",
            "PHONGBAN",
            "THANNHAN"});
            this.cbb_Table.Location = new System.Drawing.Point(623, 338);
            this.cbb_Table.Name = "cbb_Table";
            this.cbb_Table.Size = new System.Drawing.Size(238, 36);
            this.cbb_Table.TabIndex = 2;
            // 
            // ms_CRUD
            // 
            this.ms_CRUD.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms_CRUD.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.sửaToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.ms_CRUD.Location = new System.Drawing.Point(0, 0);
            this.ms_CRUD.Name = "ms_CRUD";
            this.ms_CRUD.Size = new System.Drawing.Size(883, 36);
            this.ms_CRUD.TabIndex = 3;
            this.ms_CRUD.Text = "menuStrip1";
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cONGVIECToolStripMenuItem,
            this.dEANToolStripMenuItem,
            this.nHANVIENToolStripMenuItem,
            this.pHONGBANToolStripMenuItem});
            this.thêmToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(74, 32);
            this.thêmToolStripMenuItem.Text = "Thêm";
            // 
            // cONGVIECToolStripMenuItem
            // 
            this.cONGVIECToolStripMenuItem.Name = "cONGVIECToolStripMenuItem";
            this.cONGVIECToolStripMenuItem.Size = new System.Drawing.Size(206, 32);
            this.cONGVIECToolStripMenuItem.Text = "CONGVIEC";
            this.cONGVIECToolStripMenuItem.Click += new System.EventHandler(this.cONGVIECToolStripMenuItem_Click);
            // 
            // dEANToolStripMenuItem
            // 
            this.dEANToolStripMenuItem.Name = "dEANToolStripMenuItem";
            this.dEANToolStripMenuItem.Size = new System.Drawing.Size(206, 32);
            this.dEANToolStripMenuItem.Text = "DEAN";
            // 
            // nHANVIENToolStripMenuItem
            // 
            this.nHANVIENToolStripMenuItem.Name = "nHANVIENToolStripMenuItem";
            this.nHANVIENToolStripMenuItem.Size = new System.Drawing.Size(206, 32);
            this.nHANVIENToolStripMenuItem.Text = "NHANVIEN";
            // 
            // pHONGBANToolStripMenuItem
            // 
            this.pHONGBANToolStripMenuItem.Name = "pHONGBANToolStripMenuItem";
            this.pHONGBANToolStripMenuItem.Size = new System.Drawing.Size(206, 32);
            this.pHONGBANToolStripMenuItem.Text = "PHONGBAN";
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(59, 32);
            this.sửaToolStripMenuItem.Text = "Sửa";
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(60, 32);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // pn_Add
            // 
            this.pn_Add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pn_Add.Location = new System.Drawing.Point(12, 396);
            this.pn_Add.Name = "pn_Add";
            this.pn_Add.Size = new System.Drawing.Size(853, 269);
            this.pn_Add.TabIndex = 4;
            // 
            // Form_QuanLyNYC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 709);
            this.Controls.Add(this.pn_Add);
            this.Controls.Add(this.cbb_Table);
            this.Controls.Add(this.btn_ADO);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.dtg_Show);
            this.Controls.Add(this.ms_CRUD);
            this.MainMenuStrip = this.ms_CRUD;
            this.Name = "Form_QuanLyNYC";
            this.Text = "Form_QuanLyNYC";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Show)).EndInit();
            this.ms_CRUD.ResumeLayout(false);
            this.ms_CRUD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtg_Show;
        private Button btn_Show;
        private Button btn_ADO;
        private ComboBox cbb_Table;
        private MenuStrip ms_CRUD;
        private ToolStripMenuItem thêmToolStripMenuItem;
        private ToolStripMenuItem cONGVIECToolStripMenuItem;
        private ToolStripMenuItem dEANToolStripMenuItem;
        private ToolStripMenuItem nHANVIENToolStripMenuItem;
        private ToolStripMenuItem sửaToolStripMenuItem;
        private ToolStripMenuItem xóaToolStripMenuItem;
        private ToolStripMenuItem pHONGBANToolStripMenuItem;
        private Panel pn_Add;
    }
}