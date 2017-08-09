using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRB.Entity;
using HRB.Data;

namespace HRB.Core
{
    public class HumanServices
    {
        private static HumanDataAccess humanDataAccess = null;

        public HumanServices()
        {
            if (HumanServices.humanDataAccess == null)
            {
                HumanServices.humanDataAccess = new HumanDataAccess();
            }
        }
        public int Add(Human human)
        {
            return HumanServices.humanDataAccess.Add(human);
        }

        public int Remove(string id)
        {
            return HumanServices.humanDataAccess.Remove(id);
        }

        //public int Edit(Human human)
        //{
        //    return HumanServices.humanDataAccess.Edit(human);
        //}

        public int UpdatePassword(string id, string password)
        {
            return HumanServices.humanDataAccess.UpdatePassword(id, password);
        }
        //public List<Human> GetAll()
        //{
        //    return HumanServices.humanDataAccess.GetAll();
        //}

        //public List<Human> EmployeeLogIn(string employeeId)
        //{

        //    return HumanServices.humanDataAccess.employeeLogIn(employeeId);
        //}

        //public List<Human> GetByName(string name)
        //{
        //    return HumanServices.humanDataAccess.GetAllSortedByName(name);
        //}
    }
}
