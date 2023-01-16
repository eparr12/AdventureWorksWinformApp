using AdventureWorksLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Configuration;
using AdventureWorksLibrary.Models.DropDowns;

namespace AdventureWorksLibrary.SqlDataAccess
{
    public class DataAccess
    {
        public AddNonSalesEmployeeModel AddNonSalesEmployee(AddNonSalesEmployeeModel Employee)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("AdventureWorks2014")))
            {
                var p = new DynamicParameters();
                p.Add("@Title", Employee.Title);
                p.Add("@FirstName", Employee.FirstName);
                p.Add("@MiddleName", Employee.MiddleName);
                p.Add("@LastName", Employee.LastName);
                p.Add("@Suffix", Employee.Suffix);
                p.Add("@Password", Employee.Password);
                p.Add("@PhoneNumber", Employee.PhoneNumber);
                p.Add("@PhoneNumberTypeID", Employee.PhoneNumberTypeID);
                p.Add("@AddressLine1", Employee.AddressLine1);
                p.Add("@City", Employee.City);
                p.Add("@StateProvinceID", Employee.StateProvinceID);
                p.Add("@PostalCode", Employee.PostalCode);
                p.Add("@AddressTypeID", Employee.AddressTypeID);
                p.Add("@EmailAddress", Employee.EmailAddress);
                p.Add("@NationalIDNumber", Employee.NationalIDNumber);
                p.Add("@LoginID", Employee.LoginID);
                p.Add("@JobTitle", Employee.JobTitle);
                p.Add("@BirthDate", Employee.BirthDate);
                p.Add("@MaritalStatus", Employee.MaritalStatus);
                p.Add("@Gender", Employee.Gender);
                p.Add("@HireDate", Employee.HireDate);
                p.Add("@SalariedFlag", Employee.SalariedFlag);
                p.Add("@VacationHours", Employee.VacationHours);
                p.Add("@SickLeaveHours", Employee.SickLeaveHours);
                p.Add("@Rate", Employee.Rate);
                p.Add("@PayFrequency", Employee.PayFrequency);
                p.Add("@DepartmentID", Employee.DepartmentID);
                p.Add("@ShiftID", Employee.ShiftID);
                p.Add("@StartDate", Employee.StartDate);
                p.Add("@Role", Employee.Role);

                connection.Execute("SP_AddNonSalesEmployee", p, commandType: CommandType.StoredProcedure);

                return Employee;
            }
        }

        public DeleteNonSalesEmployeeModel DeleteEmployee(DeleteNonSalesEmployeeModel Employee)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("AdventureWorks2014")))
            {
                var p = new DynamicParameters();
                p.Add("@EmployeeFullName", Employee.Name);

                connection.Execute("SP_DeleteEmployees", p, commandType: CommandType.StoredProcedure);

                return Employee;
            }
        }

        public List<NonSalesEmployeeInformationModel> GetEmployeeInformation(string personName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("AdventureWorks2014")))
            {

                var output = connection.Query<NonSalesEmployeeInformationModel>("SP_GetPersonInformation @PersonName", new { PersonName = personName }).ToList();

                return output;
            }
        }

        public List<UpdateNonSalesEmployeeModel> GetUpdatedEmployeeInformation(string personName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("AdventureWorks2014")))
            {

                var output = connection.Query<UpdateNonSalesEmployeeModel>("SP_GetPersonInformation @PersonName", new { PersonName = personName }).ToList();

                return output;
            }
        }

        public UpdateNonSalesEmployeeModel UpdateNonSalesEmployee(UpdateNonSalesEmployeeModel Employee)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("AdventureWorks2014")))
            {
                var p = new DynamicParameters();
                p.Add("@FullName", Employee.FullName);
                p.Add("@PersonType", Employee.PersonType);
                p.Add("@Title", Employee.Title);
                p.Add("@FirstName", Employee.FirstName);
                p.Add("@MiddleName", Employee.MiddleName);
                p.Add("@LastName", Employee.LastName);
                p.Add("@Suffix", Employee.Suffix);
                p.Add("@PhoneNumber", Employee.PhoneNumber);
                p.Add("@PhoneNumberTypeID", Employee.PhoneNumberTypeID);
                p.Add("@AddressLine1", Employee.AddressLine1);
                p.Add("@City", Employee.City);
                p.Add("@StateProvinceID", Employee.StateProvinceID);
                p.Add("@PostalCode", Employee.PostalCode);
                p.Add("@AddressTypeID", Employee.AddressTypeID);
                p.Add("@EmailAddress", Employee.EmailAddress);
                p.Add("@NationalIDNumber", Employee.NationalIDNumber);
                p.Add("@LoginID", Employee.LoginID);
                p.Add("@JobTitle", Employee.JobTitle);
                p.Add("@BirthDate", Employee.BirthDate);
                p.Add("@MaritalStatus", Employee.MaritalStatus);
                p.Add("@Gender", Employee.Gender);
                p.Add("@HireDate", Employee.HireDate);
                p.Add("@SalariedFlag", Employee.SalariedFlag);
                p.Add("@VacationHours", Employee.VacationHours);
                p.Add("@SickLeaveHours", Employee.SickLeaveHours);
                p.Add("@CurrentFlag", Employee.CurrentEmployee);
                p.Add("@Rate", Employee.Rate);
                p.Add("@PayFrequency", Employee.PayFrequency);
                p.Add("@DepartmentID", Employee.DepartmentID);
                p.Add("@ShiftID", Employee.ShiftID);
                p.Add("@StartDate", Employee.StartDate);

                connection.Execute("SP_UpdateNonSalesEmployee", p, commandType: CommandType.StoredProcedure);

                return Employee;
            }
        }

        public List<StateProvinceIDModel> GetStateProvinceID()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("AdventureWorks2014")))
            {
                var output = connection.Query<StateProvinceIDModel>($"select * from v_DropdownStateProvinceID").ToList();
                return output;
            }
        }

        public List<DepartmentIDModel> GetDepartmentID()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("AdventureWorks2014")))
            {
                var output = connection.Query<DepartmentIDModel>($"select * from v_DropdownDepartmentID").ToList();
                return output; 
            }
        }

        public List<EmployeeFullNameModel> GetAnyEmployeeFullName()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("AdventureWorks2014")))
            {
                var output = connection.Query<EmployeeFullNameModel>($"select * from v_DropdownEmployeeFullName").ToList();
                return output;
            }
        }

        public List<EmployeeFullNameModel> GetNonSalesEmployeeFullName()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("AdventureWorks2014")))
            {
                var output = connection.Query<EmployeeFullNameModel>($"select * from v_DropdownNonSalesEmployeeFullName ").ToList();
                return output;
            }
        }

        public LoginModel Login(LoginModel Login)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SqlHelper.CnnVal("AdventureWorks2014")))
            {
                var p = new DynamicParameters();
                p.Add("@LoginID", Login.LoginID);
                p.Add("@Password", Login.Password);
                p.Add("@Role", "A", DbType.String, ParameterDirection.Output);

                connection.Execute("SP_UserLogin", p, commandType: CommandType.StoredProcedure);

                Login.Role = p.Get<string>("@Role");

                return Login;
            }
        }
    }
}
