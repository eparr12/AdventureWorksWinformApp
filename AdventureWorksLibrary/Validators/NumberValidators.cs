using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksLibrary.Validators
{
    public class NumberValidators
    {
        public static bool nmbr(string nmbr)
        {
            Int64 a;
            return long.TryParse(nmbr, out a);
            
        }

        public static bool dec(string dec)
        {
            decimal a;
            return decimal.TryParse(dec, out a);

        }
    }
}
