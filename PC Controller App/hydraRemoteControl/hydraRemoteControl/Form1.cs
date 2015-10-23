using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace hydraRemoteControl
{
    public partial class frmHydraController : Form
    {
        public frmHydraController()
        {
            InitializeComponent();
        }
//
//Global variables
//
        string serialRXData = "";
//
//Form code
//
        private void frmHydraController_Load(object sender, EventArgs e)
        {
            serialPort1.PortName = "COM5";
            serialPort1.BaudRate = 9600;

            DialogResult makeConnection = MessageBox.Show("Would you like to establish a serial connection now?", "Attempting To Connect", MessageBoxButtons.YesNo);
            if (makeConnection == DialogResult.Yes)
            {
                try
                {
                    serialPort1.Open();
                }
                catch (IOException)
                {
                    MessageBox.Show("Could not connect to Device.");
                }
            }

            if (serialPort1.IsOpen)
            {
                this.Text = "Hydra Remote Controller (Connected: COM5)";
                MessageBox.Show("Connected to Device on COM5");
            }
            else
            {
                this.Text = "Hydra Remote Controller (Not Connected)";
            }
        }

        private void frmHydraController_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }
//
//Autonomous button
//
        private void btnAutoMode_Click(object sender, EventArgs e)
        {
            serialPort1.Write("auto");
            gbxManualControls.Enabled = false;
            btnAutoMode.Enabled = false;
            btnManualMode.Enabled = true;
        }
//
//Manual mode
//
        private void btnManualMode_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("manual");
                gbxManualControls.Enabled = true;
                btnManualMode.Enabled = false;
                btnAutoMode.Enabled = true;
            }
            else
            {
                MessageBox.Show("You must connect to the device before entering manual mode");
            }
        }
//
//Manual bluetooth connect button
//
        private void btnConnectBluetooth_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                this.Text = "Hydra Remote Controller (Connecting...)";
                serialPort1.PortName = "COM5";
                serialPort1.BaudRate = 9600;

                try
                {
                    serialPort1.Open();
                }
                catch (IOException)
                {
                    MessageBox.Show("Could not connect to Device.");
                }


                if (serialPort1.IsOpen)
                {
                    this.Text = "Hydra Remote Controller (Connected: COM5)";
                }
                else
                {
                    this.Text = "Hydra Remote Controller (Not Connected)";
                }
            }
            else
            {
                MessageBox.Show("A serial connection has already been established.");
            }
        }
//
//Distance reading button
//
        private void btnDistReading_Click(object sender, EventArgs e)
        {
            txtSerialTerminal.Text = txtSerialTerminal.Text + "\r\nCalculating distance...";
            serialPort1.Write("0");
            string checkChanged = "0";
            //System.Threading.Thread.Sleep(5000);
            for (int i = 0; ; i++)
            {
                if (serialRXData == checkChanged)
                {
                    i++;
                }
                else if (i > 10000)
                {
                    txtDistance.Text = "ERROR";
                    break;
                }
                else
                {
                    txtDistance.Text = serialRXData;
                    txtSerialTerminal.Text = txtSerialTerminal.Text + "\r\nDistance = " + txtDistance.Text;
                    txtSerialTerminal.SelectionStart = txtSerialTerminal.Text.Length;
                    txtSerialTerminal.ScrollToCaret();
                    break;
                }
            }
        }
//
//Serial port code
//
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            serialRXData = serialPort1.ReadExisting();
        }
//
//Brake button
//
        private void btnControlBrake_Click(object sender, EventArgs e)
        {
            txtSerialTerminal.Text = txtSerialTerminal.Text + "\r\nBrake";
            serialPort1.Write("5");
            txtSerialTerminal.SelectionStart = txtSerialTerminal.Text.Length;
            txtSerialTerminal.ScrollToCaret();
        }
//
//Forward direction button
//
        private void btnControlForward_MouseDown(object sender, MouseEventArgs e)
        {
            txtSerialTerminal.Text = txtSerialTerminal.Text + "\r\nForward";
            serialPort1.Write("8");
            txtSerialTerminal.SelectionStart = txtSerialTerminal.Text.Length;
            txtSerialTerminal.ScrollToCaret();
        }

        private void btnControlForward_MouseUp(object sender, MouseEventArgs e)
        {
            txtSerialTerminal.Text = txtSerialTerminal.Text + "\r\nStopped";
            serialPort1.Write("5");
            txtSerialTerminal.SelectionStart = txtSerialTerminal.Text.Length;
            txtSerialTerminal.ScrollToCaret();
        }
//
//Right direction button
//
        private void btnControlRight_MouseDown(object sender, MouseEventArgs e)
        {
            txtSerialTerminal.Text = txtSerialTerminal.Text + "\r\nRight";
            serialPort1.Write("6");
            txtSerialTerminal.SelectionStart = txtSerialTerminal.Text.Length;
            txtSerialTerminal.ScrollToCaret();
        }

        private void btnControlRight_MouseUp(object sender, MouseEventArgs e)
        {
            txtSerialTerminal.Text = txtSerialTerminal.Text + "\r\nStopped";
            serialPort1.Write("5");
            txtSerialTerminal.SelectionStart = txtSerialTerminal.Text.Length;
            txtSerialTerminal.ScrollToCaret();
        }
