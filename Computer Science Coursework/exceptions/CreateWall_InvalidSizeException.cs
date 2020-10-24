using System;
using System.Collections.Generic;
using System.Text;

namespace Computer_Science_Coursework.exceptions
{
    class CreateWall_InvalidSizeException : Exception
    {
        public CreateWall_InvalidSizeException()

            : base(string.Format("invalid text entry when creating wall"))
        {
        }
    }
}
