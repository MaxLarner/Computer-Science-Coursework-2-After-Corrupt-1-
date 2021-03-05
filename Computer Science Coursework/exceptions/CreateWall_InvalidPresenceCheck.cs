using System;
using System.Collections.Generic;
using System.Text;

namespace Computer_Science_Coursework.exceptions
{


    public class CreateWall_InvalidPresenceCheck : Exception
    {
        public CreateWall_InvalidPresenceCheck()

            : base(string.Format("please submit an answer"))
        {
        }
    }
}