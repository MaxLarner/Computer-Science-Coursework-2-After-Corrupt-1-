using System;
using System.Collections.Generic;
using System.Text;

namespace Computer_Science_Coursework.exceptions
{
    

    public class Hold_InvalidPresenceCheck : Exception
    {
        public Hold_InvalidPresenceCheck()

            : base(string.Format("please submit an answer"))
        {
        }
    }
}
