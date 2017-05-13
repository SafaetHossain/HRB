using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRB.Entity
{
    public class Human
    {
        private string  name,fName,mName,education,gender,phone,address,job,marital,property,polities;
        private int age, child;

        public string Name
        {
            set { this.name = value; }
            get { return name; }
        }
        public string FatherName
        {
            set { this.fName = value; }
            get { return fName; }
        }
        public string MotherName
        {
            set { this.mName = value; }
            get { return mName; }
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
        public string Gender
        {
            set { this.gender = value; }
            get { return gender; }
        }
        public string Job
        {
            set { this.job = value; }
            get { return job; }
        }
        public string Marital
        {
            set { this.marital = value; }
            get { return marital; }
        }
        public string Property
        {
            set { this.property = value; }
            get { return property; }
        }
        public string Polities
        {
            set { this.polities = value; }
            get { return polities; }
        }
        public string Education
        {
            set { this.education = value; }
            get { return education; }
        }
        public int Child
        {
            set { this.child = value; }
            get { return child; }
        }
        public int Age
        {
            set { this.age = value; }
            get { return age; }
        }
    }
}
