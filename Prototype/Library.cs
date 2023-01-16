using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Library
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Loan> Loans { get; set; }
        public List<Cd> Cds { get; set; }
        public List<Dvd> Dvds { get; set; }
        public List<Book> Books { get; set; }
    }
}
