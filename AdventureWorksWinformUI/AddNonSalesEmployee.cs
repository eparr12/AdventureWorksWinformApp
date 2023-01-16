using AdventureWorksLibrary;
using AdventureWorksLibrary.Models;
using AdventureWorksLibrary.Models.DropDowns;
using AdventureWorksLibrary.SqlDataAccess;
using AdventureWorksLibrary.Validators;
using FluentValidation.Results;
using System.Data.SqlClient;

namespace AdventureWorksWinformUI
{
    public partial class AddNonSalesEmployee : Form
    {
        List<StateProvinceIDModel> StateProvinceID = new List<StateProvinceIDModel>();
        List<DepartmentIDModel> DepartmentID = new List<DepartmentIDModel>();
        public AddNonSalesEmployee()
        {
            InitializeComponent();

            this.Text = "Add Non-Sales Employee";

            if (Login.role != "Administrator")
            {
                addNonSalesEmployeeButton.Enabled = false;
            }

            WireUpLists();

        }

        private void WireUpLists()
        {
            titleComboBox.Items.Add("");
            titleComboBox.Items.Add("Mr.");
            titleComboBox.Items.Add("Mrs.");
            titleComboBox.Items.Add("Ms.");
            titleComboBox.SelectedIndex = 0;

            suffixComboBox.Items.Add("");
            suffixComboBox.Items.Add("I");
            suffixComboBox.Items.Add("II");
            suffixComboBox.Items.Add("III");
            suffixComboBox.Items.Add("IV");
            suffixComboBox.Items.Add("Jr.");
            suffixComboBox.Items.Add("PhD");
            suffixComboBox.Items.Add("Sr.");
            suffixComboBox.SelectedIndex= 0;

            phoneNumberTypeComboBox.Items.Add("");
            phoneNumberTypeComboBox.Items.Add("Cell");
            phoneNumberTypeComboBox.Items.Add("Home");
            phoneNumberTypeComboBox.Items.Add("Work");
            phoneNumberTypeComboBox.SelectedIndex= 0;

            addressTypeIdComboBox.Items.Add("");
            addressTypeIdComboBox.Items.Add("Archive");
            addressTypeIdComboBox.Items.Add("Billing");
            addressTypeIdComboBox.Items.Add("Home");
            addressTypeIdComboBox.Items.Add("Main Office");
            addressTypeIdComboBox.Items.Add("Primary");
            addressTypeIdComboBox.Items.Add("Shipping");
            addressTypeIdComboBox.SelectedIndex= 0;

            maritalStatusComboBox.Items.Add("");
            maritalStatusComboBox.Items.Add("Married");
            maritalStatusComboBox.Items.Add("Single");
            maritalStatusComboBox.SelectedIndex= 0;

            genderComboBox.Items.Add("");
            genderComboBox.Items.Add("Male");
            genderComboBox.Items.Add("Female");
            genderComboBox.SelectedIndex= 0;

            payFrequencyComboBox.Items.Add("");
            payFrequencyComboBox.Items.Add("Bi-Weekly");
            payFrequencyComboBox.Items.Add("Weekly");
            payFrequencyComboBox.SelectedIndex= 0;

            departmentIdComboBox.Items.Add("");
            departmentIdComboBox.SelectedIndex= 0;

            stateProvinceIDComboBox.Items.Add("");
            stateProvinceIDComboBox.SelectedIndex= 0;

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

            userRoleComboBox.Items.Add("");
            userRoleComboBox.Items.Add("Administrator");
            userRoleComboBox.Items.Add("Basic");
            userRoleComboBox.SelectedIndex= 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void titleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {    
        }

        private void suffixComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
        }

        private void phoneTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addressTypeIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maritalStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void payFrequencyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void shiftIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void addNonSalesEmployeeButton_Click(object sender, EventArgs e)
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

                {
                    AddNonSalesEmployeeModel Employee = new AddNonSalesEmployeeModel();
                    Employee.Title = titleComboBox.SelectedItem.ToString();
                    Employee.FirstName = firstNameTextBox.Text;
                    Employee.MiddleName = middleNameTextBox.Text;
                    Employee.LastName = lastNameTextBox.Text;
                    Employee.Suffix = suffixComboBox.SelectedItem.ToString();
                    Employee.Password = passwordTextBox.Text;
                    Employee.PhoneNumber = phoneNumberTextBox.Text;
                    Employee.PhoneNumberTypeID = phoneNumberTypeComboBox.SelectedItem.ToString();
                    Employee.AddressLine1 = addressLine1TextBox.Text;
                    Employee.City = cityTextBox.Text;
                    Employee.StateProvinceID = stateProvinceID;
                    Employee.PostalCode = postalCodeTextBox.Text;
                    Employee.AddressTypeID = addressTypeIdComboBox.SelectedItem.ToString();
                    Employee.EmailAddress = emailAddressTextBox.Text;
                    Employee.NationalIDNumber = nationalIdTextBox.Text;
                    Employee.LoginID = loginIdTextBox.Text;
                    Employee.JobTitle = jobTitleTextBox.Text;
                    Employee.BirthDate = birthDatePicker.Value;
                    Employee.MaritalStatus = maritalStatusComboBox.SelectedItem.ToString();
                    Employee.Gender = genderComboBox.SelectedItem.ToString();
                    Employee.HireDate = hireDatePicker.Value;
                    Employee.SalariedFlag = salariedFlag;
                    Employee.VacationHours = int.Parse(vacationHoursTextBox.Text);
                    Employee.SickLeaveHours = int.Parse(sickLeaveHoursTextBox.Text);
                    Employee.Rate = decimal.Parse(rateTextBox.Text);
                    Employee.PayFrequency = payFrequencyComboBox.SelectedItem.ToString();
                    Employee.DepartmentID = departmentIdComboBox.SelectedItem.ToString();
                    Employee.ShiftID = shiftId;
                    Employee.StartDate = startDatePicker.Value;
                    Employee.Role = userRoleComboBox.SelectedItem.ToString();

                    AddNonSalesEmployeeValidators validator = new AddNonSalesEmployeeValidators();

                    ValidationResult result = validator.Validate(Employee);

                    if (result.IsValid == false)
                    {
                        foreach (ValidationFailure failure in result.Errors)
                        {
                            MessageBox.Show(failure.ErrorMessage);
                            return;
                        }
                    }

                    db.AddNonSalesEmployee(Employee);

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
                    salariedNoRadioButton.Checked= false;
                    payFrequencyComboBox.Items.Clear();
                    departmentIdComboBox.Items.Clear();
                    firstShiftRadioButton.Checked = false;
                    secondShiftRadioButton.Checked = false;
                    thirdShiftRadioButton.Checked = false;
                    startDatePicker.Value = DateTime.Now;

                    WireUpLists();

                    firstNameTextBox.Text = "";
                    middleNameTextBox.Text = "";
                    lastNameTextBox.Text = "";
                    passwordTextBox.Text = "";
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
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show("There was an error when performing this operation.\nPlease verify that all entered information is correct.\nCheck the database table DB_Errors for more information.");
            }
        }
        private void homeButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard form = new Dashboard();
            form.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}