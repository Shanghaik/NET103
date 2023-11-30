using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Three_Layer.Services_BUS;

namespace Three_Layer.Views_PRL
{
    public partial class Chuongtrinh : Form
    {
        SinhvienServices _services;
        TruongServices _truongServices = new TruongServices();
        public Chuongtrinh()
        {
            InitializeComponent();
            _services= new SinhvienServices();
            _truongServices = new TruongServices();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void bt_Hien_Click(object sender, EventArgs e)
        {
            dtg_Show.DataSource = _services.GetAll();
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(cbb_Truong.SelectedItem.ToString());
            string ten = tb_Ten.Text;
            string email = tb_Email.Text;
            string sdt = tb_SDT.Text;
            int idtruong;
            bool parseOK = Int32.TryParse(cbb_Truong.SelectedItem.ToString(), out idtruong);
            MessageBox.Show(_services.ThemSinhvien(ten, email, sdt, idtruong));
        }

        private void Chuongtrinh_Load(object sender, EventArgs e)
        {
            var idtruongs = _truongServices.GetAllId();
            foreach(var id in idtruongs)
            {
                cbb_Truong.Items.Add(id);
            }
        }
    }
}
