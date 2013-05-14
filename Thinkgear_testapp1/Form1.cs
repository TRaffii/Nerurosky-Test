using System;
using System.Threading;
using System.Windows.Forms;
using ThinkGearNET;
using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;

namespace Thinkgear_testapp1
{
    
    public partial class Form1 : Form
    {
        int MeditWanted;
        int AttWanted;
        public Form1()
        {
            InitializeComponent();
            piB1.Visible = false;
            pictureBox1.Visible = false;
            piMedit.Visible = false;

            timer1.Tick += new EventHandler(timer1_Tick); // Everytime timer ticks, timer_Tick will be called
            timer1.Interval = (10) * (10);             // Timer will tick evert 10 seconds
            timer1.Enabled = true;                       // Enable the timer
            timer1.Stop();

            timer2.Tick += new EventHandler(timer2_Tick); // Everytime timer ticks, timer_Tick will be called
            timer2.Interval = (10) * (10);             // Timer will tick evert 10 seconds
            timer2.Enabled = true;                       // Enable the timer
            timer2.Stop();

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string port in SerialPort.GetPortNames()) // zczytanie podpietych portow
                cboPort.Items.Add(port);
            cboPort.SelectedIndex = 0;
            AttWanted = (int)nudAttWanted.Value;
            MeditWanted = (int)nudMeditWanted.Value;
            lblSignal.Text = "NO SIGNAL! : ";
            lblSignal.ForeColor = Color.Red;
            label1.Text = "Choose PORT then click Connection->Connect";

        }


        void _thinkGearWrapper_ThinkGearChanged(object sender, ThinkGearChangedEventArgs e)
        {
            // Zbieranie danych
            BeginInvoke(new MethodInvoker(delegate
            {
                //Poziom sygnału
                if (e.ThinkGearState.PoorSignal == 200)
                {
                    pbSignal.Value = 0;
                    lblSignal.Text = "NO SIGNAL! : ";
                    lblSignal.ForeColor = Color.Red;
                }
                else if ((e.ThinkGearState.PoorSignal < 200) && (e.ThinkGearState.PoorSignal > 100))
                {
                    pbSignal.Value = 1;
                    lblSignal.Text = "POOR SIGNAL : ";
                    lblSignal.ForeColor = Color.Yellow;
                    
                }
                else if ((e.ThinkGearState.PoorSignal < 100) && (e.ThinkGearState.PoorSignal > 50))
                {
                    pbSignal.Value = 2;
                    lblSignal.Text = "POOR SIGNAL : ";
                    lblSignal.ForeColor = Color.Yellow;
                }
                else if
                    ((e.ThinkGearState.PoorSignal < 50) && (e.ThinkGearState.PoorSignal > 0))
                {
                    pbSignal.Value = 3;
                    lblSignal.Text = "POOR SIGNAL : ";
                    lblSignal.ForeColor = Color.Yellow;
                }
                else
                {
                    pbSignal.Value = 4;
                    lblSignal.Text = "FINE SIGNAL : ";
                    lblSignal.ForeColor = Color.Green;
                }

                //Pomiary
                lblAttention.Text = "Attention: " + e.ThinkGearState.Attention + "%";
                lblMeditation.Text = "Meditation: " + e.ThinkGearState.Meditation + "%";
                txtState.Text = e.ThinkGearState.ToString();

                //Obrazki
                pbAttention.Value = (int)e.ThinkGearState.Attention;
                pbMeditation.Value = (int)e.ThinkGearState.Meditation;
                if (e.ThinkGearState.Attention < AttWanted)
                {
                    pictureBox1.Visible = false;
                    piB1.Visible = true;
                }
                else
                {
                    piB1.Visible = false;
                    pictureBox1.Visible = true;
                }
                if (e.ThinkGearState.Meditation > MeditWanted)
                {
                    piMedit.Visible = true;
                    timer1.Start();
                    timer2.Stop();
                }
                else
                {
                    piMedit.Visible = false;
                    timer2.Start();
                    timer1.Stop();
                }
                
            }));
            Thread.Sleep(1);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _thinkGearWrapper.Disconnect();
        }
        
        public ThinkGearWrapper _thinkGearWrapper { get; set; }

        

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _thinkGearWrapper = new ThinkGearWrapper();

            // setup the event
            _thinkGearWrapper.ThinkGearChanged += _thinkGearWrapper_ThinkGearChanged;
            label1.Text = "CONNECTED!";
            label1.ForeColor = Color.Green;
            // connect to the device on the specified COM port at 57600 baud
            if (!_thinkGearWrapper.Connect(cboPort.SelectedItem.ToString(), 57600, true))
            //if (!_thinkGearWrapper.Connect("COM5".ToString(), 57600, true))
            {
                MessageBox.Show("Could not connect to headset.");
                label1.Visible = true;
            }
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Choose PORT then click Connection->Connect";
            label1.ForeColor = Color.Black;
            _thinkGearWrapper.Disconnect();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void disableBlinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _thinkGearWrapper.EnableBlinkDetection(false);
        }

        private void enableBlinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _thinkGearWrapper.EnableBlinkDetection(true);
        }

        private void nudAttWanted_ValueChanged(object sender, EventArgs e)
        {
            AttWanted = (int)nudAttWanted.Value;
        }

        private void nudMeditWanted_ValueChanged(object sender, EventArgs e)
        {
            MeditWanted = (int)nudMeditWanted.Value;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblSignal.Text = "No Signal!";
            lblSignal.ForeColor = Color.Red;
            txtState.Clear();
            piB1.Visible = false;
            piMedit.Visible = false;
            pictureBox1.Visible = false;
            pbSignal.Value = 0;
            pbMeditation.Value = 0;
            pbAttention.Value = 0;
            lblAttention.Text = "Attention";
            lblMeditation.Text = "Meditation";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (piB_Ball.Location.Y > 53)
            {
                Point xy;
                int a,b;
                xy = piB_Ball.Location;
                xy.Y -= 1;
                piB_Ball.Location = xy;
                lbl_Height.Text = (473 - piB_Ball.Location.Y).ToString();
                a = Convert.ToInt32(lbl_Height.Text);
                b = Convert.ToInt32(lbl_maxheight.Text);
                if (a > b)
                    lbl_maxheight.Text = a.ToString();

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (piB_Ball.Location.Y < 473)
            {
                Point xy;
                xy = piB_Ball.Location;
                xy.Y += 1;
                piB_Ball.Location = xy;
                lbl_Height.Text = (473-piB_Ball.Location.Y).ToString();
            }
        }

    }

}
