﻿using Computer_Science_Coursework.exceptions;
using Computer_Science_Coursework.Events;
using System;
using System.Windows.Forms;
using System.Net.NetworkInformation;

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
            MessageBox.Show("button clicked");
            WallBuild.HoldColour = "Green";
        }

        private void pctBox_BlueHoldButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button clicked");
            WallBuild.HoldColour = "Blue";
        }

        private void pctBox_RedHoldButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button clicked");
            WallBuild.HoldColour = "Red";
        }

        private void pctBox_PurpleHoldButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button clicked");
            WallBuild.HoldColour = "Purple";     
        }

        private void btn_WallSubmit_Click(object sender, EventArgs e)


        {


            string WallWidth = txt_WallWidth.Text;
            string WallHeight = txt_WallHeight.Text;

            try
            {
                WallBuild.CreateWallTextValidation(WallHeight, WallWidth);
                WallBuild.CreateWallSizeValidation(txt_WallHeight.Text, txt_WallWidth.Text);
                WallBuild.CreateWallEventHandler += WallBuild_CreateWallEventHandler;
                WallBuild.CreateWall(int.Parse(txt_WallWidth.Text), int.Parse(txt_WallHeight.Text));
                
                WallBuild.WallPanelSizeTest(int.Parse(txt_WallWidth.Text), int.Parse(txt_WallHeight.Text));
                
            }

            catch (CreateWall_InvalidTextException)
            {
                MessageBox.Show("data entered is not a valid number, please try again");
            }

            catch (CreateWall_InvalidSizeException)
            {
                MessageBox.Show("this wall is too small! Make sure it's more than 1.5m Wide and 3m tall");
            }

            catch (CreateWall_PanelTest)
            {
                MessageBox.Show("there was an error when creating the wall panel");
            }



            //Passes The desired height and Width of the wall to the create wall Function


        }
        
        //Event Handler for adding the control to the wall 
        private void WallBuild_CreateWallEventHandler(object sender, CreateWall_AddPanelEventArgs e)
        {
            //adds the controll panel passed through the event handler to the form
            Controls.Add(e.WallPanel);
        }

        //Moved click event to the main form 
        public void WallPanel_Click(object sender, MouseEventArgs e)
        {
            
            MessageBox.Show("wall panel clicked");
            WallBuild.WallPanel_Click(e.X, e.Y);   
        }
        // paint event for the pictureboxes 
       
     }


    //by creating a static class of global variables, i am able to access them interchangably between classes, which is useful as often i need to share pctBox_Current Hold between classes and am unable to pass it via an argument as it would be out of order 
    public static class Global
    {
        public static Panel WallPanel = new Panel();
    }
}
