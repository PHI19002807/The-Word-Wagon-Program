﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Book:Items
    {
        public Book(string title, string author, int id)
      : base(title, author, id)
        {

        }
    }

}
