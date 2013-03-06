using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bb_Assignment_Sorter
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void chooseFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderChooser.ShowDialog(this);

            if (result == DialogResult.OK)
                SortFiles(folderChooser.SelectedPath);
        }

        private void SortFiles(string basePath)
        {
            // Get files in directory
            string[] files = Directory.GetFiles(basePath);
            foreach (string filePath in files)
            {
                string fileName = filePath.Split("\\".ToCharArray()).Last();
                string newName = new Regex("^.+?_").Replace(fileName,"");
                string userDir = basePath + "\\" + newName.Split("_".ToCharArray()).First();
                string newPath = userDir + "\\" + newName;

                if (!Directory.Exists(userDir))
                    Directory.CreateDirectory(userDir);

                if (keepOriginals.Checked)
                    File.Copy(filePath, newPath);
                else
                    File.Move(filePath, newPath);

                this.Close();
            }
        }

        private void dropArea_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void dropArea_DragDrop(object sender, DragEventArgs e)
        {
            string[] folders = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string folderName in folders)
                SortFiles(folderName);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (Program.folders != null)
            {
                foreach (string folderName in Program.folders)
                    SortFiles(folderName);

                this.Close();
            }
        }
    }
}
