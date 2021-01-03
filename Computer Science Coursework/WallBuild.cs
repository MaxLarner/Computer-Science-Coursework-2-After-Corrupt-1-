using Computer_Science_Coursework.exceptions;
using Computer_Science_Coursework.Events;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;


namespace Computer_Science_Coursework
{
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


        int HoldCount = 0;
        SaveWall sw = new SaveWall();
        //Defines the wall panel 
        Panel WallPanel = Global.WallPanel;
        PictureBox pctBox_CurrentHold = new PictureBox();


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

            MessageBox.Show("Wall Panel Click event done. The value of the hold colour is: " + HoldColour);
            
            //Creates the name of the new hold 
            string HoldName = "pctBox_Hold" + Convert.ToString(HoldCount);
            //Dectects the X and Y co-ordinates of the click and assigns them to variables
            int xMouseClick = X;
            int yMouseClick = Y;
            // Creates an instance of the hold class, passing itself, the current instance into the hold.
            Hold NewHold = new Hold(HoldName, this);
            //assigns the temporary picturebox as the picturebox created via CreateHold()
            pctBox_CurrentHold = NewHold.CreateHold();
            MessageBox.Show("about to run addhold function");
            NewHold.AddHold(xMouseClick, yMouseClick, pctBox_CurrentHold, WallPanel, HoldCount);
            
        }

        public void CreateWallTextValidation(string WallHeight, string WallWidth)
        {
            
            double Value;

            if (!double.TryParse(WallHeight, out Value))
            {
                
                WallWidth = "";
                WallHeight = "";
                throw new CreateWall_InvalidTextException();
            }
            else if (!double.TryParse(WallWidth, out Value))
            {
                
                WallWidth = "";
                WallHeight = "";
                throw new CreateWall_InvalidTextException();
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
                throw new CreateWall_InvalidTextException();
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
        
    }
}

