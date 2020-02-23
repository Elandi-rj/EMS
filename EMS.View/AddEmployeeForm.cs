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
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //read the input
            Employee emp = new Employee();
            //emp.EmployeeID = int.Parse(txtID.Text);
            emp.EmployeeFName = txtFName.Text;
            emp.EmployeeLName = txtLName.Text;
            emp.EmployeeEmail = txtEmail.Text;
            emp.EmployeeDOB = dtpDOB.Value;
            emp.EmployeePhone = txtPhone.Text;

            //call the service
            EmployeeService service = new EmployeeService();
            StateEnum result = service.SaveEmployee(emp);

            //check the result
            switch (result)
            {
                case StateEnum.Fail:
                    MessageBox.Show("Cannot add employee");
                    break;
                case StateEnum.Success:
                    MessageBox.Show("Employee added");
                    break;
            }
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            ManagementForm ms = new ManagementForm();
            ms.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFName.Text = "";
            txtLName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
        }
    }
}
