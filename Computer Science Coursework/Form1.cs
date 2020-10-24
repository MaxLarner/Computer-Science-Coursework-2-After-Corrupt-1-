using Computer_Science_Coursework.exceptions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;


namespace Computer_Science_Coursework
{

    public partial class Form1 : Form

    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        //creates an instance of the WallBuild class
        WallBuild WallBuild = new WallBuild();
   
        private void pctBox_GreenHoldButton_Click(object sender, EventArgs e)
        {
            WallBuild.HoldColour = "Green";
        }

        private void pctBox_BlueHoldButton_Click(object sender, EventArgs e)
        {
            WallBuild.HoldColour = "Blue";
        }

        private void pctBox_RedHoldButton_Click(object sender, EventArgs e)
        {
            WallBuild.HoldColour = "Red";
        }

        private void pctBox_PurpleHoldButton_Click(object sender, EventArgs e)
        {
            WallBuild.HoldColour = "Purple";
        }

        private void btn_WallSubmit_Click(object sender, EventArgs e)
        {


            int WallWidth = int.Parse(txt_WallWidth.Text);
            int WallHeight = int.Parse(txt_WallHeight.Text);



            try
            {
                WallBuild.CreateWallTextValidation(txt_WallHeight.Text, txt_WallWidth.Text);
                WallBuild.CreateWallSizeValidation(txt_WallHeight.Text, txt_WallWidth.Text);
                WallBuild.CreateWall(WallWidth, WallHeight);
                WallBuild.WallPanelSizeTest(WallWidth, WallHeight);

            }

            catch (CreateWall_InvalidTextException ex)
            {
                MessageBox.Show("data entered is not a valid number, please try again");
            }

            catch (CreateWall_InvalidSizeException ex)
            {
                MessageBox.Show("this wall is too small! Make sure it's more than 1.5m Wide and 3m tall");
            }
            


                //Passes The desired height and Width of the wall to the create wall Function

            
        }
    }


    //by creating a static class of global variables, i am able to access them interchangably between classes, which is useful as often i need to share pctBox_Current Hold between classes and am unable to pass it via an argument as it would be out of order 
    public static class Global
    {
        public static Panel WallPanel = new Panel();
    }
}
