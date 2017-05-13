using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRB.Entity;
using HRB.Data;

namespace HRB.Core
{
    public class EmployeeServices
    {
        private static HumanDataAccess humanDataAccess = null;

        public EmployeeServices()
        {
            if (EmployeeServices.humanDataAccess == null)
            {
                EmployeeServices.humanDataAccess = new HumanDataAccess();
            }
        }
        //public int Add(Human human)
        //{
        //    return EmployeeServices.humanDataAccess.Add(human);
        //}

        public int Remove(string id)
        {
            return EmployeeServices.humanDataAccess.Remove(id);
        }

        //public int Edit(Human human)
        //{
        //    return EmployeeServices.humanDataAccess.Edit(human);
        //}

        public int UpdatePassword(string id, string password)
        {
            return EmployeeServices.humanDataAccess.UpdatePassword(id, password);
        }
        //public List<Human> GetAll()
        //{
        //    return EmployeeServices.humanDataAccess.GetAll();
        //}

        //public List<Human> EmployeeLogIn(string employeeId)
        //{

        //    return EmployeeServices.humanDataAccess.employeeLogIn(employeeId);
        //}

        //public List<Human> GetByName(string name)
        //{
        //    return EmployeeServices.humanDataAccess.GetAllSortedByName(name);
        //}
    }
}
