using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp
{
    internal class Staff : Person
    {
        public Staff(string FirstName, string LastName) : base(FirstName, LastName)
        {
        }

        public int EmpID { get; set; }

        public override string GetDetails()
        {
            return GetFullName() + EmpID.ToString();
        }

    }
}
