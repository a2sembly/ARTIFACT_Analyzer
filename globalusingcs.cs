global using System;
global using System.Collections.Generic;
global using System.Linq;
global using System.Text;
global using System.Windows.Forms;
global using System.Threading.Tasks;
global using MetroFramework.Forms;
global using MetroFramework.Controls;
global using System.Diagnostics;

namespace ARTIFACT_Analyzer
{
    internal class Setting
    {
        public string Amcache = null;
        public string Appcompatcache = null;
        public string Prefetch = null;
        public string Jumplist = null;
        public string Lnk = null;
        public string Eventlog = null;
        public string Timeformat = null;
        public string SaveDir = Application.StartupPath + "Result_Artifact";

    public string OP_File()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.Filter = "All files (*) | *.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                openFileDialog.FilterIndex = 0;
                openFileDialog.RestoreDirectory = true;
            }
            return openFileDialog.FileName;
        }
    }
}
