using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Computer_Science_Coursework
{
    class SelectSavedWall
    {
       
        string ProjectFilePath = @"C:\Users\max larner\source\repos\Computer-Science-Coursework-2-After-Corrupt-1-\Computer Science Coursework\bin";
        string WallFilePath;
        
        string SelectedWallName;
        WallSerializer Serializer = new WallSerializer();
        
       


        public void LoadWallFiles(ListView lstView_FileSelection)
        {
            DirectoryInfo WallFileList;

            //Creates a path to the VB projects Bin File List
            WallFileList = new DirectoryInfo(ProjectFilePath);
            //Gets the files from the Bin File
            FileInfo[] Walls = WallFileList.GetFiles();
            //Clears the list View of items so wall files do not duplicate upon refresh
            lstView_FileSelection.Clear();

            for (int i = 0; i < Walls.Length; i++)
            {
                //adds each file from the list of files into the list veiw so the user can select one, and index of image
                lstView_FileSelection.Items.Add(Walls[i].Name, 0);
            }
        }

        public void SelectionChange(ListViewItemSelectionChangedEventArgs e)
        {
            //Gets the name of the selected File 
            SelectedWallName = e.Item.Text;
            WallFilePath = ProjectFilePath + @"\" + SelectedWallName;
        }

        public void WallSelect()
        {
            //makes changes to the instance of wall build in the BuildWallScreen
            BuildWallScreen.Instance.wb.WallFilePath = WallFilePath;
            //Tells buildwall to create a wall from load when it switches to the new usercontrol
            BuildWallScreen.Instance.CreateWallFromLoad();
            
            
        }
    }
}
