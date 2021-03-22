using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Computer_Science_Coursework.exceptions;
using Computer_Science_Coursework.Events;

namespace Computer_Science_Coursework
{
    public partial class BuildWallScreen : UserControl
    {
        //Creates an instance of wall build and selectSavedWall, this can be the 
        public WallBuild wb = new WallBuild();
        
        public static BuildWallScreen _instance;
        public static BuildWallScreen Instance
        {
            get
            {
                if (_instance==null)
                {
                    _instance = new BuildWallScreen();
                }
                return _instance; 
            }
        }
        Panel pnl_Screen = Application.OpenForms["Form1"].Controls["pnl_Screen"] as Panel;
        private void btn_ReturnHome_Click(object sender, EventArgs e)
        {
            if (!pnl_Screen.Controls.Contains(SelectionScreen.Instance))
            {
                pnl_Screen.Controls.Add(SelectionScreen.Instance);
                SelectionScreen.Instance.Dock = DockStyle.Fill;
                SelectionScreen.Instance.BringToFront();
            }
            else
            {
                SelectionScreen.Instance.BringToFront();
            }

            
            Controls.Remove(Controls.Find("pnl_ClimbingWall", true)[0]);
        }

       
        public BuildWallScreen()
        {
            InitializeComponent();
         
        }

        


        //sets wb.set colour to green on button click 
        private void pctBox_GreenHoldButton_Click(object sender, EventArgs e)
        {
            wb.setColour("Green");
            
        }
        //sets wb.set colour to blue on button click 
        private void pctBox_BlueHoldButton_Click(object sender, EventArgs e)
        {
            wb.setColour("Blue");
            
        }
        //sets wb.set colour to red on button click 
        private void pctBox_RedHoldButton_Click(object sender, EventArgs e)
        {

            wb.setColour("Red");
            
        }
        //sets wb.set colour to pruple on button click 
        private void pctBox_PurpleHoldButton_Click(object sender, EventArgs e)
        {
            wb.setColour("Purple");

            
        }

        private void btn_WallSubmit_Click(object sender, EventArgs e)
        {
            CreateWallFromSubmit();
        }

        public void CreateWallFromSubmit()
        {
            
                string WallWidth = txt_WallWidth.Text;
                string WallHeight = txt_WallHeight.Text;

                try
                {

                    //Validates the input using functions from instantiated Wallbuild
                    wb.CreateWallTextValidation(WallHeight, WallWidth);
                    wb.CreateWallSizeValidation(txt_WallHeight.Text, txt_WallWidth.Text);
                    //triggers the event handler 
                    wb.CreateWallEventHandler += WallBuild_CreateWallEventHandler;
                    wb.CreateWall(int.Parse(txt_WallWidth.Text), int.Parse(txt_WallHeight.Text));

                    wb.WallPanelSizeTest(int.Parse(txt_WallWidth.Text), int.Parse(txt_WallHeight.Text));

                }
                //Catches errors thrown up from the validation functions in wall build
                catch (CreateWall_InvalidTextException)
                {
                    MessageBox.Show("data entered is not a valid , please try again");
                }

                catch (CreateWall_InvalidSizeException)
                {
                    MessageBox.Show("This wall size is out of bounds. Make sure it's more than 1.5m Wide and 3m tall, but less than 4m wide and 7m Tall");
                }

                catch (CreateWall_PanelTest)
                {
                    MessageBox.Show("there was an error when creating the wall panel");
                }
                catch (CreateWall_InvalidPresenceCheck)
                {
                    MessageBox.Show("Not all fields have been filled. Please enter a height and width (cm)");
                }
            }

        //Checks to see if it is creating a wall from load, and if so, does. 
        public void CreateWallFromLoad()
        {
            
         wb.CreateWallEventHandler += WallBuild_CreateWallEventHandler;
         wb.Load();
            
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
            wb.WallPanel_Click(e.X, e.Y);
        }

        private void btn_SaveWall_Click(object sender, EventArgs e)
        {
            wb.SaveWall();
        }
    }
}
