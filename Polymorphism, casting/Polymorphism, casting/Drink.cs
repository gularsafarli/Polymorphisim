using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism__casting
{
    internal class Drink : Product
    {
        private byte _alcoholPercent;
        public byte AlcoholPercent
        {
            get { return _alcoholPercent; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _alcoholPercent = value;
                }
                else
                {
                    throw new AlcoPercentException();
                }

            }
        }
             public override void ShowProducts()
             {
            Console.WriteLine($"No: {No}- Name: {Name}-Price: {Price}-Percent: {AlcoholPercent}");
             }
    }
}
        
    

