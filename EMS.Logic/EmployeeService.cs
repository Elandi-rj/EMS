using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EMS.Entity;
using EMS.Data;

namespace EMS.Logic
{
    public class EmployeeService
    {
        //fields
        private EmployeeDataAccess dao;

        //props

        //cons
        public EmployeeService() {
            dao = new EmployeeDataAccess();
        }

        //methods
        public StateEnum SaveEmployee(Employee emp)
        {
            StateEnum result = StateEnum.Success;
            try
            {
                dao.InsertEmployee(emp);
            }
            catch
            {
                result = StateEnum.Fail;
            }
            return result;
        }
        
        public StateEnum UpdateEmployee(Employee emp)
        {
            StateEnum result = StateEnum.Success;
            try
            {
                dao.UpdateEmployee(emp);
            }
            catch
            {
                result = StateEnum.Fail;
            }
            return result;
        }
        public StateEnum SaveEmployeeHours(EmpHours emp)
        {
            StateEnum result = StateEnum.Success;
            try
            {
                dao.InsertHours(emp);
            }
            catch
            {
                result = StateEnum.Fail;
            }
            return result;
        }

        public State<Employee> FindEmployeeById(int id)
        {
            State<Employee> result = new State<Employee>();
            try
            {
                result.Data = dao.SelectById(id);
                result.StateResult = StateEnum.Success;
            }
            catch
            {
                result.StateResult = StateEnum.Fail;
            }
            return result;
        }

        public State<List<Employee>> ListEmployees()
        {
            State<List<Employee>> result = new State<List<Employee>>();
            try
            {
                result.Data = dao.ListEmployees();
                result.StateResult = StateEnum.Success;
            }
            catch
            {
                result.StateResult = StateEnum.Fail;
            }
            return result;
        }

        public State<List<EmpHours>> ListHours(int id)
        {
            State<List<EmpHours>> result = new State<List<EmpHours>>();
            try
            {
                result.Data = dao.ListEmployeeHours(id);
                result.StateResult = StateEnum.Success;
            }
            catch
            {
                result.StateResult = StateEnum.Fail;
            }
            return result;
        }
        
        public State<List<Employee>> ListEmployeesByEmail(string email)
        {
            State<List<Employee>> result = new State<List<Employee>>();
            try
            {
                result.Data = dao.ListByEmail(email);
                result.StateResult = StateEnum.Success;
            }
            catch
            {
                result.StateResult = StateEnum.Fail;
            }
            return result;
        }
    }
}
