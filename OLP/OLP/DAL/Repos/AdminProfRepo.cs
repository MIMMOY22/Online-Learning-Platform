using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AdminProfRepo : Repo, IRepo<Admin, bool, int>, IAdminAuth
    {
        public Admin AuthenticateAdmin(string username, string password)
        {
            var data = (from t in db.Admins where t.username == username && t.password == password select t).SingleOrDefault();
            return data;
        }
        public bool create(Admin obj)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool update(Admin obj)
        {
            throw new NotImplementedException();
        }

        public Admin view(int id)
        {
            throw new NotImplementedException();
        }

        public List<Admin> viewAll()
        {
            throw new NotImplementedException();
        }
    }
}
