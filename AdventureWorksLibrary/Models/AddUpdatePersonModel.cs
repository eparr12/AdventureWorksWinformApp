using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksLibrary.Models
{
    public abstract class AddUpdatePersonModel : PersonModel
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string AddressTypeID { get; set; }
        public bool SalariedFlag { get; set; }
        public DateTime StartDate { get; set; }
        public int ShiftID { get; set; }
    }
}
