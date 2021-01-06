
namespace Lab3
{
    partial class ClientForm
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
            this.HostIpLabel = new System.Windows.Forms.Label();
            this.HostPortLabel = new System.Windows.Forms.Label();
            this.HostIpTextBox = new System.Windows.Forms.TextBox();
            this.HostPortTextBox = new System.Windows.Forms.TextBox();
            this.ClientConnectButton = new System.Windows.Forms.Button();
            this.FilesListBox = new System.Windows.Forms.ListBox();
            this.RequestFileButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ConnectionState = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // HostIpLabel
            // 
            this.HostIpLabel.AutoSize = true;
            this.HostIpLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HostIpLabel.Location = new System.Drawing.Point(18, 33);
            this.HostIpLabel.Name = "HostIpLabel";
            this.HostIpLabel.Size = new System.Drawing.Size(55, 19);
            this.HostIpLabel.TabIndex = 0;
            this.HostIpLabel.Text = "Host IP";
            // 
            // HostPortLabel
            // 
            this.HostPortLabel.AutoSize = true;
            this.HostPortLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HostPortLabel.Location = new System.Drawing.Point(377, 35);
            this.HostPortLabel.Name = "HostPortLabel";
            this.HostPortLabel.Size = new System.Drawing.Size(69, 19);
            this.HostPortLabel.TabIndex = 1;
            this.HostPortLabel.Text = "Host Port";
            // 
            // HostIpTextBox
            // 
            this.HostIpTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HostIpTextBox.Location = new System.Drawing.Point(92, 31);
            this.HostIpTextBox.Name = "HostIpTextBox";
            this.HostIpTextBox.Size = new System.Drawing.Size(242, 26);
            this.HostIpTextBox.TabIndex = 2;
            this.HostIpTextBox.TextChanged += new System.EventHandler(this.HostIpTextBox_TextChanged);
            // 
            // HostPortTextBox
            // 
            this.HostPortTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HostPortTextBox.Location = new System.Drawing.Point(461, 31);
            this.HostPortTextBox.Name = "HostPortTextBox";
            this.HostPortTextBox.Size = new System.Drawing.Size(100, 26);
            this.HostPortTextBox.TabIndex = 3;
            this.HostPortTextBox.TextChanged += new System.EventHandler(this.HostPortTextBox_TextChanged);
            // 
            // ClientConnectButton
            // 
            this.ClientConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientConnectButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientConnectButton.Location = new System.Drawing.Point(612, 28);
            this.ClientConnectButton.Name = "ClientConnectButton";
            this.ClientConnectButton.Size = new System.Drawing.Size(98, 31);
            this.ClientConnectButton.TabIndex = 4;
            this.ClientConnectButton.Text = "Connect";
            this.ClientConnectButton.UseVisualStyleBackColor = true;
            this.ClientConnectButton.Click += new System.EventHandler(this.ClientConnectButton_Click);
            // 
            // FilesListBox
            // 
            this.FilesListBox.FormattingEnabled = true;
            this.FilesListBox.ItemHeight = 14;
            this.FilesListBox.Location = new System.Drawing.Point(22, 21);
            this.FilesListBox.Name = "FilesListBox";
            this.FilesListBox.Size = new System.Drawing.Size(688, 214);
            this.FilesListBox.TabIndex = 5;
            this.FilesListBox.SelectedIndexChanged += new System.EventHandler(this.FilesListBox_SelectedIndexChanged);
            // 
            // RequestFileButton
            // 
            this.RequestFileButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestFileButton.Location = new System.Drawing.Point(22, 249);
            this.RequestFileButton.Name = "RequestFileButton";
            this.RequestFileButton.Size = new System.Drawing.Size(169, 34);
            this.RequestFileButton.TabIndex = 6;
            this.RequestFileButton.Text = "Request Selected File";
            this.RequestFileButton.UseVisualStyleBackColor = true;
            this.RequestFileButton.Click += new System.EventHandler(this.RequestFileButton_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HostIpLabel);
            this.groupBox1.Controls.Add(this.HostPortLabel);
            this.groupBox1.Controls.Add(this.HostIpTextBox);
            this.groupBox1.Controls.Add(this.ClientConnectButton);
            this.groupBox1.Controls.Add(this.HostPortTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 81);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration with server ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FilesListBox);
            this.groupBox2.Controls.Add(this.RequestFileButton);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(41, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(738, 300);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Request To Download Selected File";
            // 
            // ConnectionState
            // 
            this.ConnectionState.BackColor = System.Drawing.Color.Salmon;
            this.ConnectionState.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionState.ForeColor = System.Drawing.Color.Black;
            this.ConnectionState.Location = new System.Drawing.Point(677, 12);
            this.ConnectionState.Name = "ConnectionState";
            this.ConnectionState.Size = new System.Drawing.Size(133, 31);
            this.ConnectionState.TabIndex = 9;
            this.ConnectionState.Text = "Not Connected";
            this.ConnectionState.UseVisualStyleBackColor = false;
            this.ConnectionState.Click += new System.EventHandler(this.ConnectionState_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 483);
            this.Controls.Add(this.ConnectionState);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HostIpLabel;
        private System.Windows.Forms.Label HostPortLabel;
        private System.Windows.Forms.TextBox HostIpTextBox;
        private System.Windows.Forms.TextBox HostPortTextBox;
        private System.Windows.Forms.Button ClientConnectButton;
        private System.Windows.Forms.ListBox FilesListBox;
        private System.Windows.Forms.Button RequestFileButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ConnectionState;
    }
}