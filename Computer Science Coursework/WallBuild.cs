﻿using Computer_Science_Coursework.exceptions;
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
        //instantiate an instance of Form1
       
        // setters and getters 
        public string HoldColour
        {
            get { return HoldColour; }
            set { HoldColour = value; }
        }

        public string WallHeight
        {
            get { return WallHeight; }
            set { WallHeight = value; }
        }

        

        int HoldCount = 0;
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
            // Create a panel called "WallPanel@
            WallPanel.Location = new System.Drawing.Point(300, 50);
            WallPanel.Name = "pnl_ClimbingWall";
            // Assigns the size the dimentions passed to the subroutine...
            //...from WallWidth and Wall Height in the WallSubmit click event
            WallPanel.Size = new System.Drawing.Size(X, Y);
            WallPanel.BackColor = Color.LightGreen;
            //Dynamically Creates a click event for "WallPanel" to dectect when its been clicked 
            WallPanel.MouseClick += WallPanel_Click;
            //Adds "WallPanel" to the form
            Form1 form = new Form1();
            form.Controls.Add(WallPanel);
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
        public void WallPanel_Click(object sender, MouseEventArgs e)
        {
            //Creates the name of the new hold 
            string HoldName = "pctBox_Hold" + Convert.ToString(HoldCount);
            //Dectects the X and Y co-ordinates of the click and assigns them to variables
            int xMouseClick = e.X;
            int yMouseClick = e.Y;

            // Creates an instance of the hold class 
            Hold NewHold = new Hold(HoldName, HoldColour);
            PictureBox pctBox_Temp = new PictureBox();
            //assigns the temporary picturebox as the picturebox created via CreateHold()
            pctBox_CurrentHold = NewHold.CreateHold();
            NewHold.AddHold(xMouseClick, yMouseClick, pctBox_CurrentHold, WallPanel, HoldCount);
        }

        //onclick event and paint event for every button... There must be a better way?? investigate using OOP to solve problem
        
    }
}

