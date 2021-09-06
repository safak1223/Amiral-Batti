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
using System.IO;


namespace SafakGame
{
    public partial class Form1 : Form
    {

        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string recieve;
        public string TextToSend;
        public Form1()
        {
            InitializeComponent();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());

            foreach(IPAddress address in localIP)
            {
                if(address.AddressFamily==AddressFamily.InterNetwork)
                {
                    ServerIPtextBox.Text = address.ToString();
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(ServerporttextBox.Text));
            listener.Start();
            client = listener.AcceptTcpClient();
            STR = new StreamReader(client.GetStream());
            STW = new StreamWriter(client.GetStream());
            STW.AutoFlush = true;
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;       }

        private void Connectbutton_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint IpEnd = new IPEndPoint(IPAddress.Parse(ClientIPtextBox.Text), int.Parse(ClientporttextBox.Text));

            try
            {
                ChatScreentextBox.AppendText("Connect to server" + "\n");
                STW = new StreamWriter(client.GetStream());
                STR = new StreamReader(client.GetStream());
                STW.AutoFlush = true;
                backgroundWorker1.RunWorkerAsync();
                backgroundWorker2.WorkerSupportsCancellation = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while(client.Connected)
            {
                try
                {
                    recieve = STR.ReadLine();
                    this.ChatScreentextBox.Invoke(new MethodInvoker(delegate()
                        {
                            ChatScreentextBox.AppendText("you" + recieve + "\n");
                     
                          }));
                    recieve = "";
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if(client.Connected)
            {
                STW.WriteLine(TextToSend);
                this.ChatScreentextBox.Invoke(new MethodInvoker(delegate ()
                {
                    ChatScreentextBox.AppendText("Me"+TextToSend+"\n")
                }));
            }
            else
            {
                MessageBox.Show("Sending Failed");
                backgroundWorker2.CancelAsync();
            }
        }

        private void Sendbutton_Click(object sender, EventArgs e)
        {
            if (MessagetextBox.Text != "")
            {
                TextToSend = MessagetextBox.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            MessagetextBox.Text = "";
           }
    }
}
