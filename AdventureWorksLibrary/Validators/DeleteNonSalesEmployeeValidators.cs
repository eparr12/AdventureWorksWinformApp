using AdventureWorksLibrary.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksLibrary.Validators
{
    public class DeleteNonSalesEmployeeValidators : AbstractValidator<DeleteNonSalesEmployeeModel>
    {
        public DeleteNonSalesEmployeeValidators()
        {
            RuleFor(N => N.Name).UniversalDropdownValidation();
        }
    }
}
