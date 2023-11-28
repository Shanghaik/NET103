
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
        Guid selectedID = Guid.Empty; // Tạo 1 biến trung gian để lưu ID được chọn trong sự kiện CellClick
        public Form_Products()
        {
            InitializeComponent();
        }
        public void LoadDataToGridView()
        {
            dtg_Show.Rows.Clear();
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
        private void btn_Show_Click(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }   

        private void dtg_Show_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Click vào content - nội dung
            // MessageBox.Show("Hello");
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
                // Gán ID được chọn cho biến để lấy id cần sửa /xóa
                selectedID = Guid.Parse(row.Cells[1].Value.ToString());
            }
            // MessageBox.Show("Bạn vừa chọn id này" + selectedID);
        }

        private void Form_Products_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ form để tạo ra một đối tượng mới
            Product p = new Product();
            p.Id = Guid.NewGuid(); // Gen ra một Guid mới
            p.Name = tbt_Ten.Text;
            p.Price = Convert.ToInt64(tbt_Gia.Text);
            p.Status = int.Parse(tbt_Trangthai.Text);
            p.Supplier = tbt_NhaSX.Text;
            p.Description = tbt_Mota.Text;
            p.AvailableQuantity = Convert.ToInt32(tbt_Soluong.Text);
            // Kiểm tra tên không trùng khi thêm
            // Dùng phương thức FirstOrDefault để lấy ra phần tử có tên giống tên được nhập vào textbox tên
            var dataByName = _context.Products.FirstOrDefault(p=>p.Name == tbt_Ten.Text);
            if(dataByName != null)
            {
                MessageBox.Show("Tên đã tồn tại trong CSDL"); return; // return để thoát luôn, có thể dùng else 
            }
            // Gọi phương thức add của DbSet để thêm vào csdl
            try
            {
                _context.Products.Add(p); // add
                _context.SaveChanges(); // Lưu lại trạng thái của db
                MessageBox.Show("Bạn đã thêm thành công vào CSDL");
                LoadDataToGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (selectedID == Guid.Empty)
            {
                MessageBox.Show("Hãy chọn đối tượng để sửa"); return;
            }
            // Lấy ra đối tượng cần sửa theo id 
            var dataUpdate = _context.Products.Find(selectedID); // Phương thức này chỉ dùng cho tham số là khóa chính
            // var dataUpdate = _context.Products.FirstOrDefault(p=>p.Id == selectedID);
            try
            {
                dataUpdate.Name = tbt_Ten.Text;
                dataUpdate.Price = Convert.ToInt64(tbt_Gia.Text);
                dataUpdate.Supplier = tbt_NhaSX.Text;
                dataUpdate.Description = tbt_Mota.Text;
                dataUpdate.Status = Convert.ToInt32(tbt_Trangthai.Text);
                dataUpdate.AvailableQuantity = Convert.ToInt32(tbt_Soluong.Text);
                _context.Products.Update(dataUpdate); // Sửa đối tượng
                _context.SaveChanges();
                MessageBox.Show("Sửa thành công");
                LoadDataToGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            // Lấy ra đối tượng cần xóa theo selectedID và xóa
            if(selectedID == Guid.Empty)
            {
                MessageBox.Show("Hãy chọn đối tượng để xóa"); return;
            }
            try
            {
                var dataDelete = _context.Products.Find(selectedID);
                _context.Products.Remove(dataDelete);
                _context.SaveChanges();
                MessageBox.Show("Xóa thành công");
                LoadDataToGridView();
                selectedID = Guid.Empty; // Reset seletedID
                // Xóa hết data trong các TextBox
                foreach (dynamic s in this.Controls) // Bỏ qua cũng được
                {
                    if(s is TextBox)
                    {
                       s.Text  = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
