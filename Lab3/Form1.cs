using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace Lab3
{
    public partial class ServerForm : Form
    {
        private ClientForm clientFormObj;
        private TcpClient tcpClient;
        NetworkStream networkStream;
        Thread serverThread = null;
        delegate void SetTextCallback(string text);
        string[] filePaths;

        public ServerForm()
        {
            InitializeComponent();
            // Set local IP on ServerIpTextBox
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    ServerIpTextBox.Text = address.ToString();
                }
            }

            clientFormObj = new ClientForm();
            clientFormObj.Show();
        }


        private void ServerPortTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private async void RunButton_ClickAsync(object sender, EventArgs e)
        {
            try 
            {

                TcpListener listener = new TcpListener(IPAddress.Parse(ServerIpTextBox.Text), int.Parse(ServerPortTextBox.Text));
                listener.Start();
                tcpClient = await listener.AcceptTcpClientAsync();
                networkStream = tcpClient.GetStream();

                serverThread = new Thread(DoWork);
                serverThread.Start();

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Something went wrong with IP or Port. Try again!", "Error");
            }


        }

        public void DoWork()
        {
            byte[] bytes = new byte[1024];
            while (true)
            {
                int bytesRead = networkStream.Read(bytes, 0, bytes.Length);
                string dataIn = Encoding.ASCII.GetString(bytes, 0, bytesRead);
                this.SetText(dataIn);
            }
        }

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.     
            if (this.RequesedFileListBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.RequesedFileListBox.Items.Add(text);
                this.RequesedFileListBox.SetSelected(0, true);
            }
        }


        private void ServerIpTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChooseFilesButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            filePaths = System.IO.Directory.GetFiles(folderBrowserDialog1.SelectedPath);

            foreach (string file in filePaths)
            {
                FilesListBox.Items.Add(file);
            }

        }


        private void FilesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SentFilesButton_Click(object sender, EventArgs e)
        {
            try
            {
                string filePathsString = string.Join(",", filePaths);
                byte[] byteTime = Encoding.ASCII.GetBytes(filePathsString);
                networkStream.Write(byteTime, 0, byteTime.Length);
                networkStream.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select a folder first!", "Error");
            }


        }

        private void RequesedFileListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SendRequestedFileButton_Click(object sender, EventArgs e)
        {
            try {
                var selectedFileName = RequesedFileListBox.SelectedItem;
                MessageBox.Show(selectedFileName.ToString(), "Requested File");
                // Signal to prepare for File Stream
                byte[] byteTime = Encoding.ASCII.GetBytes("Start");
                networkStream.Write(byteTime, 0, byteTime.Length);
                networkStream.Flush();
                //Send The actual File
                byte[] requestedFile = File.ReadAllBytes(selectedFileName.ToString());
                networkStream.Write(requestedFile, 0, requestedFile.Length);
                networkStream.Flush();

            }
            catch (NullReferenceException ex) 
            {
                MessageBox.Show("You don't have select a requested file ","Error");
            }


        }

    }
}
