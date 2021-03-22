using System;
using System.Collections.Generic;
using System.Text;

namespace Computer_Science_Coursework.exceptions
{
    public class Hold_InvalidNonIntegerEntry : Exception
    {
        public Hold_InvalidNonIntegerEntry()

            : base(string.Format("please enter integers only"))
        {
        }
    }
}
