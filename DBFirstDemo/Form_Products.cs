
using DBFirstDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFirstDemo
{
    public partial class Form_Products : Form
    {
        // Khai báo đối tượng Context để thực hiện các liên kết với CSDL thông qua nó
        IT17301_ShoppingContext _context = new IT17301_ShoppingContext();
        public Form_Products()
        {
            InitializeComponent();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            // Hiển thị ra các cột trong bảng Product
            // Lấy dữ liệu của Bảng thông qua DBSet
            var data = _context.Products.ToList();
            // dtg_Show.DataSource = data;
            dtg_Show.ColumnCount = 8; // Gán số lượng cột = 5
            // dtg_Show.AutoSize
            // Đặt tên cột cho các cột (HeaderText)
            // ID, name, price, Quantity, Status, Supplier, Description
            dtg_Show.Columns[0].HeaderText = "Số thứ tự";
            dtg_Show.Columns[1].HeaderText = "ID";
            dtg_Show.Columns[2].HeaderText = "Tên";
            dtg_Show.Columns[3].HeaderText = "Giá";
            dtg_Show.Columns[4].HeaderText = "Số lượng";
            dtg_Show.Columns[5].HeaderText = "Trạng thái";
            dtg_Show.Columns[6].HeaderText = "Nhà cung cấp";
            dtg_Show.Columns[7].HeaderText = "Mô tả";
            // Ẩn 1 cột đi - Cột ID không hiển thị
            dtg_Show.Columns[1].Visible = false;
            // Thêm dữ liệu vào gridView => Thêm từng Người yêu cũ từ List vào trong gridview
            // Tạo 1 thuộc tính tăng dân để làm số thứ tự
            int stt = 1;
            foreach (Product p in data)
            {
                dtg_Show.Rows.Add(stt++, p.Id, p.Name, p.Price, p.AvailableQuantity, p.Status, p.Supplier, p.Description);
                // Sau mỗi lần add thì stt tự + lên 1 đơn vị
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtg_Show_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Click vào content - nội dung
        }

        private void dtg_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Khi click vào ô của bảng mà có index > 0
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dtg_Show.Rows[e.RowIndex]; // Lấy ra dòng mà mình chọn
                tbt_ID.Text = row.Cells[1].Value.ToString(); tbt_ID.Enabled = false; // Ẩn cột ID ko cho sửa
                tbt_Ten.Text = row.Cells[2].Value.ToString();
                tbt_Gia.Text = row.Cells[3].Value.ToString();
                tbt_Soluong.Text = row.Cells[4].Value.ToString();
                tbt_Trangthai.Text = row.Cells[5].Value.ToString();
                tbt_NhaSX.Text = row.Cells[6].Value.ToString();
                tbt_Mota.Text = row.Cells[7].Value.ToString();
            }
        }
    }
}
