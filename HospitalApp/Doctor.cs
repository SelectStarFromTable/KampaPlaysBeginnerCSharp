using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp
{
    internal class Doctor : Staff
    {
        public Doctor(string FirstName, string LastName) : base(FirstName, LastName)
        {
        }

        public string Speciality { get; set; }

        public override string GetDetails()
        {
            return GetFullName() + EmpID.ToString() + Speciality;
        }
    }
}
