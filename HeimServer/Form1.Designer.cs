
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
            this.ServernameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ServerNameBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.WorldBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PortBox = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.CreateFileButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServernameLabel
            // 
            this.ServernameLabel.AutoSize = true;
            this.ServernameLabel.Location = new System.Drawing.Point(5, 11);
            this.ServernameLabel.Margin = new System.Windows.Forms.Padding(5);
            this.ServernameLabel.Name = "ServernameLabel";
            this.ServernameLabel.Size = new System.Drawing.Size(73, 13);
            this.ServernameLabel.TabIndex = 0;
            this.ServernameLabel.Text = "Server name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "World name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ServerNameBox);
            this.panel1.Controls.Add(this.ServernameLabel);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 31);
            this.panel1.TabIndex = 4;
            // 
            // ServerNameBox
            // 
            this.ServerNameBox.Location = new System.Drawing.Point(86, 8);
            this.ServerNameBox.Name = "ServerNameBox";
            this.ServerNameBox.Size = new System.Drawing.Size(242, 20);
            this.ServerNameBox.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.WorldBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(4, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 30);
            this.panel2.TabIndex = 5;
            // 
            // WorldBox
            // 
            this.WorldBox.Location = new System.Drawing.Point(85, 9);
            this.WorldBox.Name = "WorldBox";
            this.WorldBox.Size = new System.Drawing.Size(242, 20);
            this.WorldBox.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.PassBox);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(3, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 30);
            this.panel3.TabIndex = 6;
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(86, 9);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(242, 20);
            this.PassBox.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.PortBox);
            this.panel4.Controls.Add(this.Port);
            this.panel4.Location = new System.Drawing.Point(3, 99);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(350, 30);
            this.panel4.TabIndex = 7;
            // 
            // PortBox
            // 
            this.PortBox.Location = new System.Drawing.Point(86, 7);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(68, 20);
            this.PortBox.TabIndex = 1;
            this.PortBox.Text = "2456";
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.Location = new System.Drawing.Point(46, 11);
            this.Port.Margin = new System.Windows.Forms.Padding(5);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(32, 13);
            this.Port.TabIndex = 0;
            this.Port.Text = "Port :";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.CreateFileButton);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Location = new System.Drawing.Point(12, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(360, 163);
            this.panel5.TabIndex = 8;
            // 
            // CreateFileButton
            // 
            this.CreateFileButton.Location = new System.Drawing.Point(278, 135);
            this.CreateFileButton.Name = "CreateFileButton";
            this.CreateFileButton.Size = new System.Drawing.Size(75, 23);
            this.CreateFileButton.TabIndex = 8;
            this.CreateFileButton.Text = "Create file";
            this.CreateFileButton.UseVisualStyleBackColor = true;
            this.CreateFileButton.Click += new System.EventHandler(this.CreateFileButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "v.1.0.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 199);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Valheim: Create server startup file";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ServernameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ServerNameBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox WorldBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox PortBox;
        private System.Windows.Forms.Label Port;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button CreateFileButton;
        private System.Windows.Forms.Label label3;
    }
}

