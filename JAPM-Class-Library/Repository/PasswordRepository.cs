using JAPM.ClassLibrary.Models;
using JAPM.ClassLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAPM_Class_Library.Repository
{
    public class PasswordRepository : IPasswordRepository

    {
        public UsernameAndPassword Create(string appName, string userName, string password)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public UsernameAndPassword Read(int id)
        {
            throw new NotImplementedException();
        }

        public List<UsernameAndPassword> ReadAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, string userName, string password)
        {
            throw new NotImplementedException();
        }
    }
}
