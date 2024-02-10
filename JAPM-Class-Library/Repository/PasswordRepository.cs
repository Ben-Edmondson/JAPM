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
        private static Random rnd = new Random();

        private List<UsernameAndPassword> _accountsAndPasswords = new List<UsernameAndPassword>()
        {
            new UsernameAndPassword(){Id = rnd.Next(1111,10000), Application = "Netflix", Username = "ben.edmondson99@gmail.com", Password = "DummyPassword"}
        };
        public UsernameAndPassword Create(string appName, string userName, string password)
        {
            UsernameAndPassword createNewSave = new UsernameAndPassword()
            {
                Id = rnd.Next(1111, 10000),
                Application = "Facebook",
                Username = "ben.edmondson99@gmail.com",
                Password = "DummyPassword"
            };
            return createNewSave;
        }

        public bool Delete(int id)
        {
            if (_accountsAndPasswords.Exists(x => x.Id == id) == true)
            {
                _accountsAndPasswords.Remove(_accountsAndPasswords.Find(x => x.Id == id));
                return true;
            }
            return false;
        }

        public UsernameAndPassword Read(int id)
        {
            var accountToRead = _accountsAndPasswords.Find(x => x.Id == id);
            return accountToRead;
        }

        public List<UsernameAndPassword> ReadAll()
        {
            return _accountsAndPasswords;
        }

        public bool Update(int id, string appName, string userName, string password)
        {
            foreach (var account in _accountsAndPasswords)
            {
                if (account.Id == id)
                {
                    if (String.IsNullOrEmpty(appName) == false)
                    {
                        account.Application = appName;
                    }
                    if (String.IsNullOrEmpty(userName) == false)
                    {
                        account.Username = userName;
                    }
                    if (String.IsNullOrEmpty(password) == false)
                    {
                        account.Password = password;
                    }
                    return true;
                }
            }
            return false;
        }
    }
}
