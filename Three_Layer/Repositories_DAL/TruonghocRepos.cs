using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Three_Layer.Models;

namespace Three_Layer.Repositories_DAL
{
    internal class TruonghocRepos
    {
        LuyenTapContext _context = new LuyenTapContext();
        public TruonghocRepos()
        {

        }
        public List<TruongHoc> GetALl()
        {
            return _context.TruongHocs.ToList();
        }

    }
}
