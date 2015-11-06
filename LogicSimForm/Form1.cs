using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicSimForm
{
    public partial class Form1 : Form
    {
        List<wave> WaveList;
        List<Node> Net = new List<Node>();
        Dictionary<string, int> NodeNet = new Dictionary<string, int>();
        List<string> NodeNetRev = new List<String>();
        string FolderPath = "";
        string NetFile = @"E:\0DROPBOX\Dropbox\Corsi 14-15\C&G 14-15\Mod I\WORK\LogicSimForm\DATA\Net.txt";
        string StimFile = @"E:\0DROPBOX\Dropbox\Corsi 14-15\C&G 14-15\Mod I\WORK\LogicSimForm\DATA\Stimuli.txt";
        string OutFile = @"C:\Users\Luca\Desktop\Out.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void NetListBrowseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                NetFile = String.Copy(openFileDialog1.FileName);
                NetListTextBox.Text = NetFile;

            }
        }

        private void StimuliBrowseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StimFile = String.Copy(openFileDialog1.FileName);
                StimuliTextBox.Text = StimFile;
            }
        }

        private void OutputBrowseButton_Click(object sender, EventArgs e)
        {

            
            folderBrowserDialog1.Description =
            "Select the directory that you want to use as the default.";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                FolderPath = folderBrowserDialog1.SelectedPath;
                OutFile = FolderPath + "\\" + OutputTextBox.Text;
            }

        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            WorkingLabel.Text = "Working...";
            XMLNetLoad();
            XMLStimLoad();
            Simulate();
            WorkingLabel.Text = "Terminated";
        }

        private void OutputTextBox_Changed(object sender, EventArgs e)
        {
            OutFile = FolderPath + "\\" + OutputTextBox.Text;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
                    }
    }
}
