using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace Computer_Science_Coursework
{
    [Serializable()]
    public class SavedWall
    {
        public string WallName;
        public int WallHeight;
        public int WallWidth;
        //Define the list that stores the holds. Each hold is stored as a list 
        public List<object> ListOfHolds = new List<object>();

        public SavedWall(string WallName, int WallHeight, int WallWidth)
        {
            this.WallName = WallName;
            this.WallHeight = WallHeight;
            this.WallWidth = WallWidth; 

        }
        // adds all the crucial inforation to a list, then adds that to the list of holds 
        public void AddHolds(string HoldName, Point pctBox_Location, Point[] HoldShape, string HoldColour)
        {
            List<object> Hold = new List<object>();
            Hold.Add(HoldName);
            Hold.Add(pctBox_Location);
            Hold.Add(HoldShape);
            Hold.Add(HoldColour);
            ListOfHolds.Add(Hold);
        }

    }
}
