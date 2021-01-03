﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace Computer_Science_Coursework
{
    class Hold
    {
        InputBox InputBox = new InputBox();
        WallBuild wb;
        //instantiates an instance of the class save wall 
        SaveWall sw = new SaveWall();
        //bool PermissionToAddHold;
        PictureBox pctBox_CurrentHold = new PictureBox();
        string HoldName;
        Point[] HoldShape;
        bool Rotated = false;
        Panel WallPanel = Global.WallPanel;

       
        
        // creates a hold object
        public Hold(string Name, WallBuild wb)
        {
            this.HoldName = Name;
            //sets wallbuild wb from line 13 to the wall build instance passed into the constructor
            this.wb = wb;
        }

        
        public PictureBox CreateHold()
        {
           
            
            pctBox_CurrentHold.Name = HoldName;

            // deciding colour of hold
            // WallBuild.HoldColour is not setting the HoldColour to the same colour of the button, hence the else if statement was always choosing the purple hold 
            if (wb.getColour() == "Red")
            {
                pctBox_CurrentHold.BackColor = Color.Red;
            }
            else if (wb.getColour() == "Blue")
            {
                pctBox_CurrentHold.BackColor = Color.Blue;
            }
            else if (wb.getColour() == "Green")
            {
                pctBox_CurrentHold.BackColor = Color.Green;
            }
            else //(WallBuild.HoldColour == "Purple")
            { 
                pctBox_CurrentHold.BackColor = Color.Purple;
            }
            HoldDropDownMenu();
            return pctBox_CurrentHold;

        }
        public void AddHold(int x, int y, PictureBox pctBox_Hold, Panel WallPanel, int HoldCount)
        {
            

            //Assigns the location of the picturebox on the wall, position passed in from the WallPanel Click event
            pctBox_CurrentHold.Location = new Point(x, y);
            //increases the hold count to make sure the next hold added has a unique name
            HoldCount++;

            //Adds the hold to the WallPanel
            WallPanel.Controls.Add(pctBox_Hold);
            SaveWall SaveWall = new SaveWall();
            pctBox_CurrentHold.Paint += new PaintEventHandler(pctBox_Hold_Paint);
            MessageBox.Show("pctBox Paint Event Handled");

        }

        /* public void HoldPlaceValidation()
        {
            // loops through every picturebox on the webform 
            IEnumerable<PictureBox> Holds = WallPanel.Controls.OfType<PictureBox>();
            // Creates a HitBox around the hold
            Rectangle rect_CurrentHold = pctBox_CurrentHold.ClientRectangle;
            pctBox_CurrentHold.Bounds = rect_CurrentHold;


            foreach (PictureBox hold in Holds)
            {
                Rectangle rect_PlacedHold = hold.ClientRectangle;
                hold.Bounds = rect_PlacedHold;
                // checks to see if the hold about to be placed intersects with any other pictureboxes on the form 
                if (hold == pctBox_CurrentHold)
                {
                    //stops from compairing it to itself.
                    continue;
                }
                else
                {
                    if (pctBox_CurrentHold.Bounds.IntersectsWith(hold.Bounds))
                    {
                        MessageBox.Show("You Cannot Place Overlapping Holds");
                        PermissionToAddHold = false;
                    }
                    else
                    {
                        PermissionToAddHold = true;
                    }
                }
            }
        }
        */

        public void SetHoldShape()
        {
            if (Rotated != true)
            {

                //Select Case for shape based on colours
                switch (wb.getColour())
                {
                    case "Red":
                        Point[] RedShape =
                        {
                    new Point(-23, -10),
                    new Point(20, 5),
                    new Point(26, 10),
                    new Point(25, 20),
                    new Point(15, 20)
                    };
                        HoldShape = RedShape;
                        break;

                    case "Blue":
                        Point[] BlueShape =
                        {
                    new Point(-2, 12),
                    new Point(32, 13),
                    new Point(41, 40),
                    new Point(61, 41),
                    new Point(32, 46)
                    };
                        HoldShape = BlueShape;
                        break;

                    case "Purple":
                        Point[] PurpleShape =
                        {
                        new Point(-70, 80),
                        new Point(-30, 60),
                        new Point(70, 80),
                        new Point(80, 70),
                        new Point(40, 30),
                        new Point(60, -40),
                        new Point(50, -50),
                        new Point(-40, 20),
                        new Point(-80, 70),
                        new Point(-70, 80)
                    };
                        HoldShape = PurpleShape;
                        break;

                    default:
                        // Default case.
                        Point[] GreenShape =
                        {
                    new Point(23, 20),
                    new Point(40, 10),
                    new Point(57, 20),
                    new Point(50, 40),
                    new Point(30, 40)
                    };
                        HoldShape = GreenShape;
                        break;
                }
            }

        }
        public void pctBox_Hold_Paint(object sender, PaintEventArgs e)
        {
            
            GraphicsPath pctBox_CurrentHold_Path = new GraphicsPath();
            SetHoldShape();
            // Adds the rhombus to the graphics path
            pctBox_CurrentHold_Path.AddPolygon(HoldShape);
            //the region of the picturebox is now set to the shape of the graphics path
            pctBox_CurrentHold.Region = new Region(pctBox_CurrentHold_Path);
            
        }

        public void HoldDropDownMenu()
        {

            ContextMenuStrip HoldDropDownMenu = new ContextMenuStrip();

            ToolStripMenuItem menuEditSize = new ToolStripMenuItem("Edit Size");
            ToolStripMenuItem menuEditRotation = new ToolStripMenuItem("Edit Rotaion");
            ToolStripMenuItem menuDeleteHold = new ToolStripMenuItem("Delete Hold");
            //Assigning event handlers 
            menuEditSize.Click += new EventHandler(menuEditSize_Click);
            menuEditRotation.Click += new EventHandler(menuEditRotation_Click);
            menuDeleteHold.Click += new EventHandler(menuDeleteHold_Click);
            //Adds the items to the HoldDropDownMenu menu 
            HoldDropDownMenu.Items.AddRange(new ToolStripItem[] { menuEditSize, menuEditRotation, menuDeleteHold });

            pctBox_CurrentHold.ContextMenuStrip = HoldDropDownMenu;

        }

        private void menuDeleteHold_Click(object sender, EventArgs e)
        {
            DeleteHold();
        }

        private void menuEditRotation_Click(object sender, EventArgs e)
        {
            EditHoldRotation();
        }

        private void menuEditSize_Click(object sender, EventArgs e)
        {
            EditHoldsize();
        }
        public void EditHoldRotation()
        {
            
           string value = "";
           if (InputBox.inputBox("Enter the degree of rotation you would like to set to this hold", "Edit Hold Rotation", ref value) == DialogResult.OK)
            {
               double AngleOfRotation = Convert.ToInt32(value);
               this.HoldShape = RotateHold(AngleOfRotation); 
            }
            //repaints the hold object
            this.pctBox_CurrentHold.Paint += new PaintEventHandler(pctBox_Hold_Paint);

        }

        public Point[] RotateHold(double angleInDegrees)
        {
            //Allows the repaint method to know to use the new rotated shape
            Rotated = true; 
            //Creates a list as you cannot have an array of an unknown length in c#
            List<Point> RotatedHoldShapeList = new List<Point>();
            Point centerPoint = this.pctBox_CurrentHold.Location;
            double angleInRadians = angleInDegrees * (Math.PI / 180);
            double cosTheta = Math.Cos(angleInRadians);
            double sinTheta = Math.Sin(angleInRadians);

            foreach (Point p in HoldShape)
            {
                //replaces the holdshape so it can be repainted 
                RotatedHoldShapeList.Add(new Point
                {
                    X = (int)(cosTheta * (p.X - centerPoint.X) - sinTheta * (p.Y - centerPoint.Y) + centerPoint.X),
                    Y = (int)(sinTheta * (p.X - centerPoint.X) + cosTheta * (p.Y - centerPoint.Y) + centerPoint.Y)
                }
                );
            }
            //Converts the list to an Array 
            Point[] RotatedHoldShape = RotatedHoldShapeList.ToArray();
            return RotatedHoldShape;

            
        }

        public void EditHoldsize()
        {
            string value = "";
            if (InputBox.inputBox("Enter how big you would like this hold to be. For comparison, the size of the hold is currently set to 1", "Edit Hold size", ref value) == DialogResult.OK)
            {
                MessageBox.Show("the input was: " + value);
            }
        }

        public void DeleteHold()
        {
            MessageBox.Show("Delete Hold");
        }
    }
}

