using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Three_Layer.Repositories_DAL;

namespace Three_Layer.Services_BUS
{
    internal class TruongServices
    {
        TruonghocRepos repo = new TruonghocRepos();
        public TruongServices() { }
        public List<int> GetAllId() // Lấy tất cả ID trường
        {
            List<int> ids = new List<int>();    
            foreach(var i in repo.GetALl())
            {
                ids.Add(i.Id);
            }
            return ids; 
        }
    }
}
