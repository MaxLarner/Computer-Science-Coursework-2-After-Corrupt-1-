using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace Computer_Science_Coursework
{
    class Hold
    {
        //bool PermissionToAddHold;
        PictureBox pctBox_CurrentHold = new PictureBox();
        string HoldName;
        string HoldColour;
        Point[] HoldShape;
        Panel WallPanel = Global.WallPanel;
        public Hold(string Name, string Colour)
        {
            HoldName = Name;
            HoldColour = Colour;
        }

        public PictureBox CreateHold()
        {
            PictureBox pctBox_Hold = new PictureBox();
            pctBox_Hold.Name = HoldName;
            // deciding colour of hold
            if (HoldColour == "Red")
            {
                pctBox_Hold.BackColor = Color.Red;
            }
            else if (HoldColour == "Blue")
            {
                pctBox_Hold.BackColor = Color.Blue;
            }
            else if (HoldColour == "Green")
            {
                pctBox_Hold.BackColor = Color.Green;
            }
            else
            {
                pctBox_Hold.BackColor = Color.Purple;
            }

            pctBox_CurrentHold = pctBox_Hold;
            return pctBox_Hold;

        }
        public void AddHold(int x, int y, PictureBox pctBox_Hold, Panel WallPanel, int HoldCount)
        {
            // HoldPlaceValidation();

            //Assigns the location of the picturebox on the wall, position passed in from the WallPanel Click event
            pctBox_Hold.Location = new Point(x, y);
            //increases the hold count to make sure the next hold added has a unique name
            HoldCount++;
            //Adds the hold to the WallPanel
            WallPanel.Controls.Add(pctBox_Hold);
            pctBox_CurrentHold.Paint += new PaintEventHandler(pctBox_Hold_Paint);

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
        public void pctBox_Hold_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath pctBox_Path = new GraphicsPath();

            //Select Case for shape based on colours
            switch (HoldColour)
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

            // Adds the rhombus to the graphics path

            pctBox_Path.AddPolygon(HoldShape);

            //the region of the picturebox is now set to the shape of the graphics path
            pctBox_CurrentHold.Region = new Region(pctBox_Path);
        }
    }
}

