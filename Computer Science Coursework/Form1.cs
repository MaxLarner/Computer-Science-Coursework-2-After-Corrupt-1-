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
        string HoldColour;
        bool CorrectWallSize = false;

        //Defines the wall panel 
        Panel WallPanel = new Panel();
        //Defines the picture boxes for each hold "is there a better way to do this? revisit..."
        PictureBox pctBox_CurrentHold = new PictureBox();

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
            CreateWallValidation();
            MessageBox.Show(txt_WallWidth.Text + ", " + txt_WallHeight.Text, "Wall Size");
            //Passes The desired height and Width of the wall to the create wall Function

            if (CorrectWallSize == true)
                {
                CreateWall(WallWidth, WallHeight);
                }
            
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

        private void CreateWallValidation()
        {
            int MaxValueHeight = 700;
            int MinValueHeight = 300;
            int MaxValueWidth = 400;
            int MinValueWidth = 150;

            if (int.Parse(txt_WallHeight.Text) > MaxValueHeight || int.Parse(txt_WallWidth.Text) > MaxValueWidth)
             {
                MessageBox.Show("this wall is too big! Make sure it's less than 4m Wide and 7m tall");
                txt_WallWidth.Text = "";
                txt_WallHeight.Text = "";
                CorrectWallSize = false;
             }

            else if (int.Parse(txt_WallHeight.Text) < MinValueHeight || int.Parse(txt_WallWidth.Text) < MinValueWidth)
            {
                MessageBox.Show("this wall is too small! Make sure it's more than 1.5m Wide and 3m tall");
                txt_WallWidth.Text = "";
                txt_WallHeight.Text = "";
                CorrectWallSize = false;
            }
            else
            {
                CorrectWallSize = true;
            }
        }

       
        // Onclick event for WallPanel
        private void WallPanel_Click(object sender, MouseEventArgs e)
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
        public void pctBox_GreenHoldButton_Click(object sender, EventArgs e)
        {
            HoldColour = "Green";
        }
        public void pctBox_BlueHoldButton_Click(object sender, EventArgs e)
        {
            HoldColour = "Blue";
        }
        private void pctBox_RedHoldButton_Click(object sender, EventArgs e)
        {
            HoldColour = "Red";
        }
    }
    /// Creating a class for holds 
    public class Hold
    {
        PictureBox pctBox_CurrentHold = new PictureBox();
        public string HoldName;
        public string HoldColour;
        public Point[] HoldShape;


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
                else
                {
                    pctBox_Hold.BackColor = Color.Green;
                }
            pctBox_CurrentHold = pctBox_Hold;
            return pctBox_Hold;
            
        }
        public void AddHold(int x, int y, PictureBox pctBox_Hold, Panel WallPanel, int HoldCount)
        {
            //Assigns the location of the picturebox on the wall, position passed in from the WallPanel Click event
            pctBox_Hold.Location = new Point(x, y);
            //increases the hold count to make sure the next hold added has a unique name
            HoldCount++;
            //Adds the hold to the WallPanel
            WallPanel.Controls.Add(pctBox_Hold);
            pctBox_Hold.Paint += new PaintEventHandler(pctBox_Hold_Paint);


        }

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
