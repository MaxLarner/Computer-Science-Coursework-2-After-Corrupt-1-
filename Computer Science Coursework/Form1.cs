
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
            pnl_Screen.Controls.Add(SelectionScreen.Instance);
        }
    }


    //by creating a static class of global variables, i am able to access them interchangably between classes, which is useful as often i need to share pctBox_Current Hold between classes and am unable to pass it via an argument as it would be out of order 
    public static class Global
    {
        public static Panel WallPanel = new Panel();
    }
}
