using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AI.WEB.TCP;

namespace BotNetServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            botNetServer.Start();
            botNetServer.ServerMes += Mess;
            botNetServer.NewNNW += BotNetServer_NewNNW;
        }

        

        TCPServerNNWBotNet botNetServer = new TCPServerNNWBotNet("127.0.0.1", 2048);

        private void BotNetServer_NewNNW(AI.ML.NeuralNetwork.Net obj)
        {
            listBox1.Items.Add(obj);
        }

        private void Mess(string obj)
        {
            listBox1.Items.Add(obj);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            botNetServer.Stop();
        }
    }
}
