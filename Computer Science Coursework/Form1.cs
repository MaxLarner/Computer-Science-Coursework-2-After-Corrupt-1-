using DocumentFormat.OpenXml.InkML;
using GemBox.Document.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace Computer_Science_Coursework
{
    public partial class Form1 : Form
    {
        int HoldCount = 0;
        //Bool values to decide which hold has been selected
        bool Red = false;
        bool Green = false;
        bool Blue = false;

        //Defines the wall panel 
        Panel WallPanel = new Panel();
        //Defines the picture boxes for each hold "is there a better way to do this? revisit..."
        PictureBox pctBox_GreenHold = new PictureBox();
        PictureBox pctBox_BlueHold = new PictureBox();
        PictureBox pctBox_RedHold = new PictureBox();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_WallSubmit_Click(object sender, EventArgs e)
        {
            int WallWidth = int.Parse(txt_WallWidth.Text);
            int WallHeight = int.Parse(txt_WallHeight.Text);

            MessageBox.Show(txt_WallWidth.Text + ", " + txt_WallHeight.Text, "Wall Size");
            //Passes The desired height and Width of the wall to the create wall Function
            CreateWall(WallWidth, WallHeight);
        }

        private void CreateWall(int X, int Y)
        { 
            // Create a panel called "WallPanel@
            WallPanel.Location = new System.Drawing.Point(300, 50);
            WallPanel.Name = "pnl_ClimbingWall";
            // Assigns the size the dimentions passed to the subroutine...
            //...from WallWidth and Wall Height in the WallSubmit click event
            WallPanel.Size = new System.Drawing.Size(X, Y);
            WallPanel.BackColor = Color.LightGreen;
            //Dynamically Creates a click event for "WallPanel" to dectect when its been clicked 
            WallPanel.MouseClick+=WallPanel_Click;
            //Adds "WallPanel" to the form
            Controls.Add(WallPanel);
        }

        private void AddHold(int x, int y, PictureBox pctBox_Hold)
        {
            //Asigns the picturebox passed in (the Hold) a numbered name 
            pctBox_Hold.Name = "pctBox_Hold" + Convert.ToString(HoldCount);
            //Assigns the location of the picturebox on the wall, position passed in from the WallPanel Click event
            pctBox_Hold.Location = new Point(x, y);
            //increases the hold count to make sure the next hold added has a unique name
            HoldCount++;
            //Adds the hold to the WallPanel
            WallPanel.Controls.Add(pctBox_Hold);
        }
        // Onclick event for WallPanel
        private void WallPanel_Click(object sender, MouseEventArgs e)
        {
            //Dectects the X and Y co-ordinates of the click and assigns them to variables
            int xMouseClick = e.X;
            int yMouseClick = e.Y;

            //Used for my own testing perpouses, not a feature 
            MessageBox.Show(Convert.ToString(xMouseClick), Convert.ToString(yMouseClick));

            //Creates a temporary picturebox that can be assigned the value of a hold picturebox... 
            //...This is so any picture box can be passed into the add hold function
            PictureBox pctBox_Temp = new PictureBox();
            
            if (Blue == true)
            {
                pctBox_Temp = pctBox_BlueHold;
                //paints the picturebox with a unique shape to the Form
                //the picturebox itself is added to the panel in the AddHold() Function
                pctBox_Temp.Paint += new PaintEventHandler(pctBox_BlueHold_Paint);
            }
            else if (Green == true)
            {
                pctBox_Temp = pctBox_GreenHold;
                pctBox_Temp.Paint += new PaintEventHandler(pctBox_GreenHold_Paint);
            }
            else if (Red == true)
            {
                pctBox_Temp = pctBox_RedHold;
                pctBox_Temp.Paint += new PaintEventHandler(pctBox_RedHold_Paint);
            }

            AddHold(xMouseClick, yMouseClick, pctBox_Temp);
        }
        
        //onclick event and paint event for every button... There must be a better way?? investigate using OOP to solve problem
        public void pctBox_GreenHoldButton_Click(object sender, EventArgs e)
        { 
            //When the Greenhold button has been selected, it sets Green to true and others to false 
            Green = true;
            Red = false;
            Blue = false;
        }

        private void pctBox_GreenHold_Paint(object sender, PaintEventArgs e)
        {
            pctBox_GreenHold.BackColor = Color.Green;

            //Creates a new graphics path that the hold shape can be added to
            GraphicsPath pctBox_Path = new GraphicsPath();

            // Creates a polygon using an array of points called GreenShape

            Point[] GreenShape =
                {
                    new Point(23, 20),
                    new Point(40, 10),
                    new Point(57, 20),
                    new Point(50, 40),
                    new Point(30, 40)
                    };

            // Adds the polygon to the graphics path
            pctBox_Path.AddPolygon(GreenShape);

            //the region of the picturebox is now set to the shape of the graphics path
            pctBox_GreenHold.Region = new Region(pctBox_Path);
        }

        public void pctBox_BlueHoldButton_Click(object sender, EventArgs e)
        {
            Green = false;
            Blue = true;
            Red = false;
        }

        private void pctBox_BlueHold_Paint(object sender, PaintEventArgs e)
        {
            pctBox_BlueHold.BackColor = Color.Blue;

            GraphicsPath pctBox_Path = new GraphicsPath();

            // The points of the rhombus in n array, creates the polygon
            Point[] Rhombus =
                {
                    new Point(-2, 12),
                    new Point(32, 13),
                    new Point(41, 40),
                    new Point(61, 41),
                    new Point(32, 46)
                    };

            // Adds the rhombus to the graphics path

            pctBox_Path.AddPolygon(Rhombus);

            //the region of the picturebox is now set to the shape of the graphics path
            pctBox_BlueHold.Region = new Region(pctBox_Path);
        }

        private void pctBox_RedHoldButton_Click(object sender, EventArgs e)
        {
            Green = false;
            Red = true;
            Blue = false;
        }

        public void pctBox_RedHold_Paint(object sender, PaintEventArgs e)
        {

            pctBox_RedHold.BackColor = Color.Red;

            GraphicsPath pctBox_Path = new GraphicsPath();

            // The points of the rhombus in n array, creates the polygon
            Point[] Rhombus =
                {
                    new Point(-23, -10),
                    new Point(20, 5),
                    new Point(26, 10),
                    new Point(25, 20),
                    new Point(15, 20)
                    };

            // Adds the rhombus to the graphics path

            pctBox_Path.AddPolygon(Rhombus);

            //the region of the picturebox is now set to the shape of the graphics path
            pctBox_RedHold.Region = new Region(pctBox_Path);
        }
    }
}
