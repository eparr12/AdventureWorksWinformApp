using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksLibrary.Models
{
    public class UpdateNonSalesEmployeeModel : AddUpdatePersonModel
    {
        public string FullName { get; set; }
        public string PersonType { get; set; }
        public bool CurrentEmployee { get; set; }
        public string PersonType2 { get; set; }
    }
}
