using JAPM.ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAPM.ClassLibrary.Repository
{
    public interface IPasswordRepository
    {
        public UsernameAndPassword Create(string appName, string userName, string password);
        public List<UsernameAndPassword> ReadAll();
        public UsernameAndPassword Read(int id);
        public bool Update(int id, string userName, string password);
        public bool Delete(int id);
        
    }
}
