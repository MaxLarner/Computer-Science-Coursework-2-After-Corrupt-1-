using System;
using System.Collections.Generic;
using System.Text;

namespace Computer_Science_Coursework.exceptions
{
    class CreateWall_PanelTest : Exception
    {
        public CreateWall_PanelTest()

            : base(string.Format("Creation of panel was not successful, entry data does not match panel dimensions"))
        {
        }
    }
    
 }

