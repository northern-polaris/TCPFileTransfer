
namespace Lab3
{
    partial class ServerForm
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
            this.IPLabel = new System.Windows.Forms.Label();
            this.ServerIpTextBox = new System.Windows.Forms.TextBox();
            this.ServerPortTextBox = new System.Windows.Forms.TextBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.RunButton = new System.Windows.Forms.Button();
            this.FilesListBox = new System.Windows.Forms.ListBox();
            this.ChooseFilesButton = new System.Windows.Forms.Button();
            this.SentFilesButton = new System.Windows.Forms.Button();
            this.RequesedFileListBox = new System.Windows.Forms.ListBox();
            this.SendRequestedFileButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // IPLabel
            // 
            this.IPLabel.AutoSize = true;
            this.IPLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPLabel.Location = new System.Drawing.Point(17, 33);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(77, 19);
            this.IPLabel.TabIndex = 0;
            this.IPLabel.Text = "IP Address";
            // 
            // ServerIpTextBox
            // 
            this.ServerIpTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerIpTextBox.Location = new System.Drawing.Point(100, 29);
            this.ServerIpTextBox.Name = "ServerIpTextBox";
            this.ServerIpTextBox.Size = new System.Drawing.Size(251, 27);
            this.ServerIpTextBox.TabIndex = 1;
            this.ServerIpTextBox.TextChanged += new System.EventHandler(this.ServerIpTextBox_TextChanged);
            // 
            // ServerPortTextBox
            // 
            this.ServerPortTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerPortTextBox.Location = new System.Drawing.Point(444, 30);
            this.ServerPortTextBox.Name = "ServerPortTextBox";
            this.ServerPortTextBox.Size = new System.Drawing.Size(114, 26);
            this.ServerPortTextBox.TabIndex = 2;
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortLabel.Location = new System.Drawing.Point(394, 33);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(35, 19);
            this.PortLabel.TabIndex = 3;
            this.PortLabel.Text = "Port";
            // 
            // RunButton
            // 
            this.RunButton.BackColor = System.Drawing.Color.White;
            this.RunButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RunButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunButton.Location = new System.Drawing.Point(606, 25);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(133, 37);
            this.RunButton.TabIndex = 4;
            this.RunButton.Text = "Start";
            this.RunButton.UseVisualStyleBackColor = false;
            this.RunButton.Click += new System.EventHandler(this.RunButton_ClickAsync);
            // 
            // FilesListBox
            // 
            this.FilesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilesListBox.FormattingEnabled = true;
            this.FilesListBox.ItemHeight = 15;
            this.FilesListBox.Location = new System.Drawing.Point(22, 151);
            this.FilesListBox.Name = "FilesListBox";
            this.FilesListBox.Size = new System.Drawing.Size(787, 214);
            this.FilesListBox.TabIndex = 5;
            this.FilesListBox.SelectedIndexChanged += new System.EventHandler(this.FilesListBox_SelectedIndexChanged);
            // 
            // ChooseFilesButton
            // 
            this.ChooseFilesButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseFilesButton.Location = new System.Drawing.Point(21, 373);
            this.ChooseFilesButton.Name = "ChooseFilesButton";
            this.ChooseFilesButton.Size = new System.Drawing.Size(134, 31);
            this.ChooseFilesButton.TabIndex = 6;
            this.ChooseFilesButton.Text = "Choose Folder";
            this.ChooseFilesButton.UseVisualStyleBackColor = true;
            this.ChooseFilesButton.Click += new System.EventHandler(this.ChooseFilesButton_Click);
            // 
            // SentFilesButton
            // 
            this.SentFilesButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SentFilesButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SentFilesButton.Location = new System.Drawing.Point(658, 373);
            this.SentFilesButton.Name = "SentFilesButton";
            this.SentFilesButton.Size = new System.Drawing.Size(151, 31);
            this.SentFilesButton.TabIndex = 7;
            this.SentFilesButton.Text = "Sent File List";
            this.SentFilesButton.UseVisualStyleBackColor = false;
            this.SentFilesButton.Click += new System.EventHandler(this.SentFilesButton_Click);
            // 
            // RequesedFileListBox
            // 
            this.RequesedFileListBox.FormattingEnabled = true;
            this.RequesedFileListBox.ItemHeight = 14;
            this.RequesedFileListBox.Location = new System.Drawing.Point(21, 21);
            this.RequesedFileListBox.Name = "RequesedFileListBox";
            this.RequesedFileListBox.Size = new System.Drawing.Size(743, 130);
            this.RequesedFileListBox.TabIndex = 8;
            this.RequesedFileListBox.SelectedIndexChanged += new System.EventHandler(this.RequesedFileListBox_SelectedIndexChanged);
            // 
            // SendRequestedFileButton
            // 
            this.SendRequestedFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendRequestedFileButton.Location = new System.Drawing.Point(21, 168);
            this.SendRequestedFileButton.Name = "SendRequestedFileButton";
            this.SendRequestedFileButton.Size = new System.Drawing.Size(235, 33);
            this.SendRequestedFileButton.TabIndex = 9;
            this.SendRequestedFileButton.Text = "Send Requested File";
            this.SendRequestedFileButton.UseVisualStyleBackColor = true;
            this.SendRequestedFileButton.Click += new System.EventHandler(this.SendRequestedFileButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.RunButton);
            this.groupBox1.Controls.Add(this.IPLabel);
            this.groupBox1.Controls.Add(this.ServerIpTextBox);
            this.groupBox1.Controls.Add(this.PortLabel);
            this.groupBox1.Controls.Add(this.ServerPortTextBox);
            this.groupBox1.Location = new System.Drawing.Point(22, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Configuration";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RequesedFileListBox);
            this.groupBox2.Controls.Add(this.SendRequestedFileButton);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 443);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(787, 218);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Requested file from Client";
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 673);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.SentFilesButton);
            this.Controls.Add(this.ChooseFilesButton);
            this.Controls.Add(this.FilesListBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "ServerForm";
            this.Text = "ServerForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.TextBox ServerIpTextBox;
        private System.Windows.Forms.TextBox ServerPortTextBox;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.ListBox FilesListBox;
        private System.Windows.Forms.Button ChooseFilesButton;
        private System.Windows.Forms.Button SentFilesButton;
        private System.Windows.Forms.ListBox RequesedFileListBox;
        private System.Windows.Forms.Button SendRequestedFileButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

