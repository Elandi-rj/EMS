using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Entity
{
    public class Employee
    {
        //props
        public int EmployeeID { get; set; }
        public string EmployeeFName { get; set; }
        public string EmployeeLName { get; set; }

        public string EmployeeEmail { get; set; }
        public DateTime EmployeeDOB { get; set; }

        public string EmployeePhone { get; set; }

        //methods
        public override string ToString()
        {
            return EmployeeFName + "," + EmployeeLName + "," +
                EmployeeEmail + "," + EmployeeDOB + "," + EmployeePhone + "," + EmployeeID;
        }
    }
}
