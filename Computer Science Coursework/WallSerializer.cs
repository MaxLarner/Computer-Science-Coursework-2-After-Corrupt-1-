using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Computer_Science_Coursework
{
    class WallSerializer
    {
        public void Serialize(object Wall, string FilePath)
        {
            FileStream fileStream;
            BinaryFormatter formatter = new BinaryFormatter();
            //Checks if file exists, if it does it is deleted and replaced. In other words , updated
            if (File.Exists(FilePath))
            {
                //informs user the file is being rewritten
                MessageBox.Show("Your save has been updated");
                File.Delete(FilePath);
            }
            fileStream = File.Create(FilePath);
            formatter.Serialize(fileStream, Wall);
            fileStream.Close();

        }

        public object DeSerialize(string FilePath)
        {
            //If deserialisation fails, Null is returned which can be caught in a try catch later 
            object Wall = null;
            FileStream fileStream;
            BinaryFormatter formatter = new BinaryFormatter();
            // Tests to see if the file actually exists else null is returned
            if (File.Exists(FilePath))
            {
                fileStream = File.OpenRead(FilePath);
                Wall = formatter.Deserialize(fileStream);
                fileStream.Close(); 
            }

            return Wall; 

        }
    }
}
