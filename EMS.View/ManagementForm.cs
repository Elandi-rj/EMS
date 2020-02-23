using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EMS.Entity;
using EMS.Logic;

namespace EMS.View
{
    public partial class ManagementForm : Form
    {
        EmployeeService service = new EmployeeService();
        
        //form methods
        private void RefreshHours(int id)
        {
            State<List<EmpHours>> emphourslist = service.ListHours(id);
            dgvHours.DataSource = emphourslist.Data;
        }

        private void RefreshList()
        {
            State<List<Employee>> Emplist = service.ListEmployees();

            listviewEmployees.Items.Clear();
            if (Emplist.StateResult == StateEnum.Success)
            {
                foreach (var item in Emplist.Data)
                {

                    listviewEmployees.Items.Add(new ListViewItem(new string[] { item.EmployeeID.ToString(), item.EmployeeFName + " " + item.EmployeeLName }));
                }
            }
            else { MessageBox.Show("Could not connect to database");}
        }

        private void RefreshEmailList(string email)
        {
            State<List<Employee>> empEmail = service.ListEmployeesByEmail(email);

            listviewEmployees.Items.Clear();
            if (empEmail.StateResult == StateEnum.Success)
            {

                foreach (var item in empEmail.Data)
                {

                    
                    listviewEmployees.Items.Add(new ListViewItem(new string[] { item.EmployeeID.ToString(), item.EmployeeEmail}));
                }
            }
            else { MessageBox.Show("Could not connect to database"); }

        }

        public ManagementForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRecordHours_Click(object sender, EventArgs e)
        {
            //read the input
            EmpHours emp = new EmpHours();
            if (lbliD.Text != "")
            {
                try
                {
                    emp.EmployeeID = int.Parse(lbliD.Text);
                    emp.EmployeeWorkDate = dtpWorkDate.Value;
                    emp.EmployeeHours = float.Parse(txtHours.Text);
                    //call the service
                    StateEnum result = service.SaveEmployeeHours(emp);

                    //check the result
                    switch (result)
                    {
                        case StateEnum.Fail:
                            MessageBox.Show("Cannot save employee hours");
                            break;
                        case StateEnum.Success:
                            MessageBox.Show("Employee hours added");
                            break;
                    }
                }
                catch
                {
                    MessageBox.Show("Please use a number");
                }
                try { RefreshHours(int.Parse(lbliD.Text)); } catch { }
            }
            else
            {
                MessageBox.Show("Please select an employee in the list on the left first");
                errorProvider1.SetError(lbliD, "No employee Id has been set yet");
            }
        }

        private void btnSave_Click(object sender, EventArgs e) //save employees to the database
        {
            if (lbliD.Text != "")
            {
                //read the input
                Employee emp = new Employee();
                emp.EmployeeID = int.Parse(lbliD.Text);
                emp.EmployeeFName = txtFName.Text;
                emp.EmployeeLName = txtLName.Text;
                emp.EmployeeEmail = txtEmail.Text;
                emp.EmployeeDOB = dtpDOB.Value;
                emp.EmployeePhone = txtPhone.Text;

                //call the service

                StateEnum result = service.UpdateEmployee(emp);

                //check the result
                switch (result)
                {
                    case StateEnum.Fail:
                        MessageBox.Show("Cannot update employee");
                        break;
                    case StateEnum.Success:
                        MessageBox.Show("Employee updated");
                        break;
                }
                RefreshList();
            }
            else
            {
                MessageBox.Show("Please select an employee in the list on the left first");
                errorProvider1.SetError(lbliD, "No employee Id has been set yet");
            }
        }

        private void ManagementForm_Load(object sender, EventArgs e)
        {
            RefreshList();
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
            try { RefreshHours(int.Parse(lbliD.Text)); } catch { }
        } 
        


        private void txtSearchEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchEmail.Text != "")
            {
                listviewEmployees.Columns[1].Text = "Email";
                RefreshEmailList(txtSearchEmail.Text);
            }
            else
            {
                listviewEmployees.Columns[1].Text = "Full Name";
                RefreshList();
            }
        }

        private void listviewEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = listviewEmployees.SelectedItems[0];

                lbliD.Text = item.Text;
                //----parse found employees information to the text fields----

                //call the service
                State<Employee> foundEmp = service.FindEmployeeById(int.Parse(item.Text));

                //check the result
                if (foundEmp.StateResult == StateEnum.Fail)
                {
                    MessageBox.Show("Employee not found");
                }
                else
                {
                    txtFName.Text = foundEmp.Data.EmployeeFName;
                    txtLName.Text = foundEmp.Data.EmployeeLName;
                    txtEmail.Text = foundEmp.Data.EmployeeEmail;
                    txtPhone.Text = foundEmp.Data.EmployeePhone;
                    dtpDOB.Text = foundEmp.Data.EmployeeDOB.ToString();
                    RefreshHours(int.Parse(lbliD.Text));
                }
                errorProvider1.SetError(lbliD, null);
            }
            catch { }
        }
    }
}