//
//Left direction button
//
        private void btnControlLeft_MouseDown(object sender, MouseEventArgs e)
        {
            txtSerialTerminal.Text = txtSerialTerminal.Text + "\r\nLeft";
            serialPort1.Write("4");
            txtSerialTerminal.SelectionStart = txtSerialTerminal.Text.Length;
            txtSerialTerminal.ScrollToCaret();
        }

        private void btnControlLeft_MouseUp(object sender, MouseEventArgs e)
        {
            txtSerialTerminal.Text = txtSerialTerminal.Text + "\r\nStopped";
            serialPort1.Write("5");
            txtSerialTerminal.SelectionStart = txtSerialTerminal.Text.Length;
            txtSerialTerminal.ScrollToCaret();
        }
//
//Reverse direction button
//
        private void btnControlReverse_MouseDown(object sender, MouseEventArgs e)
        {
            txtSerialTerminal.Text = txtSerialTerminal.Text + "\r\nReverse";
            serialPort1.Write("2");
            txtSerialTerminal.SelectionStart = txtSerialTerminal.Text.Length;
            txtSerialTerminal.ScrollToCaret();
        }

        private void btnControlReverse_MouseUp(object sender, MouseEventArgs e)
        {
            txtSerialTerminal.Text = txtSerialTerminal.Text + "\r\nStopped";
            serialPort1.Write("5");
            txtSerialTerminal.SelectionStart = txtSerialTerminal.Text.Length;
            txtSerialTerminal.ScrollToCaret();
        }
//
//Right motor speed track bar
//
        private void trkRightMotorSpeed_ValueChanged(object sender, EventArgs e)
        {
            lblRightMotorSpeed.Text = "Right Motor Speed: " + trkRightMotorSpeed.Value;
        }

        private void trkRightMotorSpeed_MouseUp(object sender, MouseEventArgs e)
        {
            serialPort1.Write("9" + trkRightMotorSpeed.Value);
            txtSerialTerminal.Text = txtSerialTerminal.Text + "\r\nRight Motor Speed: " + trkRightMotorSpeed.Value;
            System.Threading.Thread.Sleep(5000);
            txtSerialTerminal.Text = txtSerialTerminal.Text + "\r\nArdiuno right motor data = " + serialRXData;
            txtSerialTerminal.SelectionStart = txtSerialTerminal.Text.Length;
            txtSerialTerminal.ScrollToCaret();
        }
//
//Left motor speed track bar
//
        private void trkLeftMotorSpeed_ValueChanged(object sender, EventArgs e)
        {
            lblLeftMotorSpeed.Text = "Left Motor Speed: " + trkLeftMotorSpeed.Value;
        }

        private void trkLeftMotorSpeed_MouseUp(object sender, MouseEventArgs e)
        {
            serialPort1.Write("7" + trkRightMotorSpeed.Value);
            txtSerialTerminal.Text = txtSerialTerminal.Text + "\r\nLeft Motor Speed: " + trkRightMotorSpeed.Value;
            System.Threading.Thread.Sleep(5000);
            txtSerialTerminal.Text = txtSerialTerminal.Text + "\r\nArdiuno left motor data = " + serialRXData;
            txtSerialTerminal.SelectionStart = txtSerialTerminal.Text.Length;
            txtSerialTerminal.ScrollToCaret();
        }
//
//Input button code
//
        private void btnTerminalInput_Click(object sender, EventArgs e)
        {
            if(txtSerialInput.Text == "")
            {
                MessageBox.Show("Nothing has been entered into the text field.");
            }
            else if(txtSerialInput.Text == "/c" || txtSerialInput.Text == "/C")
            {
                txtSerialTerminal.Text = "";
            }
            else if(txtSerialInput.Text == "/h" || txtSerialInput.Text == "/H")
            {
                txtSerialTerminal.Text = "To move the robot, hold the arrow buttons down. The robot will stop automatically once the directional button is released.\r\n\r\nUse the brake button if the robot does not stop automatically.\r\n\r\nthe track bars above control the speed of the motors. Use these to increase the speed of the robot or to correct the robot's trajectory.\r\n\r\nUse the distance reading and speed reading buttons to calculate the distance to the nearest obstacle, and the robot's speed, respectively.";
            }
            else if(txtSerialInput.Text == "/i" || txtSerialInput.Text == "/I")
            {
                txtSerialTerminal.Text = "Hydra® (V0.37)\r\n\r\nAutonomous Collision-Detection Robot.\r\n\r\nStatus: Active\r\n\r\n\r\nCopyright© MA 2015-2020";
            }
            else
            {
                serialPort1.Write(txtSerialInput.Text);
                txtSerialTerminal.Text = txtSerialTerminal.Text + "\r\nInput: " + txtSerialInput.Text;
                txtSerialTerminal.Text = txtSerialTerminal.Text + serialRXData;
            }

            txtSerialTerminal.SelectionStart = txtSerialTerminal.Text.Length;
            txtSerialTerminal.ScrollToCaret();
        }

        private void txtSerialInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnTerminalInput.PerformClick();
            }
        }
//
//Calculate Speed Button
//
        private void btnCalcSpeed_Click(object sender, EventArgs e)
        {
            txtSerialTerminal.Text = txtSerialTerminal.Text + "\r\nCalculating speed...";
            serialPort1.Write("1");
            string checkChanged = "1";
            for (int i = 0; ; i++)
            {
                if (serialRXData == checkChanged)
                {
                    i++;
                }
                else if (i > 10000)
                {
                    txtDistance.Text = "ERROR";
                    break;
                }
                else
                {
                    txtSpeed.Text = serialRXData;
                    txtSerialTerminal.Text = txtSerialTerminal.Text + "\r\nSpeed = " + txtSpeed.Text;
                    txtSerialTerminal.SelectionStart = txtSerialTerminal.Text.Length;
                    txtSerialTerminal.ScrollToCaret();
                    break;
                }
            }
        }
    }
}
