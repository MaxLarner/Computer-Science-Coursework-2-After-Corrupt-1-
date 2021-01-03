using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Computer_Science_Coursework
{
    class SaveWall
    {
        //Define array 
        List<object> SavedHolds = new List<object>();
        
        int HoldCount = 0; 
        

        public void SavedHoldsArray(object Hold)
        {
            SavedHolds[HoldCount] = Hold;
            HoldCount++;
        }

        public void OnSavedWall_Click()
        {
            

        }

    }
}
