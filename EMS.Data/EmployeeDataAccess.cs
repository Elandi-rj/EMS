using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient; //SQL server database  - 1.Select the SQL provider
using EMS.Entity; //Employee

namespace EMS.Data
{
    public class EmployeeDataAccess
    {
        //string DataSource = @"Data Source=DESKTOP-SL52T4E\SQLEXPRESS;Initial Catalog=EmployeeManagementSystem;Integrated Security=True"; //Laptop
        public string DataSource = @"Data Source=DANSPC\SQLEXPRESS;Initial Catalog=EmployeeManagementSystem;Integrated Security=True"; //Desktop
        //string DataSource = @"Data Source=PE00A001006DE10\SQLEXPRESS;Initial Catalog=EmployeeManagementSystem;Integrated Security=True"; //TafePC

        public void ChangeDataSource()
        {
            SqlConnection conn = new SqlConnection(DataSource + ";Connection Timeout=1");
            try
            {
                conn.Open();
                conn.Close();
            }
            catch
            {
                DataSource = @"Data Source=DANSPC\SQLEXPRESS;Initial Catalog=EmployeeManagementSystem;Integrated Security=True"; // Desktop
            }
        }


        public void InsertEmployee(Employee emp)
        {
            
            //2.Create, setup, and open a connection object
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = DataSource;
            conn.Open();

            //3.Create a command object
            SqlCommand cmd = new SqlCommand("sp_insert_Employee", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@FirstName", emp.EmployeeFName));
            cmd.Parameters.Add(new SqlParameter("@LastName", emp.EmployeeLName));
            cmd.Parameters.Add(new SqlParameter("@Email", emp.EmployeeEmail));
            cmd.Parameters.Add(new SqlParameter("@DOB", emp.EmployeeDOB));
            cmd.Parameters.Add(new SqlParameter("@Phone", emp.EmployeePhone));

            //4.Execute the command
            cmd.ExecuteNonQuery();

            //5.Handle the results

            //6. Close the connection
            conn.Close();
        }
        public void InsertHours(EmpHours empHours)
        {
            //2.Create, setup, and open a connection object
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = DataSource;
            conn.Open();

            //3.Create a command object
            SqlCommand cmd = new SqlCommand("sp_insert_EmpHours", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@EmpID", empHours.EmployeeID));
            cmd.Parameters.Add(new SqlParameter("@WorkDate", empHours.EmployeeWorkDate));
            cmd.Parameters.Add(new SqlParameter("@Hours", empHours.EmployeeHours));

            //4.Execute the command
            cmd.ExecuteNonQuery();

            //5.Handle the results

            //6. Close the connection
            conn.Close();
        }
        public void UpdateEmployee(Employee emp)
        {
            //2.Create, setup, and open a connection object
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = DataSource;
            conn.Open();

            //3.Create a command object
            SqlCommand cmd = new SqlCommand("sp_update_Employee", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@EmpID", emp.EmployeeID));
            cmd.Parameters.Add(new SqlParameter("@FirstName", emp.EmployeeFName));
            cmd.Parameters.Add(new SqlParameter("@LastName", emp.EmployeeLName));
            cmd.Parameters.Add(new SqlParameter("@Email", emp.EmployeeEmail));
            cmd.Parameters.Add(new SqlParameter("@DOB", emp.EmployeeDOB));
            cmd.Parameters.Add(new SqlParameter("@Phone", emp.EmployeePhone));

            //4.Execute the command
            cmd.ExecuteNonQuery();

            //5.Handle the results

            //6. Close the connection
            conn.Close();
        }

        public List<Employee> ListEmployees()
        {
            List<Employee> EmpList = new List<Employee>();
            ChangeDataSource();
            //2.Create, setup, and open a connection object
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = DataSource;
            conn.Open();

            //3.Create a command object
            SqlCommand cmd = new SqlCommand("sp_select_Employee", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            

            //4.Execute the command
            SqlDataReader reader = cmd.ExecuteReader();

            //5.Handle the results
            while (reader.Read())
            {
                Employee emp = new Employee();
                emp.EmployeeID = Convert.ToInt32(reader["EmpID"]);//convert obj to int
                emp.EmployeeFName = Convert.ToString(reader["FirstName"]);
                emp.EmployeeLName = Convert.ToString(reader["LastName"]);
                emp.EmployeeEmail = Convert.ToString(reader["Email"]);
                emp.EmployeeDOB = Convert.ToDateTime(reader["DOB"]);
                emp.EmployeePhone = Convert.ToString(reader["Phone"]);

                EmpList.Add(emp);
            }
            //6. Close the connection
            conn.Close();

            //return array
            return EmpList; 
        }
        
        
        public Employee SelectById(int empID)
        {
            Employee emp = null;

            //2.Create, setup, and open a connection object
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = DataSource;
            conn.Open();

            //3.Create a command object
            SqlCommand cmd = new SqlCommand("sp_select_EmployeeByID", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@EmpID", empID));

            //4.Execute the command
            SqlDataReader reader = cmd.ExecuteReader();

            //5.Handle the results
            while (reader.Read())
            {
                emp = new Employee();
                emp.EmployeeID = Convert.ToInt32(reader["EmpID"]);//convert obj to int
                emp.EmployeeFName = Convert.ToString(reader["FirstName"]);
                emp.EmployeeLName = Convert.ToString(reader["LastName"]);
                emp.EmployeeEmail = Convert.ToString(reader["Email"]);
                emp.EmployeeDOB = Convert.ToDateTime(reader["DOB"]);
                emp.EmployeePhone = Convert.ToString(reader["Phone"]);
            }
            //6. Close the connection
            conn.Close();

            //return array
            return emp;
        }

        public List<EmpHours> ListEmployeeHours(int empID)
        {
            List<EmpHours> EmpHList = new List<EmpHours>();

            //2.Create, setup, and open a connection object
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = DataSource;
            conn.Open();

            //3.Create a command object
            SqlCommand cmd = new SqlCommand("sp_select_EmpHoursByID", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@EmpID", empID));

            //4.Execute the command
            SqlDataReader reader = cmd.ExecuteReader();

            //5.Handle the results
            while (reader.Read())
            {
                EmpHours empH = new EmpHours();
                empH.EmployeeID = Convert.ToInt32(reader["EmpID"]);
                empH.EmployeeWorkDate = Convert.ToDateTime(reader["WorkDate"]);
                empH.EmployeeHours = (float)Convert.ToDouble(reader["Hours"]);

                EmpHList.Add(empH);
            }
            //6. Close the connection
            conn.Close();

            //return array
            return EmpHList;
        }
        public List<Employee> ListByEmail(string email)
        {
            List<Employee> empsEmail = new List<Employee>();

            //2.Create, setup, and open a connection object
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = DataSource;
            conn.Open();

            //3.Create a command object
            SqlCommand cmd = new SqlCommand("sp_select_EmployeeByEmail", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Email", email));

            //4.Execute the command
            SqlDataReader reader = cmd.ExecuteReader();

            //5.Handle the results
            while (reader.Read())
            {
                Employee emp = new Employee();
                emp.EmployeeID = Convert.ToInt32(reader["EmpID"]);//convert obj to int
                emp.EmployeeFName = Convert.ToString(reader["FirstName"]);
                emp.EmployeeLName = Convert.ToString(reader["LastName"]);
                emp.EmployeeEmail = Convert.ToString(reader["Email"]);
                emp.EmployeeDOB = Convert.ToDateTime(reader["DOB"]);
                emp.EmployeePhone = Convert.ToString(reader["Phone"]);

                empsEmail.Add(emp);
            }
            //6. Close the connection
            conn.Close();

            //return array
            return empsEmail;
        }
    }
}
