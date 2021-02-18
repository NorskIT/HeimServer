
namespace HeimServer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.worldNameLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.serverNameBox = new System.Windows.Forms.TextBox();
            this.italicCheckBox = new System.Windows.Forms.CheckBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.ServernameLabel = new System.Windows.Forms.Label();
            this.portBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.boldCheckBox = new System.Windows.Forms.CheckBox();
            this.colourLabel = new System.Windows.Forms.Label();
            this.worldBox = new System.Windows.Forms.TextBox();
            this.colorSelector = new System.Windows.Forms.ComboBox();
            this.main = new System.Windows.Forms.Panel();
            this.serverNamePreview = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.createFileButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.main.SuspendLayout();
            this.SuspendLayout();
            // 
            // worldNameLabel
            // 
            this.worldNameLabel.AutoSize = true;
            this.worldNameLabel.Location = new System.Drawing.Point(12, 15);
            this.worldNameLabel.Margin = new System.Windows.Forms.Padding(5);
            this.worldNameLabel.Name = "worldNameLabel";
            this.worldNameLabel.Size = new System.Drawing.Size(70, 13);
            this.worldNameLabel.TabIndex = 0;
            this.worldNameLabel.Text = "World name :";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(23, 41);
            this.passLabel.Margin = new System.Windows.Forms.Padding(5);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(59, 13);
            this.passLabel.TabIndex = 0;
            this.passLabel.Text = "Password :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.serverNameBox);
            this.panel2.Controls.Add(this.italicCheckBox);
            this.panel2.Controls.Add(this.worldNameLabel);
            this.panel2.Controls.Add(this.passLabel);
            this.panel2.Controls.Add(this.portLabel);
            this.panel2.Controls.Add(this.ServernameLabel);
            this.panel2.Controls.Add(this.portBox);
            this.panel2.Controls.Add(this.passBox);
            this.panel2.Controls.Add(this.boldCheckBox);
            this.panel2.Controls.Add(this.colourLabel);
            this.panel2.Controls.Add(this.worldBox);
            this.panel2.Controls.Add(this.colorSelector);
            this.panel2.Location = new System.Drawing.Point(172, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 186);
            this.panel2.TabIndex = 5;
            // 
            // serverNameBox
            // 
            this.serverNameBox.Location = new System.Drawing.Point(88, 119);
            this.serverNameBox.Name = "serverNameBox";
            this.serverNameBox.Size = new System.Drawing.Size(242, 20);
            this.serverNameBox.TabIndex = 1;
            this.serverNameBox.Text = "HeimServer | 60+ players | Mods | Custom cmds";
            this.serverNameBox.TextChanged += new System.EventHandler(this.ServerNameBox_TextChanged);
            // 
            // italicCheckBox
            // 
            this.italicCheckBox.AutoSize = true;
            this.italicCheckBox.Location = new System.Drawing.Point(258, 149);
            this.italicCheckBox.Name = "italicCheckBox";
            this.italicCheckBox.Size = new System.Drawing.Size(48, 17);
            this.italicCheckBox.TabIndex = 7;
            this.italicCheckBox.Text = "Italic";
            this.italicCheckBox.UseVisualStyleBackColor = true;
            this.italicCheckBox.CheckedChanged += new System.EventHandler(this.ItalicCheckBox_CheckedChanged);
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(48, 67);
            this.portLabel.Margin = new System.Windows.Forms.Padding(5);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(32, 13);
            this.portLabel.TabIndex = 0;
            this.portLabel.Text = "Port :";
            // 
            // ServernameLabel
            // 
            this.ServernameLabel.AutoSize = true;
            this.ServernameLabel.Location = new System.Drawing.Point(9, 122);
            this.ServernameLabel.Margin = new System.Windows.Forms.Padding(5);
            this.ServernameLabel.Name = "ServernameLabel";
            this.ServernameLabel.Size = new System.Drawing.Size(73, 13);
            this.ServernameLabel.TabIndex = 0;
            this.ServernameLabel.Text = "Server name :";
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(88, 64);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(68, 20);
            this.portBox.TabIndex = 2;
            this.portBox.Text = "2456";
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(88, 38);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(242, 20);
            this.passBox.TabIndex = 1;
            this.passBox.Text = "Password";
            // 
            // boldCheckBox
            // 
            this.boldCheckBox.AutoSize = true;
            this.boldCheckBox.Location = new System.Drawing.Point(205, 149);
            this.boldCheckBox.Name = "boldCheckBox";
            this.boldCheckBox.Size = new System.Drawing.Size(47, 17);
            this.boldCheckBox.TabIndex = 6;
            this.boldCheckBox.Text = "Bold";
            this.boldCheckBox.UseVisualStyleBackColor = true;
            this.boldCheckBox.CheckedChanged += new System.EventHandler(this.BoldCheckBox_CheckedChanged);
            // 
            // colourLabel
            // 
            this.colourLabel.AutoSize = true;
            this.colourLabel.Location = new System.Drawing.Point(39, 146);
            this.colourLabel.Margin = new System.Windows.Forms.Padding(5);
            this.colourLabel.Name = "colourLabel";
            this.colourLabel.Size = new System.Drawing.Size(43, 13);
            this.colourLabel.TabIndex = 0;
            this.colourLabel.Text = "Colour :";
            // 
            // worldBox
            // 
            this.worldBox.Location = new System.Drawing.Point(88, 12);
            this.worldBox.Name = "worldBox";
            this.worldBox.Size = new System.Drawing.Size(242, 20);
            this.worldBox.TabIndex = 0;
            this.worldBox.Text = "Dedicated";
            // 
            // colorSelector
            // 
            this.colorSelector.BackColor = System.Drawing.Color.White;
            this.colorSelector.Cursor = System.Windows.Forms.Cursors.Default;
            this.colorSelector.ForeColor = System.Drawing.SystemColors.MenuText;
            this.colorSelector.FormattingEnabled = true;
            this.colorSelector.Location = new System.Drawing.Point(88, 145);
            this.colorSelector.Name = "colorSelector";
            this.colorSelector.Size = new System.Drawing.Size(111, 21);
            this.colorSelector.TabIndex = 5;
            this.colorSelector.SelectedIndexChanged += new System.EventHandler(this.ColorSelector_SelectedIndexChanged);
            // 
            // main
            // 
            this.main.Controls.Add(this.serverNamePreview);
            this.main.Controls.Add(this.versionLabel);
            this.main.Controls.Add(this.createFileButton);
            this.main.Controls.Add(this.panel2);
            this.main.Location = new System.Drawing.Point(12, 12);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(687, 283);
            this.main.TabIndex = 8;
            // 
            // serverNamePreview
            // 
            this.serverNamePreview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.serverNamePreview.BackColor = System.Drawing.Color.Transparent;
            this.serverNamePreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.serverNamePreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.serverNamePreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F);
            this.serverNamePreview.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.serverNamePreview.Image = ((System.Drawing.Image)(resources.GetObject("serverNamePreview.Image")));
            this.serverNamePreview.Location = new System.Drawing.Point(93, 237);
            this.serverNamePreview.Name = "serverNamePreview";
            this.serverNamePreview.Size = new System.Drawing.Size(531, 41);
            this.serverNamePreview.TabIndex = 9;
            this.serverNamePreview.Text = "HeimServer";
            this.serverNamePreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.serverNamePreview.UseCompatibleTextRendering = true;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(2, 265);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(5);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(40, 13);
            this.versionLabel.TabIndex = 2;
            this.versionLabel.Text = "v.1.1.0";
            // 
            // createFileButton
            // 
            this.createFileButton.Location = new System.Drawing.Point(432, 195);
            this.createFileButton.Name = "createFileButton";
            this.createFileButton.Size = new System.Drawing.Size(94, 34);
            this.createFileButton.TabIndex = 8;
            this.createFileButton.Text = "Create file";
            this.createFileButton.UseVisualStyleBackColor = true;
            this.createFileButton.Click += new System.EventHandler(this.CreateFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 304);
            this.Controls.Add(this.main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Valheim: Create server startup file";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label worldNameLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox worldBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Panel main;
        private System.Windows.Forms.Button createFileButton;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label serverNamePreview;
        private System.Windows.Forms.Label colourLabel;
        private System.Windows.Forms.ComboBox colorSelector;
        private System.Windows.Forms.CheckBox boldCheckBox;
        private System.Windows.Forms.CheckBox italicCheckBox;
        private System.Windows.Forms.TextBox serverNameBox;
        private System.Windows.Forms.Label ServernameLabel;
    }
}

