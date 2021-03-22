using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Computer_Science_Coursework
{
    public partial class SelectSavedWallScreen : UserControl
    {
        SelectSavedWall ssw = new SelectSavedWall();
        //Define instances of form 1
        Panel pnl_Screen = Application.OpenForms["Form1"].Controls["pnl_Screen"] as Panel;
        //For moving between pages 
        private static SelectSavedWallScreen _instance;
        public static SelectSavedWallScreen Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SelectSavedWallScreen();
                }
                return _instance;
            }
        }
        

        public SelectSavedWallScreen()
        {
            InitializeComponent();
            ssw.LoadWallFiles(lstView_FileSelection);

        }
        private void SelectSavedWallScreen_Load(object sender, EventArgs e)
        {
            
        }

        

        private void lstView_FileSelection_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ssw.SelectionChange(e);
            
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            if (!pnl_Screen.Controls.Contains(BuildWallScreen.Instance))
            {
                pnl_Screen.Controls.Add(BuildWallScreen.Instance);
                BuildWallScreen.Instance.Dock = DockStyle.Fill;
                BuildWallScreen.Instance.BringToFront();
            }
            else
            {
                BuildWallScreen.Instance.BringToFront();
            }
            ssw.WallSelect();


        }

        //button takes user home 
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
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {

            ssw.LoadWallFiles(lstView_FileSelection);

        }
    }
    }

