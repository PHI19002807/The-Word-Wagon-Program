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

        public Library(string name, string address)
        {
            Name = name;
            Address = address;
            Loans = new List<Loan>();
            Cds = new List<Cd>();
            Dvds = new List<Dvd>();
            Books = new List<Book>();
        }

        public Dvd? GetDvd(int Idnumber)
        {
            foreach (var dvd in Dvds)
            {
                if (dvd.Id == Idnumber)
                {
                    return dvd;
                }
            }
            return null;
        }

        public Cd? GetCd(int Idnumber)
        {
            foreach (var cd in Cds)
            {
                if (cd.Id == Idnumber)
                {
                    return cd;
                }
            }
            return null;
        }

        public Book? GetBook(int Idnumber)
        {
             foreach (var book in Books)
            {
                if (book.Id == Idnumber)
                {
                    return book;
                }
            }
             return null;
        }

         public Loan? GetLoan(string LoanId)
        {
             foreach (var loan in Loans)
            {
                if (loan.Id.ToString() == LoanId)
                {
                    return loan;
                }
            }
             return null;
        }
    }
}
