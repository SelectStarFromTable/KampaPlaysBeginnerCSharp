﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp
{
    internal class Staff : Person
    {
        public Staff(string FirstName, string LastName, int EmpID) : base(FirstName, LastName)
        {
            this.EmpID = EmpID;
        }

        public int EmpID { get; set; }

        public override string GetDetails()
        {
            return GetFullName() + "\n" + EmpID.ToString();
        }

    }
}
