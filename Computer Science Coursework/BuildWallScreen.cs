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
        WallBuild wb = new WallBuild();
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
        int PanelWidth;
        bool HidePanel;
        public BuildWallScreen()
        {
            InitializeComponent();
            PanelWidth = pnl_SlideOutWallBuild.Width;
            HidePanel = false;
        }
        private void btn_DimensionsSlideButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (HidePanel)
            {
                pnl_SlideOutWallBuild.Width = pnl_SlideOutWallBuild.Width + 20;

                if (pnl_SlideOutWallBuild.Width >= PanelWidth)
                {
                    timer1.Stop();
                    HidePanel = false;
                    this.Refresh();
                }

                else
                {
                    pnl_SlideOutWallBuild.Width = pnl_SlideOutWallBuild.Width - 20;

                    if (pnl_SlideOutWallBuild.Width <= 0)
                    {
                        timer1.Stop();
                        HidePanel = true;
                        this.Refresh();
                    }
                }
            }

        }

        private void BuildWallScreen_Load(object sender, EventArgs e)
        {

        }
        
        private void pctBox_GreenHoldButton_Click(object sender, EventArgs e)
        {
            wb.setColour("Green");
            
        }

        private void pctBox_BlueHoldButton_Click(object sender, EventArgs e)
        {
            wb.setColour("Blue");
            
        }

        private void pctBox_RedHoldButton_Click(object sender, EventArgs e)
        {

            wb.setColour("Red");
            
        }

        private void pctBox_PurpleHoldButton_Click(object sender, EventArgs e)
        {
            wb.setColour("Purple");

            
        }

        private void btn_WallSubmit_Click(object sender, EventArgs e)
        {
            string WallWidth = txt_WallWidth.Text;
            string WallHeight = txt_WallHeight.Text;

            try
            {

                wb.CreateWallTextValidation(WallHeight, WallWidth);
                wb.CreateWallSizeValidation(txt_WallHeight.Text, txt_WallWidth.Text);
                wb.CreateWallEventHandler += WallBuild_CreateWallEventHandler;
                wb.CreateWall(int.Parse(txt_WallWidth.Text), int.Parse(txt_WallHeight.Text));

                wb.WallPanelSizeTest(int.Parse(txt_WallWidth.Text), int.Parse(txt_WallHeight.Text));

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

        
    }
}
