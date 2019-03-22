using System;
using System.Collections.Generic;
using System.Text;

namespace Fundacion.Jala.DevInt.GenericsSample
{
    public class Book
    {
        public Book()
        {
            pages = 10;
        }
        protected int pages;
        public Book(int pages)
        {
            this.pages = pages;
        }
    }
}
