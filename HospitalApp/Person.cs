using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp
{
    internal abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string FirstName, string LastName)
        {
          this.FirstName = FirstName;
          this.LastName = LastName;
        }

        public string GetFullName()
        {
            return FirstName +  " " + LastName;
        }

        public abstract string GetDetails();
        

    }
}
