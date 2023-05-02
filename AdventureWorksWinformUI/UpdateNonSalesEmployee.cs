using AdventureWorksLibrary;
using AdventureWorksLibrary.Models;
using AdventureWorksLibrary.Models.DropDowns;
using AdventureWorksLibrary.SqlDataAccess;
using AdventureWorksLibrary.Validators;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Identity;
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
    public partial class UpdateNonSalesEmployee : Form
    {
        List<EmployeeFullNameModel> FullNameList = new List<EmployeeFullNameModel>();
        List<StateProvinceIDModel> StateProvinceID = new List<StateProvinceIDModel>();
        List<DepartmentIDModel> DepartmentID = new List<DepartmentIDModel>();
        public UpdateNonSalesEmployee()
        {
            InitializeComponent();

            if (Login.role != "Administrator")
            {
                UpdateNonSalesEmployeeButton.Enabled = false;
            }

            WireUpLists();
        }

        private void WireUpLists()
        {
            employeeFullNameComboBox.DataSource = null;

            DataAccess dbEmployeeFullName = new DataAccess();

            FullNameList = dbEmployeeFullName.GetNonSalesEmployeeFullName();

            foreach (EmployeeFullNameModel EmployeeFullName in FullNameList)
            {
                employeeFullNameComboBox.Items.Add(EmployeeFullName.FullName);
            }

            personTypeComboBox.Items.Add("");
            personTypeComboBox.Items.Add("SC");
            personTypeComboBox.Items.Add("IN");
            personTypeComboBox.Items.Add("SP");
            personTypeComboBox.Items.Add("EM");
            personTypeComboBox.Items.Add("VC");
            personTypeComboBox.Items.Add("GC");

            titleComboBox.Items.Add("");
            titleComboBox.Items.Add("Mr.");
            titleComboBox.Items.Add("Mrs.");
            titleComboBox.Items.Add("Ms.");

            suffixComboBox.Items.Add("");
            suffixComboBox.Items.Add("I");
            suffixComboBox.Items.Add("II");
            suffixComboBox.Items.Add("III");
            suffixComboBox.Items.Add("IV");
            suffixComboBox.Items.Add("Jr.");
            suffixComboBox.Items.Add("PhD");
            suffixComboBox.Items.Add("Sr.");

            phoneNumberTypeComboBox.Items.Add("");
            phoneNumberTypeComboBox.Items.Add("Cell");
            phoneNumberTypeComboBox.Items.Add("Home");
            phoneNumberTypeComboBox.Items.Add("Work");

            addressTypeIdComboBox.Items.Add("");
            addressTypeIdComboBox.Items.Add("Archive");
            addressTypeIdComboBox.Items.Add("Billing");
            addressTypeIdComboBox.Items.Add("Home");
            addressTypeIdComboBox.Items.Add("Main Office");
            addressTypeIdComboBox.Items.Add("Primary");
            addressTypeIdComboBox.Items.Add("Shipping");

            maritalStatusComboBox.Items.Add("");
            maritalStatusComboBox.Items.Add("Married");
            maritalStatusComboBox.Items.Add("Single");

            genderComboBox.Items.Add("");
            genderComboBox.Items.Add("Male");
            genderComboBox.Items.Add("Female");

            payFrequencyComboBox.Items.Add("");
            payFrequencyComboBox.Items.Add("Bi-Weekly");
            payFrequencyComboBox.Items.Add("Weekly");

                DataAccess dbStateProvince = new DataAccess();

                StateProvinceID = dbStateProvince.GetStateProvinceID();

                foreach (StateProvinceIDModel Name in StateProvinceID)
                {
                    stateProvinceIDComboBox.Items.Add(Name.Name);
                }

                DataAccess dbDepartment = new DataAccess();

                DepartmentID = dbDepartment.GetDepartmentID();

                foreach (DepartmentIDModel Name in DepartmentID)
                {
                    departmentIdComboBox.Items.Add(Name.Name);
                }
        }
        private void UpdateNonSalesEmployee_Load(object sender, EventArgs e)
        {

        }

        private void employeeInformationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (employeeFullNameComboBox.SelectedItem is not null)
            {

                UpdateNonSalesEmployeeButton.Enabled = true;

                List<UpdateNonSalesEmployeeModel> EmployeeInformation = new List<UpdateNonSalesEmployeeModel>();

                DataAccess dbEmployeeInformation = new DataAccess();

                EmployeeInformation = dbEmployeeInformation.GetUpdatedEmployeeInformation(employeeFullNameComboBox.SelectedItem.ToString());

                foreach (UpdateNonSalesEmployeeModel Employee in EmployeeInformation)
                {
                    personTypeComboBox.SelectedItem = Employee.PersonType2;
                    titleComboBox.SelectedItem = Employee.Title;
                    firstNameTextBox.Text = Employee.FirstName;
                    middleNameTextBox.Text = Employee.MiddleName;
                    lastNameTextBox.Text = Employee.LastName;
                    suffixComboBox.SelectedItem = Employee.Suffix;
                    phoneNumberTextBox.Text = Employee.PhoneNumber;
                    phoneNumberTypeComboBox.SelectedItem = Employee.PhoneNumberType;
                    addressLine1TextBox.Text = Employee.AddressLine1;
                    cityTextBox.Text = Employee.City;
                    stateProvinceIDComboBox.Text = Employee.StateOrProvince;
                    postalCodeTextBox.Text = Employee.PostalCode;
                    addressTypeIdComboBox.SelectedItem = Employee.AddressTypeID;
                    emailAddressTextBox.Text = Employee.EmailAddress;
                    nationalIdTextBox.Text = Employee.SocialSecurityNumber;
                    loginIdTextBox.Text = Employee.LoginID;
                    jobTitleTextBox.Text = Employee.JobTitle;
                    birthDatePicker.Value = Employee.BirthDate;
                    maritalStatusComboBox.SelectedItem = Employee.MaritalStatus;
                    genderComboBox.SelectedItem = Employee.Gender;
                    hireDatePicker.Value = Employee.HireDate;
                    vacationHoursTextBox.Text = Employee.VacationHours.ToString();
                    sickLeaveHoursTextBox.Text = Employee.SickLeaveHours.ToString();
                    rateTextBox.Text = Employee.HourlyPayRate.ToString();
                    payFrequencyComboBox.SelectedItem = Employee.PayFrequency;
                    departmentIdComboBox.SelectedItem = Employee.JobDepartment;
                    startDatePicker.Value = Employee.StartDate;
                    bool? salaried = Employee.SalariedFlag;
                    bool? current = Employee.CurrentEmployee;
                    int shift = Employee.ShiftID;

                    if (salaried == true)
                    {
                        salariedYesRadioButton.Checked = true;
                        salaried = null;
                    }
                    else if (salaried == false) 
                    {
                        salariedNoRadioButton.Checked = true;
                        salaried = null;
                    }

                    if (current == true) 
                    {
                        currentEmployeeYesRadioButton.Checked = true;
                        current = null;
                    }
                    else if (current == false)
                    {
                        currentEmployeeNoRadioButton.Checked = true;
                        current = null;
                    }

                    if (shift == 1) 
                    {
                        firstShiftRadioButton.Checked = true;
                        shift= 0;
                    }
                    else if (shift == 2)
                    {
                        secondShiftRadioButton.Checked = true;
                        shift= 0;
                    }
                    else if (shift == 3)
                    {
                        thirdShiftRadioButton.Checked = true;
                        shift= 0;
                    }

                    if (titleComboBox.SelectedItem is null) 
                    { 
                        titleComboBox.SelectedIndex = 0;
                    }

                    if (suffixComboBox.SelectedItem is null) 
                    { 
                        suffixComboBox.SelectedIndex = 0;
                    }
                }
            }
        }

        private void addNonSalesEmployeeButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are You Sure You Want To Update??",
                                     "Confirm Update!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    NumberValidators num = new NumberValidators();

                    if (NumberValidators.nmbr(phoneNumberTextBox.Text) == false)
                    {
                        MessageBox.Show("Phone Number Must Contain Only Numbers And Not Be Empty.");
                        return;
                    }

                    if (NumberValidators.dec(rateTextBox.Text) == false)
                    {
                        MessageBox.Show("Pay Rate Must Be In Money Format 00.00 And Not Be Empty.");
                        return;
                    }

                    if (NumberValidators.nmbr(postalCodeTextBox.Text) == false)
                    {
                        MessageBox.Show("Postal Code Must Contain Only Numbers And Not Be Empty.");
                        return;
                    }

                    if (NumberValidators.nmbr(nationalIdTextBox.Text) == false)
                    {
                        MessageBox.Show("National ID Must Contain Only Numbers And Not Be Empty.");
                        return;
                    }

                    if (NumberValidators.nmbr(vacationHoursTextBox.Text) == false)
                    {
                        MessageBox.Show("Vacation Hours Must Contain Only Numbers And Not Be Empty.");
                        return;
                    }

                    if (NumberValidators.nmbr(sickLeaveHoursTextBox.Text) == false)
                    {
                        MessageBox.Show("Sick Leave Hours Must Contain Only Numbers And Not Be Empty.");
                        return;
                    }

                    string stateProvinceID = stateProvinceIDComboBox.SelectedItem.ToString();

                    DataAccess db = new DataAccess();

                    bool salariedFlag = false;
                    if (salariedYesRadioButton.Checked)
                    {
                        salariedFlag = true;
                    }
                    else if (salariedNoRadioButton.Checked)
                    {
                        salariedFlag = false;
                    }
                    else
                    {
                        MessageBox.Show("Please Select A Value For Salaried Field.");
                        return;
                    }

                    int shiftId = 1;
                    if (firstShiftRadioButton.Checked)
                    {
                        shiftId = 1;
                    }

                    else if (secondShiftRadioButton.Checked)
                    {
                        shiftId = 2;
                    }

                    else if (thirdShiftRadioButton.Checked)
                    {
                        shiftId = 3;
                    }
                    else
                    {
                        MessageBox.Show("Please Select A Value For Shift.");
                        return;
                    }

                    bool currentEmployee = true;
                    if (currentEmployeeYesRadioButton.Checked)
                    {
                        currentEmployee = true;
                    }

                    else if (currentEmployeeNoRadioButton.Checked)
                    {
                        currentEmployee = false;
                    }
                    else
                    {
                        MessageBox.Show("Please Select A Value For Salaried Field.");
                        return;
                    }

                    {
                        UpdateNonSalesEmployeeModel Employee = new UpdateNonSalesEmployeeModel();
                        Employee.PersonType = personTypeComboBox.SelectedItem.ToString();
                        Employee.Title = titleComboBox.SelectedItem.ToString();
                        Employee.FirstName = firstNameTextBox.Text;
                        Employee.MiddleName = middleNameTextBox.Text;
                        Employee.LastName = lastNameTextBox.Text;
                        Employee.Suffix = suffixComboBox.SelectedItem.ToString();
                        Employee.PhoneNumber = phoneNumberTextBox.Text;
                        Employee.PhoneNumberType = phoneNumberTypeComboBox.SelectedItem.ToString();
                        Employee.AddressLine1 = addressLine1TextBox.Text;
                        Employee.City = cityTextBox.Text;
                        Employee.StateOrProvince = stateProvinceID;
                        Employee.PostalCode = postalCodeTextBox.Text;
                        Employee.AddressTypeID = addressTypeIdComboBox.SelectedItem.ToString();
                        Employee.EmailAddress = emailAddressTextBox.Text;
                        Employee.SocialSecurityNumber = nationalIdTextBox.Text;
                        Employee.LoginID = loginIdTextBox.Text;
                        Employee.JobTitle = jobTitleTextBox.Text;
                        Employee.BirthDate = birthDatePicker.Value;
                        Employee.MaritalStatus = maritalStatusComboBox.SelectedItem.ToString();
                        Employee.Gender = genderComboBox.SelectedItem.ToString();
                        Employee.HireDate = hireDatePicker.Value;
                        Employee.SalariedFlag = salariedFlag;
                        Employee.VacationHours = int.Parse(vacationHoursTextBox.Text);
                        Employee.SickLeaveHours = int.Parse(sickLeaveHoursTextBox.Text);
                        Employee.CurrentEmployee = currentEmployee;
                        Employee.HourlyPayRate = decimal.Parse(rateTextBox.Text);
                        Employee.PayFrequency = payFrequencyComboBox.SelectedItem.ToString();
                        Employee.JobDepartment = departmentIdComboBox.SelectedItem.ToString();
                        Employee.ShiftID = shiftId;
                        Employee.StartDate = startDatePicker.Value;
                        Employee.FullName = employeeFullNameComboBox.SelectedItem.ToString();

                        UpdateNonSalesEmployeeValidators validator = new UpdateNonSalesEmployeeValidators();

                        ValidationResult result = validator.Validate(Employee);

                        if (result.IsValid == false)
                        {
                            foreach (ValidationFailure failure in result.Errors)
                            {
                                MessageBox.Show(failure.ErrorMessage);
                                return;
                            }
                        }

                        db.UpdateNonSalesEmployee(Employee);

                        employeeFullNameComboBox.SelectedItem = null;
                        personTypeComboBox.Items.Clear();
                        titleComboBox.Items.Clear();
                        suffixComboBox.Items.Clear();
                        phoneNumberTypeComboBox.Items.Clear();
                        stateProvinceIDComboBox.Items.Clear();
                        addressTypeIdComboBox.Items.Clear();
                        birthDatePicker.Value = DateTime.Now;
                        maritalStatusComboBox.Items.Clear();
                        genderComboBox.Items.Clear();
                        hireDatePicker.Value = DateTime.Now;
                        salariedYesRadioButton.Checked = false;
                        salariedNoRadioButton.Checked = false;
                        currentEmployeeNoRadioButton.Checked = false;
                        currentEmployeeYesRadioButton.Checked = false;
                        payFrequencyComboBox.Items.Clear();
                        departmentIdComboBox.Items.Clear();
                        firstShiftRadioButton.Checked = false;
                        secondShiftRadioButton.Checked = false;
                        thirdShiftRadioButton.Checked = false;
                        startDatePicker.Value = DateTime.Now;

                        if (employeeFullNameComboBox.SelectedItem is null)
                        {
                            UpdateNonSalesEmployeeButton.Enabled = false;
                        }

                        WireUpLists();

                        firstNameTextBox.Text = "";
                        middleNameTextBox.Text = "";
                        lastNameTextBox.Text = "";
                        phoneNumberTextBox.Text = "";
                        addressLine1TextBox.Text = "";
                        cityTextBox.Text = "";
                        postalCodeTextBox.Text = "";
                        emailAddressTextBox.Text = "";
                        nationalIdTextBox.Text = "";
                        loginIdTextBox.Text = "";
                        jobTitleTextBox.Text = "";
                        vacationHoursTextBox.Text = "";
                        sickLeaveHoursTextBox.Text = "";
                        rateTextBox.Text = "";

                        MessageBox.Show("Success!");

                        UpdateNonSalesEmployeeButton.Enabled = false;
                    }
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
