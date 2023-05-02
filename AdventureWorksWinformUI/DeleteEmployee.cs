using AdventureWorksLibrary;
using AdventureWorksLibrary.Models;
using AdventureWorksLibrary.Models.DropDowns;
using AdventureWorksLibrary.SqlDataAccess;
using AdventureWorksLibrary.Validators;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureWorksWinformUI
{
    public partial class DeleteEmployee : Form
    {
        List<EmployeeFullNameModel> FullNameList = new List<EmployeeFullNameModel>();
        public DeleteEmployee()
        {
            InitializeComponent();

            if (Login.role != "Administrator")
            {
                deleteEmployeeButton.Enabled = false;
            }

            WireUpLists();
        }

        private void WireUpLists()
        {
            employeeFullNameComboBox.Items.Add("");
            employeeFullNameComboBox.SelectedIndex= 0;

            DataAccess dbEmployeeFullName = new DataAccess();

            FullNameList = dbEmployeeFullName.GetNonSalesEmployeeFullName();

            foreach (EmployeeFullNameModel EmployeeFullName in FullNameList)
            {
                employeeFullNameComboBox.Items.Add(EmployeeFullName.FullName);
            }
        }

        private void employeeFullNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deleteEmployeeButton_Click(object sender, EventArgs e)
        { 
            string name = employeeFullNameComboBox.SelectedItem.ToString();

            var confirmResult = MessageBox.Show($"Are You Sure You Want To Delete {name}??",
                         "Confirm Delete!!",
                         MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    string stateProvinceID = employeeFullNameComboBox.SelectedItem.ToString();

                    DataAccess db = new DataAccess();

                    DeleteNonSalesEmployeeModel Employee = new DeleteNonSalesEmployeeModel();
                    Employee.Name = employeeFullNameComboBox.SelectedItem.ToString();

                    DeleteNonSalesEmployeeValidators validator = new DeleteNonSalesEmployeeValidators();

                    ValidationResult result = validator.Validate(Employee);

                    if (result.IsValid == false)
                    {
                        foreach (ValidationFailure failure in result.Errors)
                        {
                            MessageBox.Show(failure.ErrorMessage);
                            return;
                        }
                    }

                    db.DeleteEmployee(Employee);

                    employeeFullNameComboBox.Items.Clear();

                    WireUpLists();

                    MessageBox.Show("Success!");
                }

                catch (SqlException exception)
                {
                    MessageBox.Show("There was an error when performing this operation.\nPlease verify that all entered information is correct.\nCheck the database table DB_Errors for more information.");
                }
            }
            else
            {
                return;
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard form = new Dashboard();
            form.ShowDialog();
        }
    }
}