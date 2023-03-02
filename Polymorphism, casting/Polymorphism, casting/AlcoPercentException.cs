using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism__casting
{
    internal class AlcoPercentException : Exception
    {
        public AlcoPercentException() : base($"Alcohol Limitinin faizi duzgun qeyd olunmamisdir")
        {

        }
    }
}
