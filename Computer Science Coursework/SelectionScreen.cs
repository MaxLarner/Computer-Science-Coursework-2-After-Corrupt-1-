using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Computer_Science_Coursework
{
    public partial class SelectionScreen : UserControl
    {
        private static SelectionScreen _instance;
        public static SelectionScreen Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SelectionScreen();
                }
                return _instance;
            }
        }
        public SelectionScreen()
        {
            InitializeComponent();
        }
        private void SelectionScreen_Load(object sender, EventArgs e)
        {

        }

        Panel pnl_Screen = Application.OpenForms["Form1"].Controls["pnl_Screen"] as Panel;

        private void btn_BuildWall_Click(object sender, EventArgs e)
        {
            
            if(!pnl_Screen.Controls.Contains(BuildWallScreen.Instance))
            {
                pnl_Screen.Controls.Add(BuildWallScreen.Instance);
                BuildWallScreen.Instance.Dock = DockStyle.Fill;
                BuildWallScreen.Instance.BringToFront();
            }
            else
            {
                BuildWallScreen.Instance.BringToFront();
            }
        }
    }
}
