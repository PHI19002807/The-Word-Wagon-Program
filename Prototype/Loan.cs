using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Loan
    {
        public DateTime CurrentDate { get; set; }
        public string Duration { get; set; }
        public bool Status { get; set; }
        public string ReturnDate { get; set; }
        public string CustomerInfo { get; set; }

        public Loan(DateTime currentdate, string duration, bool status, string returndate, string customerinfo)
        {
            CurrentDate = currentdate;
            Duration = duration;
            Status = status;
            ReturnDate = returndate;
            CustomerInfo = customerinfo;
        }

        public override string ToString()
        {
            return $"";
        }
    }
}
