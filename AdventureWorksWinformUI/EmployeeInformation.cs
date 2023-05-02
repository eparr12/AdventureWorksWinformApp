using AdventureWorksLibrary;
using AdventureWorksLibrary.Models;
using AdventureWorksLibrary.Models.DropDowns;
using AdventureWorksLibrary.SqlDataAccess;
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
    public partial class employeeInformation : Form
    {
        List<EmployeeFullNameModel> FullName = new List<EmployeeFullNameModel>();
        public employeeInformation()
        {
            InitializeComponent();

            WireUpLists();
        }

        private void WireUpLists()
        {
            employeeInformationComboBox.Items.Add("");
            employeeInformationComboBox.SelectedIndex= 0;

            DataAccess dbEmployeeFullName = new DataAccess();

            FullName = dbEmployeeFullName.GetAnyEmployeeFullName();

            foreach (EmployeeFullNameModel EmployeeFullName in FullName)
            {
                employeeInformationComboBox.Items.Add(EmployeeFullName.FullName);
            }
        }

        private void employeeFullNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addNonSalesEmployeeButton_Click(object sender, EventArgs e)
        {
            try
            {
                string employeeFullName = employeeInformationComboBox.SelectedItem.ToString();
                if (string.IsNullOrEmpty(employeeFullName))
                {
                    MessageBox.Show("Must Select A Value For Employee Name.");
                    return;
                }

                employeeInformationListView.Items.Clear();
                employeeInformationListView2.Items.Clear();
                employeeInformationListView3.Items.Clear();
                employeeInformationListView4.Items.Clear();
                employeeInformationListView5.Items.Clear();
                employeeInformationListView6.Items.Clear();
                employeeInformationListView7.Items.Clear();

                List<NonSalesEmployeeInformationModel> EmployeeInformation = new List<NonSalesEmployeeInformationModel>();

                DataAccess dbEmployeeInformation = new DataAccess();

                EmployeeInformation = dbEmployeeInformation.GetEmployeeInformation(employeeInformationComboBox.SelectedItem.ToString());

                foreach (NonSalesEmployeeInformationModel Employee in EmployeeInformation)
                {
                    ListViewItem item = new ListViewItem(Employee.PersonID.ToString());
                    item.SubItems.Add(Employee.PersonType);
                    item.SubItems.Add(Employee.SocialSecurityNumber);
                    item.SubItems.Add(Employee.LoginID);
                    employeeInformationListView.Items.Add(item);

                    ListViewItem item2 = new ListViewItem(Employee.EmailAddress);
                    item2.SubItems.Add(Employee.PhoneNumber);
                    item2.SubItems.Add(Employee.PhoneNumberType);
                    item2.SubItems.Add(Employee.AddressLine1);
                    employeeInformationListView2.Items.Add(item2);

                    ListViewItem item3 = new ListViewItem(Employee.City);
                    item3.SubItems.Add(Employee.StateOrProvince);
                    item3.SubItems.Add(Employee.PostalCode);
                    item3.SubItems.Add(Employee.Country);
                    employeeInformationListView3.Items.Add(item3);

                    ListViewItem item4 = new ListViewItem(Employee.BirthDate.ToString());
                    item4.SubItems.Add(Employee.MaritalStatus);
                    item4.SubItems.Add(Employee.Gender);
                    item4.SubItems.Add(Employee.HireDate.ToString());
                    employeeInformationListView4.Items.Add(item4);

                    ListViewItem item5 = new ListViewItem(Employee.JobGroup);
                    item5.SubItems.Add(Employee.JobDepartment);
                    item5.SubItems.Add(Employee.JobTitle);
                    item5.SubItems.Add(Employee.ShiftNumber);
                    employeeInformationListView5.Items.Add(item5);

                    ListViewItem item6 = new ListViewItem(Employee.ShiftName);
                    item6.SubItems.Add(Employee.HourlyPayRate.ToString());
                    item6.SubItems.Add(Employee.PayFrequency);
                    item6.SubItems.Add(Employee.VacationHours.ToString());
                    employeeInformationListView6.Items.Add(item6);

                    ListViewItem item7 = new ListViewItem(Employee.SickLeaveHours.ToString());
                    item7.SubItems.Add(Employee.SalesTerritory);
                    item7.SubItems.Add(Employee.Currency);
                    employeeInformationListView7.Items.Add(item7);
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show("There was an error when performing this operation.\nPlease verify that all entered information is correct.\nCheck the database table DB_Errors for more information.");
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