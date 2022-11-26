using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp
{
    internal class Patient : Person
    {
        public Patient(string FirstName, string LastName) : base(FirstName, LastName)
        {
        }

        public int RoomNumber { get; set; }

        public override string GetDetails()
        {
            return GetFullName() + RoomNumber.ToString();

        }
    }
}
