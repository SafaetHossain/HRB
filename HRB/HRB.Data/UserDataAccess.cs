using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRB.Entity;
using System.Data.SqlClient;

namespace HRB.Data
{
    public class UserDataAccess
    {
        public int Add(User user)
        {
            string query = string.Format("INSERT INTO UserId (Name,Phone,Address,Education,Password) VALUES('{0}','{1}','{2}','{3}','123')",user.Name,user.Phone,user.Address,user.Education);
            return DataAccess.ExecuteQuery(query);
        }
        public int update(User user)
        {
            string query = string.Format("UPDATE UserId SET Name ='{1}',Address = '{2}',Education = '{3}' WHERE Phone = '{0}'",user.Phone, user.Name, user.Address, user.Education);
            return DataAccess.ExecuteQuery(query);
        }
        public int UpdatePassword(string phone, string password)
        {
            string query = "UPDATE UserId SET Password ='" + password + "' WHERE Phone = '" + phone + "'";
            return DataAccess.ExecuteQuery(query);
        }
        public List <User> GetAllByPhone(string phone)
        {
            string query = "SELECT Name,Phone,Address,Education,Password from UserId where Phone ='" + phone + "'";
            SqlDataReader reader = DataAccess.GetData(query);
            User user = null;

            user = new User();
            List <User> userList = new List <User> ();
            while (reader.Read())
            {
                user.Phone = reader["Phone"].ToString();
                user.Name = reader["Name"].ToString();
                user.Address = reader["Address"].ToString();
                user.Education = reader["Education"].ToString();
                user.Password = reader["Password"].ToString();

                userList.Add(user);
            }
            return userList;
        }
    }
}
