using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism__casting
{
    internal class Dairy:Product
    {
        public double _fatPercent;
        private double FatPercent
        {
            get => _fatPercent;
            set
            {
                if (value>=0&&value<=100)
                {
                    _fatPercent = value;
                }
                else
                {
                    throw new FPercentException();
                }

            }
        }
        public override void ShowProducts()
        {
            Console.WriteLine($"No:{No} -Name:{Name}-Price:{Price}-FatPercent:{_fatPercent}");
        }
    }
}
