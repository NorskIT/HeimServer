using System;
using System.IO;
using System.Windows.Forms;

namespace HeimServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("Hello world");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CreateFileButton_Click(object sender, EventArgs e)
        {
            String txt = "";
            txt += "@echo off";
            txt += "\nset SteamAppId=892970";
            txt += "\necho \"Starting server PRESS CTRL-C to exit\"";
            txt += "\n";
            txt += "\nvalheim_server -nographics -batchmode -name \"" + ServerNameBox.Text + "\" -port " + PortBox.Text + " -world \"" + WorldBox.Text + "\" -password \"" + PassBox.Text + "\"";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "start_headless_server.bat";
            saveFileDialog.Filter = "Bat files (*.bat)|*.bat|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, txt);
            }

        }
    }
}
