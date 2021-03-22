using System;
using System.Collections.Generic;
using System.Text;

namespace Computer_Science_Coursework.exceptions
{


    public class SaveWall_InvalidPresenceCheck : Exception
    {
        public SaveWall_InvalidPresenceCheck()

            : base(string.Format("please submit an input"))
        {
        }
    }
}