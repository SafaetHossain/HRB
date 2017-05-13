using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRB.Data;
using HRB.Entity;

namespace HRB.Core
{
    public class UserServices
    {
        private static UserDataAccess userDataAccess = null;

        public UserServices()
        {
            if (UserServices.userDataAccess == null)
            {
                UserServices.userDataAccess = new UserDataAccess();
            }
        }
        public int Add(User user)
        {
            return UserServices.userDataAccess.Add(user);
        }
        public int update(User user)
        {
            return UserServices.userDataAccess.update(user);
        }
        public int UpdatePassword(string phone, string password)
        {
            return UserServices.userDataAccess.UpdatePassword(phone, password);
        }
        public List <User> GetAllByPhone(string phone)
        {

            return UserServices.userDataAccess.GetAllByPhone(phone);
        }
    }
}
