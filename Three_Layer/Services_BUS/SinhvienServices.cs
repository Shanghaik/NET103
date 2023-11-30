using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Three_Layer.Models;
using Three_Layer.Repositories_DAL;

namespace Three_Layer.Services_BUS
{
    internal class SinhvienServices
    {
        SinhvienRepos _repos = new SinhvienRepos();
        public SinhvienServices()
        {
            _repos = new SinhvienRepos(); // Không khởi tạo sẽ bị null
        }
        public List<Sinhvien> GetAll()
        {
            return _repos.GetAllSinhvien();
        }
        public string ThemSinhvien(string ten, string email, string sdt, int idtruong)
        {
            Sinhvien sv = new Sinhvien();
            sv.Ten = ten;
            sv.Email = email;
            sv.Sdt = sdt;
            sv.Idtruong = idtruong;
            if (_repos.AddSinhvien(sv))
            {
                return "Thêm sinh viên thành công!";
            }
            else return "Thêm thất bại, mời kiểm tra lại thông tin";
        }
        public string SuaSinhvien(string ten, string email, string sdt, int idtruong)
        {
            Sinhvien sv = new Sinhvien();
            sv.Ten = ten;
            sv.Email = email;
            sv.Sdt = sdt;
            sv.Idtruong = idtruong;
            if (_repos.UpdateSinhvien(sv))
            {
                return "Sửa sinh viên thành công!";
            }
            else return "Sửa thất bại, mời kiểm tra lại thông tin";
        }
        public string XoaSinhvien(int idtruong)
        {
            Sinhvien sv = _repos.GetSinhvienById(idtruong); 
            if (_repos.DeleteSinhvien(sv))
            {
                return "Xóa sinh viên thành công!";
            }
            else return "Xóa thất bại, sinh viên vẫn phải đi học";
        }
        public List<Sinhvien> TimKiemSinhvien(string data)
        {
            // data này có thể là tên, email, sdt,...
            // câu lệnh chung để tìm kiếm
            var allSV = GetAll(); // lấy tất cả sinh viên
            var result = allSV.Where(p=>p.Ten.Contains(data));// Tên chứa data
            var result1 = allSV.Where(p => p.Email.Contains(data));// Email chứa data
            var result2 = allSV.Where(p => p.Sdt.Contains(data));// SDT chứa data
            var result3 = allSV.Where(p => p.Ten.Contains(data) || p.Email.Contains(data));// Tên hoặc email chứa data 
            var result4 = allSV.Where(p => p.Ten == data || p.Email == data);// Tên hoặc email bằng data
            var result5 = allSV.Where(p => p.Ten.StartsWith(data) || p.Email.StartsWith(data)); // Tên hoặc email bắt đầu bởi data
            return result3.ToList();
        }
    }
}
