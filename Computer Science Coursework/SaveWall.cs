using System;
using System.Collections.Generic;
using System.Text;

namespace Computer_Science_Coursework
{
    class SaveWall
    {
        IDictionary<string, object> SavedHolds = new Dictionary<string, object>();

        public void HoldsOnWall(string HoldName, object Hold)
        {
            SavedHolds.Add(HoldName, Hold);
        }
    }
}
