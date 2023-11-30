using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Three_Layer.Models;

namespace Three_Layer.Repositories_DAL
{
    internal class SinhvienRepos
    {
        LuyenTapContext _context;
        public SinhvienRepos()
        {
            _context= new LuyenTapContext();
        }
        // Viết các phương thức repositories
        public List<Sinhvien> GetAllSinhvien() // Lấy tất cả sinh viên
        {
            return _context.Sinhviens.ToList();
        }
        public bool AddSinhvien(Sinhvien sinhvien)
        {
            try
            {
                _context.Sinhviens.Add(sinhvien);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateSinhvien(Sinhvien sinhvien)
        {
            // Tìm kiếm sinh viên cần sửa theo giá trị được truyền vào
            // giá trị này được lấy từ form giao diện
            var updateData = _context.Sinhviens.Find(sinhvien.Id);
            try
            {
                updateData.Ten = sinhvien.Ten;
                updateData.Sdt = sinhvien.Sdt;
                updateData.Email = sinhvien.Email;
                updateData.Idtruong = sinhvien.Idtruong;
                _context.Sinhviens.Update(sinhvien);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteSinhvien(Sinhvien sinhvien)
        {
            try
            {
                _context.Sinhviens.Remove(sinhvien);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Sinhvien GetSinhvienById(int id)
        {
            return _context.Sinhviens.Find(id);
        }
    }
}
