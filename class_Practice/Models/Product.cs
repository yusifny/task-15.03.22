using System;
using System.Collections.Generic;
using System.Text;

namespace class_Practice.Models
{
    internal class Product
    {
        public int No;
        public string Name;
        public double Price;
        public int Count;

        public Product(int No, string Name, double Price, int Count)
        {
            this.No = No;
            this.Name = Name;
            this.Price = Price;
            this.Count = Count;
        }
    }
}
