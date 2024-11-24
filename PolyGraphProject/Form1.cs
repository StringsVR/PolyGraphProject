using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolyGraphProject
{
    public partial class Form1 : Form
    { 
        ConnectionUtils connection = new ConnectionUtils();
        private PolyData polyData;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int one = 1;
            int two = 1;
            connection.setPidandVid(one, two);
            chart.DataSource = new List<DataLine>();
            //Starts update loop
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //basically the update loop
            timer1.Start();

            //Updates The Label and button ui depending on connection
            if (!connection.isConnected())
            {
                connectBtn.Enabled = true;
                disconnectBtn.Enabled = false;
                connectedLabel.Text = "Not Connected";
                return;
            }
            
            connectBtn.Enabled = false;
            disconnectBtn.Enabled = true;
            connectedLabel.Text = "Connected";

            //Grabs polygraph Data

            //Set Polygraph Data to Chart
            return;
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            connectingLabel.Visible = true;
            connectingLabel.Text = "Connecting...";
            //Starts 5s timer to set labels
            timer2.Start();

            //Retries connection 3 times
            for (var i = 0; i > 3; i++)
            {
                connection.connectToPolygraph();
                if (connection.isConnected())
                {
                    return;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //Sets label after 5s
            if (connection.isConnected())
            {
                connectingLabel.Text = "Connected To Polygraph";
            }
            else
            {
                connectingLabel.Text = "Could Not Connect To Polygraph.";
            }
        }
    }
}
