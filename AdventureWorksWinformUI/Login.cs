using AdventureWorksLibrary;
using AdventureWorksLibrary.Models;
using AdventureWorksLibrary.SqlDataAccess;
using AdventureWorksLibrary.Validators;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureWorksWinformUI
{
    public partial class Login : Form
    {
        public static string role;
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess db = new DataAccess();

                LoginModel Login = new LoginModel();
                Login.LoginID = loginIdTextBox.Text;
                Login.Password = passwordTextBox.Text;

                LoginValidators validator = new LoginValidators();

                ValidationResult result = validator.Validate(Login);

                if (result.IsValid == false)
                {
                    foreach (ValidationFailure failure in result.Errors)
                    {
                        MessageBox.Show(failure.ErrorMessage);
                        return;
                    }
                }
                db.Login(Login);

                role = Login.Role;

                if (Login.Role == "Wrong LoginID Or Password. Please Try Again!")
                {
                    MessageBox.Show(Login.Role);
                    return;
                }
                else
                {
                    this.Hide();
                    Dashboard form = new Dashboard();
                    form.ShowDialog();
                }
            }

            catch (SqlException exception)
            {
                MessageBox.Show("There was an error when performing this operation.\nPlease verify that all entered information is correct.\nCheck the database table DB_Errors for more information.");
            }
        }

            private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
        }
    }
}
