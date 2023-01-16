using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksLibrary.Models
{
    public class AddNonSalesEmployeeModel
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneNumberTypeID { get; set; }
        public string AddressLine1 { get; set; }
        public string City { get; set; }
        public string StateProvinceID { get; set; }
        public string PostalCode { get; set; }
        public string AddressTypeID { get; set; }
        public string EmailAddress { get; set; }
        public string NationalIDNumber { get; set; }
        public string LoginID { get; set; }
        public string JobTitle { get; set; }
        public DateTime BirthDate { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public DateTime HireDate { get; set; }
        public bool SalariedFlag { get; set; }
        public int VacationHours { get; set; }
        public int SickLeaveHours { get; set; }
        public decimal Rate { get; set; }
        public string PayFrequency { get; set; }
        public string DepartmentID { get; set; }
        public int ShiftID { get; set; }
        public DateTime StartDate { get; set; }
        public string Role { get; set; }
    }
}
