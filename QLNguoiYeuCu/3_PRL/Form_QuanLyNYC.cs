using Microsoft.Data.SqlClient;
using QLNguoiYeuCu._1_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLNguoiYeuCu._3_PRL
{
    public partial class Form_QuanLyNYC : Form
    {
        // Connection string: là một chuỗi chứa các thông tin liên quan tới CSDL - Hệ quản trị CSDL
        // và các thiết lập để có thể thông qua đó thực hiện kết nối với CSDL mon muốn
        // Các thông tin thường bao gồm: Data Source: Tên Server, Initital Catalog: Tên DB
        // các thông tin liên quan tới tài khoản, mật khẩu và config cho DB... 
        string connectionString = @"Data Source=SHANGHAIK;Initial Catalog=QLDA;Integrated Security=True;TrustServerCertificate=Yes";
        string maDA = "", stt = "", tenCV = ""; 
        public Form_QuanLyNYC()
        {
            InitializeComponent();
        }

        public void LoadDataToGridView1() // Cách thô sơ 
        {
            // Fake data là 1 danh sách người yêu cũ
            List<NguoiYeuCu> nguoiYeuCus = new List<NguoiYeuCu>()
            {
                new NguoiYeuCu{ Ten = "Dũng", GioiTinh = true, Tuoi = 50, ThoiGian = "4 tháng"},
                new NguoiYeuCu{ Ten = "Tiến", GioiTinh = true, Tuoi = 25, ThoiGian = "4 năm"},
                new NguoiYeuCu{ Ten = "Hằng", GioiTinh = false, Tuoi = 17, ThoiGian = "4 ngày"},
                new NguoiYeuCu{ Ten = "Nguyên", GioiTinh = true, Tuoi = 18, ThoiGian = "4 tuần"}
            };
            // cách đơn giản nhất là set Datasource của datagridview = List vừa tạo
            // => Nhanh nhưng không thể đặt tên cột và dữ liệu dễ chồng chéo
            dtg_Show.DataSource = nguoiYeuCus;
        }
        public void LoadDataToGridView2() // Cách mà tự thiết lập cho datagridView
        {
            dtg_Show.Rows.Clear(); // Xóa sạch dữ liệu cũ đi
            // Fake data là 1 danh sách người yêu cũ
            List<NguoiYeuCu> nguoiYeuCus = new List<NguoiYeuCu>()
            {
                new NguoiYeuCu{ Ten = "Dũng", GioiTinh = true, Tuoi = 50, ThoiGian = "4 tháng"},
                new NguoiYeuCu{ Ten = "Tiến", GioiTinh = true, Tuoi = 25, ThoiGian = "4 năm"},
                new NguoiYeuCu{ Ten = "Hằng", GioiTinh = false, Tuoi = 17, ThoiGian = "4 ngày"},
                new NguoiYeuCu{ Ten = "Nguyên", GioiTinh = true, Tuoi = 18, ThoiGian = "4 tuần"}
            };
            // VÌ người yêu cũ có 4 thuộc tính => Thiết lập 5 cột, thêm 1 cột số thứ tự
            dtg_Show.ColumnCount = 5; // Gán số lượng cột = 5
            // Đặt tên cột cho các cột (HeaderText)
            dtg_Show.Columns[0].HeaderText = "Số thứ tự";
            dtg_Show.Columns[1].HeaderText = "Tên";
            dtg_Show.Columns[2].HeaderText = "Tuổi";
            dtg_Show.Columns[3].HeaderText = "Giới tính";
            dtg_Show.Columns[4].HeaderText = "Thời gian";
            // Thêm dữ liệu vào gridView => Thêm từng Người yêu cũ từ List vào trong gridview
            // Tạo 1 thuộc tính tăng dân để làm số thứ tự
            int stt = 1;
            foreach (NguoiYeuCu nyc in nguoiYeuCus)
            {
                dtg_Show.Rows.Add(stt++, nyc.Ten, nyc.Tuoi, nyc.GioiTinh ? "Nam" : "Nữ", nyc.ThoiGian);
                // Sau mỗi lần add thì stt tự + lên 1 đơn vị
            }
        }
        private void btn_Show_Click(object sender, EventArgs e)
        {
            if (btn_Show.Text == "Hiện")
            {
                LoadDataToGridView2();
                btn_Show.Text = "Ẩn";
            }
            else
            {
                dtg_Show.Rows.Clear();
                btn_Show.Text = "Hiện";
            }

        }

        private void dtg_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy được data của Row đang click vào
            int index = e.RowIndex; // Xác định Rows
            var rowdata = dtg_Show.Rows[index]; // Lấy tất cả dữ liệu từ Row đó
            // Gán dữ liệu
            string Ten = rowdata.Cells[1].Value.ToString(); // Cell[1] chứa tên của nyc
            string Thoigian = rowdata.Cells[4].Value.ToString(); // 
            // Hiển thị dữ liệu đó lên MessageBox
            MessageBox.Show($"Bạn đã bỏ em {Ten} sau {Thoigian}");
        }
        // ADO.net là một công nghệ cho phép chúng ta thực hiện tương tác với CSDL thông qua
        // các câu lệnh bàng cách thực thi các truy vấn như trên SQL bình thường nhưng truy
        // vấn đó được viết trên code
        private void btn_ADO_Click(object sender, EventArgs e)
        {
            // Connection string: là một chuỗi chứa các thông tin liên quan tới CSDL - Hệ quản trị CSDL
            // và các thiết lập để có thể thông qua đó thực hiện kết nối với CSDL mon muốn
            // Các thông tin thường bao gồm: Data Source: Tên Server, Initital Catalog: Tên DB
            // các thông tin liên quan tới tài khoản, mật khẩu và config cho DB... 
            // Tạo 1 dataTable để hứng kết quả trả về từ SQL
            DataTable data = new DataTable();
            // Tạo 1 kết nối Connection với connectionstring vừa tạo ra
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open(); // Mở kết nối
                             // Viết câu truy vấn
                string tableName = cbb_Table.SelectedItem.ToString(); // Đã tạo sẵn 1 combobox để lưu các tên bảng cho mình chọn
                string query = $"Select * from {tableName}";
                // Thực hiện chạy câu truy vấn bằng cách tạo ra 1 command với truy vấn và liên kết đã tạo
                SqlCommand command = new SqlCommand(query, conn);
                // Tạo 1 dataAdapter để chứa data sau khi chạy truy vấn với command
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data); // Đẩy dữ liệu vào datatable
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { conn.Close(); }// Đóng kết nối
            dtg_Show.DataSource = data;
        }

        private void cONGVIECToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Thử add một vài control vào trong panel
            Label lb1 = new Label(); // Add label
            lb1.Text = "Mã dự án";
            Label lb2 = new Label(); // Add label
            lb2.Text = "STT";
            Label lb3 = new Label(); // Add label
            lb3.Text = "Tên Công việc";
            lb1.Parent = pn_Add;
            lb2.Parent = pn_Add;
            lb3.Parent = pn_Add;
            // set vị trí cho label trong panel 
            lb1.Location = new Point(40, 50);
            lb2.Location = new Point(40, 100); // 0 là tọa độ ngang, 150 là tọa độ dọc
            lb3.Location = new Point(40, 150);
            //pn_Add.Controls.Add(lb1); // Thêm label vào trong panel
            //pn_Add.Controls.Add(lb2);
            //pn_Add.Controls.Add(lb3);
            TextBox tb_MDA = new TextBox(); tb_MDA.Parent = pn_Add; tb_MDA.Location = new Point(150, 50);
            TextBox tb_STT = new TextBox(); tb_STT.Parent = pn_Add; tb_STT.Location = new Point(150, 100);
            TextBox tb_TCV = new TextBox(); tb_TCV.Parent = pn_Add; tb_TCV.Location = new Point(150, 150);
            tb_MDA.Width = 300; tb_STT.Width = 300; tb_TCV.Width = 300;
            Button bt_Add = new Button(); bt_Add.Text = "Thêm"; bt_Add.Parent = pn_Add;
            bt_Add.Location = new Point(150, 200);
            bt_Add.Height = 50; bt_Add.Width = 150;
            bt_Add.Font = new Font("Arial", 14); bt_Add.BackColor = Color.Yellow; // Set font chữ và màu
            bt_Add.Click += Bt_Add_Click; // Tạo sự kiện cho Button vừa thêm
            // Tạo sự kiện TextChange cho các TextBox
            tb_MDA.TextChanged += Tb_MDA_TextChanged;
            tb_STT.TextChanged += Tb_STT_TextChanged;
            tb_TCV.TextChanged += Tb_TCV_TextChanged;
        }

        private void Tb_TCV_TextChanged(object? sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            tenCV = textBox.Text;
        }

        private void Tb_STT_TextChanged(object? sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            stt = textBox.Text;
        }

        private void Tb_MDA_TextChanged(object? sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            maDA = textBox.Text;
        }

        private void Bt_Add_Click(object? sender, EventArgs e)
        {
            string query = $"insert into CONGVIEC values ({maDA},{stt},N'{tenCV}')";
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open(); // Mở kết nối 
                // Thực hiện chạy câu truy vấn bằng cách tạo ra 1 command với truy vấn và liên kết đã tạo
                SqlCommand command = new SqlCommand(query, conn);
                int count = command.ExecuteNonQuery(); // Phương thức này trả về số dòng affected (chạy tành công)
                MessageBox.Show("Bạn đã thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { conn.Close(); }// Đóng kết nối
        }
    }
}
