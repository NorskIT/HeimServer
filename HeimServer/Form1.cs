using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HeimServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AddCustomFont();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] colors = { "white", "aqua", "black", "blue", "brown", "cyan", "darkblue", "fuchsia", "green", "grey", "lightblue", "lime", "magenta", "maroon", "navy", "olive", "orange", "purple", "red", "silver", "teal", "yellow" };
            foreach (String color in colors)
            {
                colorSelector.Items.Add(color);
            }
            colorSelector.SelectedIndex = 0;
            serverNamePreview.Text = serverNameBox.Text;

        }

        private void CreateFileButton_Click(object sender, EventArgs e)
        {
            
            String serverNameStr = CreateServerName();
            String passStr = passBox.Text;
            String portStr = portBox.Text;
            String worldStr = worldBox.Text;
            String txt = "@echo off";
            txt += "\nset SteamAppId=892970";
            txt += "\necho \"Made with 'HeimServer: Create server startup file'\" ";
            txt += "\n";
            txt += "\necho \"Starting server PRESS CTRL-C to exit\" ";
            txt += "\nvalheim_server -nographics -batchmode -name \"" + serverNameStr + "\" -port " + portStr + " -world \"" + worldStr + "\" -password \"" + passStr + "\"";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "start_headless_server.bat";
            saveFileDialog.Filter = "Bat files (*.bat)|*.bat|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, txt);
            }

        }

        private String CreateServerName()
        {
            String txt = "<color=" + ((String)colorSelector.SelectedItem) + ">" + serverNameBox.Text + "</color>";
            if(boldCheckBox.Checked && italicCheckBox.Checked)
            {
                txt = "<b><i>" + txt + "</b></i>";
            }
            else if(boldCheckBox.Checked)
            {
                txt = "<b>" + txt + "</b>";
            }
            else if (italicCheckBox.Checked)
            {
                txt = "<i>" + txt + "</i>";
            }
            return txt;
        }

        private void AddCustomFont()
        {
            PrivateFontCollection averiaRegular = new PrivateFontCollection();
            int fontLength = Properties.Resources.AveriaSansLibre_Regular.Length;
            byte[] fontdata = Properties.Resources.AveriaSansLibre_Regular;
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontdata, 0, data, fontLength);
            averiaRegular.AddMemoryFont(data, fontLength);
            serverNamePreview.Font = new Font(averiaRegular.Families[0], serverNamePreview.Font.Size);
        }

        private void ServerNameBox_TextChanged(object sender, EventArgs e)
        {
            serverNamePreview.Text = ((TextBox)sender).Text;
        }

        private void ColorSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            serverNamePreview.ForeColor = Color.FromName(((String)((ComboBox)sender).SelectedItem));
        }

        private void BoldCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (serverNamePreview.Font.Italic)
            {
                serverNamePreview.Font = new Font(serverNamePreview.Font, ((CheckBox)sender).Checked ? (FontStyle.Bold | FontStyle.Italic) : FontStyle.Italic);
            }
            else
            {
                serverNamePreview.Font = new Font(serverNamePreview.Font, ((CheckBox)sender).Checked ? FontStyle.Bold : FontStyle.Regular);
            }
        }

        private void ItalicCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (serverNamePreview.Font.Bold)
            {
                serverNamePreview.Font = new Font(serverNamePreview.Font, ((CheckBox)sender).Checked ? (FontStyle.Bold | FontStyle.Italic) : FontStyle.Bold);
            }
            else
            {
                serverNamePreview.Font = new Font(serverNamePreview.Font, ((CheckBox)sender).Checked ? FontStyle.Italic : FontStyle.Regular);
            }
        }
    }
}
