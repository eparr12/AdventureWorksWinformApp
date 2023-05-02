using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksLibrary.Models
{
    public class NonSalesEmployeeInformationModel : PersonModel
    {
        public string PersonName { get; set; }
        public int PersonID { get; set; }
        public string PersonType { get; set; }
        public string Country { get; set; }
        public string JobGroup { get; set; }
        public string ShiftNumber { get; set; }
        public string ShiftName { get; set; }
        public string SalesTerritory { get; set; }
        public string Currency { get; set; }
    }
}
