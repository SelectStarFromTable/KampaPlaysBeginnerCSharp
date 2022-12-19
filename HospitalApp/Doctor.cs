using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp
{
    internal class Doctor : Staff, IPaging
    {
        public Doctor(string FirstName, string LastName, int EmpID, string Speciality) : base(FirstName, LastName, EmpID)
        {
            this.Speciality = Speciality;
        }

        public string Speciality { get; set; }

        public override string GetDetails()
        {
            return EmpID.ToString() + GetFullName() + Speciality;
        }

        public void Page()
        {
            Console.WriteLine($"Paging {this.Speciality} Specialist, Doctor {base.GetFullName()}");
        }
    }
}
