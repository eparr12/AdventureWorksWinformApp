using FluentValidation;
using FluentValidation.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventureWorksLibrary.Validators
{
    public static class CustomValidators
    {
        public static IRuleBuilderOptions<T, string> NotStartWithWhiteSpace<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.Must(m => m != null && !m.StartsWith(" ")).WithMessage("{PropertyName} Should Not Start With Spaces.");
        }

        public static IRuleBuilderOptions<T, string> NotEndsWithWhiteSpace<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.Must(m => m != null && !m.EndsWith(" ")).WithMessage("{PropertyName} Should Not End With Spaces.");
        }

        public static IRuleBuilderOptions<T, string> UniversalValidation<T>(this IRuleBuilder<T, string> rule)
        {
            return rule
                .NotEmpty().WithMessage("Must Enter A Value For {PropertyName}.")
                .NotStartWithWhiteSpace()
                .NotEndsWithWhiteSpace()
                .Matches("^[^'<>-]*$").WithMessage("{PropertyName} Must Not Contain The Following Characters ' < > Or -.");
        }

        static readonly Regex letters = new Regex("^[A-Za-z ]*$");
        public static IRuleBuilderOptions<T, string> UniversalStringValidation<T>(this IRuleBuilder<T, string> rule)
        {
            return rule
                .NotEmpty().WithMessage("Must Enter A Value For {PropertyName}.")
                .NotStartWithWhiteSpace()
                .NotEndsWithWhiteSpace()
                .Matches("^[^'<>-]*$").WithMessage("{PropertyName} Must Not Contain The Following Characters ' < > Or -.")
                .Matches(letters).WithMessage("{PropertyName} Must Not Contain Numbers.");
        }

        static readonly Regex numbers = new Regex("^[0-9]*$");
        public static IRuleBuilderOptions<T, string> UniversalNumValidation<T>(this IRuleBuilder<T, string> rule)
        {
            return rule
                .NotEmpty().WithMessage("Must Enter A Value For {PropertyName}.")
                .NotStartWithWhiteSpace()
                .NotEndsWithWhiteSpace()
                .Matches("^[^'<>-]*$").WithMessage("{PropertyName} Must Not Contain The Following Characters ' < > Or -.")
                .Matches(numbers).WithMessage("{PropertyName} Must Be In Money Format 00.00.");                
        }

        static readonly Regex money = new Regex("^[0-9].*$");
        public static IRuleBuilderOptions<T, string> UniversalMoneyValidation<T>(this IRuleBuilder<T, string> rule)
        {
            return rule
                .NotEmpty().WithMessage("Must Enter A Value For {PropertyName}.")
                .NotStartWithWhiteSpace()
                .NotEndsWithWhiteSpace()
                .Matches("^[^'<>-]*$").WithMessage("{PropertyName} Must Not Contain The Following Characters ' < > Or -.")
                .Matches(money).WithMessage("{PropertyName} Must Contain Only Numbers.");
        }

        public static IRuleBuilderOptions<T, int> VacatiionSickHoursValidation<T>(this IRuleBuilder<T, int> rule)
        {
            return rule
                .NotEmpty().WithMessage("Must Enter A Value For {PropertyName}.")
                .InclusiveBetween(0,120).WithMessage("{PropertyName} Must Be Between 0 And 120");
        }

        public static IRuleBuilderOptions<T, string> UniversalDropdownValidation<T>(this IRuleBuilder<T, string> rule)
        {
            return rule
                .NotEmpty().WithMessage("Must Enter A Value For {PropertyName}.");
        }

    }
}
