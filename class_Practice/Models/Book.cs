using System;
using System.Collections.Generic;
using System.Text;

namespace class_Practice.Models
{
    internal class Book : Product
    {
        public string Genre;

        public Book(string Genre, int No, string Name, double Price, int Count) : base(No, Name, Price, Count)
        {
            this.Genre = Genre;
        }
    }
}
