using AdventureWorksLibrary.Models;
using FluentValidation;
using Microsoft.AspNetCore.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace AdventureWorksLibrary.Validators
{
    public class UpdateNonSalesEmployeeValidators : AbstractValidator<UpdateNonSalesEmployeeModel>
    {
        public UpdateNonSalesEmployeeValidators() 
        {
            RuleFor(N => N.PersonType).UniversalDropdownValidation();
            RuleFor(N => N.FirstName).UniversalStringValidation();
            RuleFor(N => N.MiddleName).UniversalStringValidation();
            RuleFor(N => N.LastName).UniversalStringValidation();
            RuleFor(N => N.PhoneNumber).UniversalNumValidation();
            RuleFor(N => N.PhoneNumberTypeID).UniversalDropdownValidation();
            RuleFor(N => N.AddressLine1).UniversalValidation();
            RuleFor(N => N.City).UniversalStringValidation();
            RuleFor(N => N.StateProvinceID).UniversalDropdownValidation();
            RuleFor(N => N.PostalCode).UniversalNumValidation();
            RuleFor(N => N.AddressTypeID).UniversalDropdownValidation();
            RuleFor(N => N.EmailAddress).UniversalValidation()
                .EmailAddress().WithMessage("Enter A Valid Email For {PropertyName}.");
            RuleFor(N => N.NationalIDNumber).UniversalNumValidation();
            RuleFor(N => N.LoginID).UniversalValidation();
            RuleFor(N => N.JobTitle).UniversalValidation();
            RuleFor(N => N.BirthDate).NotEmpty()
                .Must(BeAValidAge).WithMessage($"Birth Date Must Be Between {DateTime.Now.Year - 120} And {DateTime.Now.Year - 18}.");
            RuleFor(N => N.MaritalStatus).UniversalDropdownValidation();
            RuleFor(N => N.Gender).UniversalDropdownValidation();
            RuleFor(N => N.HireDate).NotEmpty()
                .Must(BeAValidHireDate).WithMessage($"Hire Date Must Be On Or Before {DateTime.Now.AddDays(1).ToString("MM/dd/yyyy")}");
            RuleFor(N => N.VacationHours).VacatiionSickHoursValidation();
            RuleFor(N => N.SickLeaveHours).VacatiionSickHoursValidation();
            RuleFor(N => N.Rate.ToString()).UniversalMoneyValidation();
            RuleFor(N => N.PayFrequency).UniversalDropdownValidation();
            RuleFor(N => N.DepartmentID).UniversalDropdownValidation();
            RuleFor(N => N.StartDate).NotEmpty();
        }

        protected bool BeAValidAge(DateTime date)
        {
            int currentYear = DateTime.Now.Year;
            int dobYear = date.Year;

            if (dobYear <= (currentYear - 18) && dobYear > (currentYear - 120))
            {
                return true;
            }
            else
                return false;
        }

        protected bool BeAValidHireDate(DateTime date)
        {
            if (date <= DateTime.Now)
            {
                return true;
            }
            else
                return false;
        }
    }
}
