using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRB.Entity
{
    public class User
    {
        private string name, phone, address, education, password;

        public string Name
        {
            set { this.name = value; }
            get { return name; }
        }
        public string Phone
        {
            set { this.phone = value; }
            get { return phone; }
        }
        public string Address
        {
            set { this.address = value; }
            get { return address; }
        }
        public string Education
        {
            set { this.education = value; }
            get { return education; }
        }
        public string Password
        {
            set { this.password = value; }
            get { return password; }
        }
    }
}
