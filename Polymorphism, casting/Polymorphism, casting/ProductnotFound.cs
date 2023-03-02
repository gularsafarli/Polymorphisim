using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism__casting
{
    internal class ProductnotFound:Exception
    {
        public ProductnotFound() : base($"Bu nomreli product movcud deyil")
       { 
            
        }
    }
}
