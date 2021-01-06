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
    public partial class ClientForm : Form
    {
        private TcpClient tcpClient;
        NetworkStream networkStream;
        Thread clientThread = null;
        delegate void SetTextCallback(string text);
        string downloadPath;
        string requestedFileName;
        public ClientForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void ClientConnectButton_Click(object sender, EventArgs e)
        {
            tcpClient = new TcpClient();
            try
            {
                tcpClient.Connect(IPAddress.Parse(HostIpTextBox.Text), int.Parse(HostPortTextBox.Text));
                if (tcpClient.Connected)
                {
                    MessageBox.Show("Connected to server");
                    networkStream = tcpClient.GetStream();

                    ConnectionState.Text = "Connected";
                    ConnectionState.BackColor = Color.LightGreen;

                    clientThread = new Thread(DoWork);
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        public void DoWork()

        {
            byte[] bytes;
            string temporarySignal = "";

            while (true)
            {

                int maxBytesSize = 1024000;
                bytes = new byte[maxBytesSize];
                int bytesRead = networkStream.Read(bytes, 0, bytes.Length);
                string dataIn = Encoding.ASCII.GetString(bytes, 0, bytesRead);

                if (dataIn == "Start")
                {
                    temporarySignal = dataIn;
                    continue;
                }
                if (temporarySignal == "Start")
                {
                    var ms = new MemoryStream();
                    // Split bytes array to the current file size array
                    var currentFile = bytes.Take(bytesRead).ToArray();
                    ms.Write(currentFile, 0, currentFile.Length);
                    File.WriteAllBytes(downloadPath +@"\" + requestedFileName, ms.ToArray());
                    temporarySignal = "";
                    MessageBox.Show("File is downloaded successfully!", "Success!");
                    continue;

                }

                string[] FilesAsArray = dataIn.Split(','); 
                FilesListBox.Invoke((MethodInvoker)(() =>
                {
                    foreach (string file in FilesAsArray)
                    {
                        FilesListBox.Items.Add(file);
                    }
                }
                ));
            }

        }

        private void HostPortTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void HostIpTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RequestFileButton_Click(object sender, EventArgs e)
        {
            var selectedFileName = FilesListBox.SelectedItem;
            requestedFileName = selectedFileName.ToString();
            var directoriesSplited = requestedFileName.Split('\\');
            requestedFileName = directoriesSplited[directoriesSplited.Length - 1];


            MessageBox.Show(selectedFileName.ToString(), "Selected File");
            byte[] byteTime = Encoding.ASCII.GetBytes(selectedFileName.ToString());

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            downloadPath = fbd.SelectedPath;

            networkStream.Write(byteTime, 0, byteTime.Length);
        }

        private void FilesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void ConnectionState_Click(object sender, EventArgs e)
        {

        }
    }
}
