using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Entity
{
    public class EmpHours
    {
        //props
        public int EmployeeID { get; set; }
        //public int EmployeeHoursID { get; set; }
        public DateTime EmployeeWorkDate { get; set; }
        public float EmployeeHours { get; set; }


        //methods
        public override string ToString()
        {
            return EmployeeID + "," + EmployeeWorkDate + "," + EmployeeHours; //+ "," + EmployeeHoursID;
        }
    }
}
