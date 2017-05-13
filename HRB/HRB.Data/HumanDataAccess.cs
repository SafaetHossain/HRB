using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRB.Entity;
using System.Data.SqlClient;

namespace HRB.Data
{
    public class HumanDataAccess
    {
        //public int Add(Human human)
        //{
        //    string query = string.Format("INSERT INTO Human ([Human Name], Salary, JoinDate, BirthDate, Post, Password, phone) VALUES('{0}', '{1}', {2}, '{3}', '{4}', '{5}', '{6}', '{7}')", Human.HumanId, Human.HumanName, Human.Salary, Human.Joindate, Human.Birthdate, Human.Post, Human.Password, Human.Phone);
        //    return DataAccess.ExecuteQuery(query);
        //}

        public int Remove(string id)
        {
            string query = "DELETE FROM Human WHERE [Human Id] = '" + id + "'";
            return DataAccess.ExecuteQuery(query);
        }

        //public int Edit(Human human)
        //{
        //    string query = string.Format("UPDATE Human SET [Human Name] ='{1}',Salary={2},JoinDate='{3}',BirthDate='{4}',Post='{5}',phone='{6}' WHERE HumanId='{0}'", Human.HumanId, Human.HumanName, Human.Salary, Human.Joindate, Human.Birthdate, Human.Post, Human.Phone);
        //    return DataAccess.ExecuteQuery(query);
        //}

        public int UpdatePassword(string id, string password)
        {
            string query = "UPDATE Human SET Password ='" + password + "' WHERE HumanId = '" + id + "'";
            return DataAccess.ExecuteQuery(query);
        }
        //public List<Human> GetAll()
        //{
        //    string query = "SELECT HumanId, HumanName, Salary, Joindate, Birthdate, Post, Phone FROM Human";
        //    SqlDataReader reader = DataAccess.GetData(query);

        //    Human Human = null;
        //    List<Human> HumanList = new List<Human>();
        //    while (reader.Read())
        //    {
        //        human = new Human(reader["HumanId"].ToString());
        //        Human.HumanName = reader["HumanName"].ToString();
        //        Human.Salary = Convert.ToInt32(reader["Salary"].ToString());
        //        Human.Joindate = reader["Joindate"].ToString();
        //        Human.Birthdate = reader["Birthdate"].ToString();
        //        Human.Post = reader["Post"].ToString();
        //        Human.Phone = reader["Phone"].ToString();

        //        HumanList.Add(Human);
        //    }
        //    return HumanList;
        //}

        //public List<Human> GetAllByName(string HumanName)
        //{
        //    string query = "SELECT HumanId, HumanName, Salary, Joindate, Birthdate, Post, Phone FROM Human where HumanName='" + HumanName + "'";
        //    SqlDataReader reader = DataAccess.GetData(query);

        //    Human Human = null;
        //    List<Human> HumanList = new List<Human>();
        //    while (reader.Read())
        //    {
        //        Human = new Human(reader["HumanId"].ToString());
        //        Human.HumanName = reader["HumanName"].ToString();
        //        Human.Salary = Convert.ToInt32(reader["Salary"].ToString());
        //        Human.Joindate = reader["Joindate"].ToString();
        //        Human.Birthdate = reader["Birthdate"].ToString();
        //        Human.Post = reader["Post"].ToString();
        //        Human.Phone = reader["Phone"].ToString();
        //        HumanList.Add(Human);
        //    }
        //    return HumanList;
        //}

        //public List<Human> HumanLogIn(string HumanId)
        //{
        //    string query = "SELECT Password,Post from Human where HumanId ='" + HumanId + "'";
        //    SqlDataReader reader = DataAccess.GetData(query);
        //    Human Human = null;

        //    human = new Human();
        //    List<Human> humanList = new List<Human>();
        //    while (reader.Read())
        //    {
        //        Human = new Human();
        //        Human.Password = reader["Password"].ToString();
        //        Human.Post = reader["Post"].ToString();

        //        HumanList.Add(Human);
        //    }
        //    return HumanList;
        //}
    }
}
