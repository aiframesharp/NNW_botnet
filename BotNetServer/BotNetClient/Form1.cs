using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AI;
using AI.ML.NeuralNetwork;
using AI.WEB.TCP;

namespace BotNetClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            net.Add(new LinearLayer(10,2));
        }

        TCPClientNNWBotNet tCPClient = new TCPClientNNWBotNet("127.0.0.1", 2048);
        Net net = new Net();

        private void button1_Click(object sender, EventArgs e)
        {
            tCPClient.Connect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tCPClient.Send(net);
            //tCPClient.Send(richTextBox1.Text);
        }
    }
}
