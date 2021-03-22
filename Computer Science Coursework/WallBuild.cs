using Computer_Science_Coursework.exceptions;
using Computer_Science_Coursework.Events;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using System.IO;


namespace Computer_Science_Coursework
{
    [Serializable()]
    class WallBuild
    {

        public string HoldColour;

        public void setColour(string colour)
        {
            this.HoldColour = colour;
        }

        public string getColour()
        {
            return HoldColour;
        }
        public string WallFilePath;
        public bool LoadWall = false;


        int HoldCount = 0;
        
        WallSerializer wallSerializer = new WallSerializer();
        //Defines the wall panel 
        Panel WallPanel = Global.WallPanel;
        PictureBox pctBox_CurrentHold = new PictureBox();
        //defines the list of holds to pass to save wall 
        List<Hold> ListOfHolds = new List<Hold>();


        public void WallPanelSizeTest(int WallWidth, int WallHeight)
        {
            if (WallPanel.Width == WallWidth && WallPanel.Height == WallHeight)
            {
                MessageBox.Show("Wall built successfully" + WallWidth + ", " + WallHeight);
            }
        }

        public void CreateWall(int X, int Y)
        {
            // Create a panel called "WallPanel"
            WallPanel.Location = new System.Drawing.Point(300, 50);
            WallPanel.Name = "pnl_ClimbingWall";
            // Assigns the size the dimentions passed to the subroutine...
            //...from WallWidth and Wall Height in the WallSubmit click event
            WallPanel.Size = new System.Drawing.Size(X, Y);
            WallPanel.BackColor = Color.LightGreen;
            ////Dynamically Creates a click event for "WallPanel" to dectect when its been clicked 
            Form1 form = new Form1();
            WallPanel.MouseClick += BuildWallScreen.Instance.WallPanel_Click;
            //Creates a new instance of the event handler 
            CreateWall_AddPanelEventArgs args = new CreateWall_AddPanelEventArgs();
            //Adds the wallpanel to the event 
            args.WallPanel = WallPanel;
            //activates the event sender with the event 'args'
            OnCreateWall(args);
        }

        //Defines the event handler 
        public event EventHandler<CreateWall_AddPanelEventArgs> CreateWallEventHandler;
        private void OnCreateWall(CreateWall_AddPanelEventArgs e)
        {
            EventHandler<CreateWall_AddPanelEventArgs> handler = CreateWallEventHandler;
            if (handler != null)
            {
                handler(this, e);
            }

        }
        
        public void WallPanel_Click(int X, int Y)
        {

        
            
            //Creates the name of the new hold 
            string HoldName = "pctBox_Hold" + Convert.ToString(HoldCount);
            //Dectects the X and Y co-ordinates of the click and assigns them to variables
            int xMouseClick = X;
            int yMouseClick = Y;
            // Creates an instance of the hold class, passing itself, the current instance into the hold, as well as the single instance of SaveWall
            Hold NewHold = new Hold(HoldName, this);
            //assigns the temporary picturebox as the picturebox created via CreateHold()
            pctBox_CurrentHold = NewHold.CreateHold();
           
            NewHold.AddHold(xMouseClick, yMouseClick, pctBox_CurrentHold, WallPanel, HoldCount);
            ListOfHolds.Add(NewHold);
            
        }

        public void CreateWallTextValidation(string WallHeight, string WallWidth)
        {
            
            double Value;
            // if the string entry cannot be parsed into a double value and isn't empty, an error saying that the text entered is not an integer 
            if (!double.TryParse(WallHeight, out Value) && !string.IsNullOrEmpty(WallHeight))
            {
                //resets the entry boxes to show nothing, prompting another user entry 
                WallWidth = "";
                WallHeight = "";
                //exception is thrown to be caught in wallbuild user control
                throw new CreateWall_InvalidTextException();
            }
            else if (!double.TryParse(WallWidth, out Value) && !string.IsNullOrEmpty(WallWidth))
            {
                
                WallWidth = "";
                WallHeight = "";
                //exception thrown to be caught in wall build user control
                throw new CreateWall_InvalidTextException();
            }
            else if (string.IsNullOrEmpty(WallHeight))
            {// exception to be caught in wall builder user control 
                throw new CreateWall_InvalidPresenceCheck();
            }
            else if (string.IsNullOrEmpty(WallWidth))
            {
                throw new CreateWall_InvalidPresenceCheck();
            }

        }
        public void CreateWallSizeValidation(string WallHeight, string WallWidth)
        { 
            int MaxValueHeight = 700;
            int MinValueHeight = 300;
            int MaxValueWidth = 400;
            int MinValueWidth = 150;


            if (int.Parse(WallHeight) > MaxValueHeight || int.Parse(WallWidth) > MaxValueWidth)
            {
               
                WallWidth = "";
                WallHeight = "";
                throw new CreateWall_InvalidSizeException();
            }

            else if (int.Parse(WallHeight) < MinValueHeight || int.Parse(WallWidth) < MinValueWidth)
            {
                
                WallWidth = "";
                WallHeight = "";
                throw new CreateWall_InvalidSizeException();
            }
           
        }
        // Onclick event for WallPanel
        

        //onclick event and paint event for every button... There must be a better way?? investigate using OOP to solve problem
        
        public void SaveWall()
        {
            
            string value = "";
            if (InputBox.inputBox("Enter the name of your wall (this will be its file name)", "Save Wall", ref value) == DialogResult.OK)
            {
                string WallName = value;
                 
                
                //Finds the file path of the entire project 
                string ProjectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                // Creates the file in the project file 
                string FilePath = ProjectPath + @"\" + WallName + ".Climb";
                MessageBox.Show("here is the file path: " + FilePath);
                
                SavedWall Wall = new SavedWall(FilePath, WallPanel.Height, WallPanel.Width);
                foreach (var Hold in ListOfHolds)
                {
                    Wall.AddHolds(Hold.HoldName, Hold.pctBox_CurrentHold.Location, Hold.HoldShape, HoldColour);
                }
                wallSerializer.Serialize(Wall, FilePath);
            }
            
        }

        public void Load()
        {
            LoadWall = true;
            SavedWall sw = (SavedWall)wallSerializer.DeSerialize(WallFilePath);
            CreateWall(sw.WallWidth, sw.WallHeight);
            AddHoldsFromSave(sw, WallPanel, HoldCount);
        }

        public void AddHoldsFromSave(SavedWall sw,Panel WallPanel, int HoldCount)
        {
            foreach (List<object> hold in sw.ListOfHolds)
            {
                //Creates new hold which the saved attributes can be applied to  
                //uses the fist item in the hold list (the HoldName) as an argument for creating the hold
                Hold NewHold = new Hold((string)(hold[0]), this);
                //Creates hold using the colour from save (item 4 in list) as an argument
                NewHold.CreateAndAddHoldFromSave((Point)hold[1], (Point[])hold[2], (string)hold[3], WallPanel, HoldCount);


            }


        }
    }
}

