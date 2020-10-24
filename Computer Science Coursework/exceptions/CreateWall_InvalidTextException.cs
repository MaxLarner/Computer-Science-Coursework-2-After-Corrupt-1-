using System;
using System.Collections.Generic;
using System.Text;

namespace Computer_Science_Coursework.exceptions
{
    public class CreateWall_InvalidTextException : Exception
    {
        public CreateWall_InvalidTextException()
        
            : base(string.Format("invalid text entry when creating wall"))
        { 
        }
    }
}
