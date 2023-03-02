using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism__casting
{
    internal class Product
    {
        static int _totalCount = 0;
        public Product()
        {
            _totalCount++;
            No = _totalCount;
        }
        public string Name;
        public readonly int No;
        private double _price;
        public double Price
        {
            get => _price;
            set
            {
                if(value>0)
                {
                    _price = value;
                }
            }
        }
        public virtual void ShowProducts()
        {
            Console.WriteLine($"No: {No} - Name: {Name} - Price: {Price}");
        }

    }
}
