using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksLibrary.Models
{
    public class AddNonSalesEmployeeModel : AddUpdatePersonModel
    {
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
