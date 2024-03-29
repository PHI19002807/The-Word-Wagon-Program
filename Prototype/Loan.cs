﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Loan
    {
        public DateTime CurrentDate { get; set; }
        public string Duration { get; set; }
        public bool Status { get; set; }
        public string ReturnDate { get; set; }
        public Customer Customer { get; set; }
        public Items Item { get; set; }
        public int Id { get; set; }

        public Loan(DateTime currentdate, string duration, bool status, string returndate, Customer customerinfo, Items items, int id)
        {
            CurrentDate = currentdate;
            Duration = duration;
            Status = status;
            ReturnDate = returndate;
            Customer = customerinfo;
            Item = items;
            Id = id;
        }

        public override string ToString()
        {
            return $"Date: { CurrentDate }\nDuration: { Duration }\nStatus: { Status }\nReturn date: { ReturnDate }\nCustomer info: { Customer }";
        }
    }
}
