using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNguoiYeuCu._3_PRL
{
    public partial class Form_XoaDA : Form
    {
        string connectionString = @"Data Source=SHANGHAIK;Initial Catalog=QLDA;Integrated Security=True;TrustServerCertificate=Yes";
        public Form_XoaDA()
        {
            InitializeComponent();
        }

        private void Form_XoaDA_Load(object sender, EventArgs e)
        {
            // Khi hiển thị ra form, lập tức load tất cả các tên thân nhân vào trong combobox
            // Khi Click vào nút xóa thì sẽ hiển thị lên Dialog hỏi xem có muốn
            // xóa hay không? nếu click vào YES thì xóa/ NO thì không
            // Bước 1: Viết truy vấn để lấy ra danh sách của tất cả tên thân nhân
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open(); // Mở kết nối
                             // Viết câu truy vấn
                string query = $"Select TENTN from THANNHAN";
                // Thực hiện chạy câu truy vấn bằng cách tạo ra 1 command với truy vấn và liên kết đã tạo
                SqlCommand command = new SqlCommand(query, conn);
                // Lấy dữ liệu sau khi chạy truy vấn ADO
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Bước 4: Xử lý dữ liệu được lấy
                    while (reader.Read())
                    {
                        string name = reader.GetString(0);
                        // Xử lý dữ liệu được lấy theo nhu cầu
                        comboBox1.Items.Add(name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { conn.Close(); }// Đóng kết nối
            // Bước 2: Thực thi và add vào trong Combobox với vòng lặp
            // Bước 3: Khi chọn 1 item trong combobox ta ghi nhớ lại tên đó
            // => Truy vấn ngược để xóa theo tên đó
        }
    }
}
