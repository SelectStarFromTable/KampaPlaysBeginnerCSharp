using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp
{
    internal class Nurse : Staff, IPaging
    {
        public Nurse(string FirstName, string LastName) : base(FirstName, LastName)
        {
        }

        public void Page()
        {
            Console.WriteLine($"Paging Nurse {this.GetFullName}");
        }
    }
}
