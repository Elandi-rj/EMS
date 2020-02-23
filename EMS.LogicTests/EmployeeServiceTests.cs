using Microsoft.VisualStudio.TestTools.UnitTesting;
using EMS.Logic; //EmployeeService
using EMS.Entity; //Employees
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //sql

namespace EMS.Logic.Tests
{

    [TestClass()]
    public class EmployeeServiceTests
    {
        EmployeeService service = new EmployeeService();

        [TestMethod()]
        public void FindAllEmployees_ValidNotEmpty()
        {
            //Arrange
            StateEnum expectedStatus = StateEnum.Success;

            //Act
            State<List<Employee>> actualResult = service.ListEmployees();

            //Assert
            Assert.AreEqual(expectedStatus, actualResult.StateResult);
            Assert.IsNotNull(actualResult.Data);
            Assert.AreNotEqual(0, actualResult.Data.Count);
        }

        [TestMethod()]
        public void SaveEmployee_InvalidNullValue()
        {
            //Arrange
            Employee empData = null;
            StateEnum expectedResult = StateEnum.Fail;

            //Act
            StateEnum actualResult = service.SaveEmployee(empData);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void FindEmployeeById_ValidTest1() //assuming employee with id 1 and name james heith exists
        {
            //Arrange
            int id = 1;
            StateEnum expectedStatus = StateEnum.Success;
            string expectedFName = "James";
            string expectedLName = "Heith";

            //add more expected values later

            //Act
            State<Employee> actualResult = service.FindEmployeeById(id);

            //Assert
            Assert.AreEqual(expectedStatus, actualResult.StateResult);
            Assert.AreEqual(expectedFName, actualResult.Data.EmployeeFName);
            Assert.AreEqual(expectedLName, actualResult.Data.EmployeeLName);
        }

        [TestMethod]
        public void FindEmployeeById_ValidTest2() //assuming there is no employee with id of 10000
        {
            //Arrange
            StateEnum expectedStatus = StateEnum.Success;
            int id = 10000;

            //Act
            State<Employee> actualResult = service.FindEmployeeById(id);

            //Assert
            Assert.AreEqual(expectedStatus, actualResult.StateResult);
            Assert.IsNull(actualResult.Data);
        }
        [TestMethod]
        public void UpdateEmployee_InvalidNullValue()
        {
            //Arrange
            StateEnum expectedStatus = StateEnum.Fail;

            //Act
            Employee e = null;

            StateEnum actualResult = service.UpdateEmployee(e);

            //Assert
            Assert.AreEqual(expectedStatus, actualResult);

        }

        [TestMethod]
        public void SaveEmployee_ValidTest1()
        {
            //Arrange
            StateEnum expectedStatus = StateEnum.Success;
            Employee e = new Employee();
            e.EmployeeFName = "FirstName";
            e.EmployeeLName = "LastName";
            e.EmployeeEmail = "test@test.com";
            e.EmployeeDOB = new DateTime(2001, 01, 01);
            e.EmployeePhone = "1234";
            //Act
            StateEnum actualResult = service.SaveEmployee(e);

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=PE00A001006DE10\SQLEXPRESS;Initial Catalog=EmployeeManagementSystem;Integrated Security=True"; //TafePC
            //conn.ConnectionString = @"Data Source=DANSPC\SQLEXPRESS;Initial Catalog=EmployeeManagementSystem;Integrated Security=True"; //Desktop
            conn.Open();
            //find latest added employee which should be the test employee "e" added above
            SqlCommand cmd = new SqlCommand("select * from Employees where EmpID = (SELECT MAX(EmpID) FROM Employees)", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Employee emp = null;
            if (reader.Read())
            {
                emp = new Employee();
                emp.EmployeeFName = Convert.ToString(reader["FirstName"]);
                emp.EmployeeLName = Convert.ToString(reader["LastName"]);
                emp.EmployeeEmail = Convert.ToString(reader["Email"]);
                emp.EmployeeDOB = Convert.ToDateTime(reader["DOB"]);
                emp.EmployeePhone = Convert.ToString(reader["Phone"]);
            }
            conn.Close();

            conn.Open();
            //delete the last test employee added "e"
            SqlCommand cmdel = new SqlCommand("DELETE FROM Employees WHERE EmpID = (SELECT MAX(EmpID) FROM Employees)", conn);
            cmdel.ExecuteNonQuery();
            conn.Close();

            //Assert
            Assert.AreEqual(expectedStatus, actualResult);
            Assert.AreEqual(e.EmployeeFName, emp.EmployeeFName);
            Assert.AreEqual(e.EmployeeLName, emp.EmployeeLName);
            Assert.AreEqual(e.EmployeeEmail, emp.EmployeeEmail);
            Assert.AreEqual(e.EmployeeDOB, emp.EmployeeDOB);
            Assert.AreEqual(e.EmployeePhone, emp.EmployeePhone);
        }
    }
}