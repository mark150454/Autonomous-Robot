namespace hydraRemoteControl
{
    partial class frmHydraController
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHydraController));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnAutoMode = new System.Windows.Forms.Button();
            this.btnManualMode = new System.Windows.Forms.Button();
            this.trkRightMotorSpeed = new System.Windows.Forms.TrackBar();
            this.lblLeftMotorSpeed = new System.Windows.Forms.Label();
            this.lblRightMotorSpeed = new System.Windows.Forms.Label();
            this.trkLeftMotorSpeed = new System.Windows.Forms.TrackBar();
            this.lblLeftMotorMin = new System.Windows.Forms.Label();
            this.lblRightMotorMin = new System.Windows.Forms.Label();
            this.lblLeftMotorMax = new System.Windows.Forms.Label();
            this.lblRightMotorMax = new System.Windows.Forms.Label();
            this.btnControlBrake = new System.Windows.Forms.Button();
            this.gbxMovementControls = new System.Windows.Forms.GroupBox();
            this.btnControlReverse = new System.Windows.Forms.Button();
            this.btnControlRight = new System.Windows.Forms.Button();
            this.btnControlLeft = new System.Windows.Forms.Button();
            this.btnControlForward = new System.Windows.Forms.Button();
            this.gbxSpeedControls = new System.Windows.Forms.GroupBox();
            this.btnDistReading = new System.Windows.Forms.Button();
            this.btnCalcSpeed = new System.Windows.Forms.Button();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.lblCm = new System.Windows.Forms.Label();
            this.lblCmPerSec = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxMiscControls = new System.Windows.Forms.GroupBox();
            this.txtSerialInput = new System.Windows.Forms.TextBox();
            this.txtSerialTerminal = new System.Windows.Forms.TextBox();
            this.gbxSerialTerminal = new System.Windows.Forms.GroupBox();
            this.btnTerminalInput = new System.Windows.Forms.Button();
            this.gbxManualControls = new System.Windows.Forms.GroupBox();
            this.btnConnectBluetooth = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trkRightMotorSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkLeftMotorSpeed)).BeginInit();
            this.gbxMovementControls.SuspendLayout();
            this.gbxSpeedControls.SuspendLayout();
            this.gbxMiscControls.SuspendLayout();
            this.gbxSerialTerminal.SuspendLayout();
            this.gbxManualControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btnAutoMode
            // 
            this.btnAutoMode.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAutoMode.Enabled = false;
            this.btnAutoMode.Location = new System.Drawing.Point(9, 12);
            this.btnAutoMode.Name = "btnAutoMode";
            this.btnAutoMode.Size = new System.Drawing.Size(102, 40);
            this.btnAutoMode.TabIndex = 0;
            this.btnAutoMode.Text = "Autonomous Mode";
            this.btnAutoMode.UseVisualStyleBackColor = true;
            this.btnAutoMode.Click += new System.EventHandler(this.btnAutoMode_Click);
            // 
            // btnManualMode
            // 
            this.btnManualMode.Location = new System.Drawing.Point(117, 12);
            this.btnManualMode.Name = "btnManualMode";
            this.btnManualMode.Size = new System.Drawing.Size(102, 40);
            this.btnManualMode.TabIndex = 1;
            this.btnManualMode.Text = "Manual Mode";
            this.btnManualMode.UseVisualStyleBackColor = true;
            this.btnManualMode.Click += new System.EventHandler(this.btnManualMode_Click);
            // 
            // trkRightMotorSpeed
            // 
            this.trkRightMotorSpeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trkRightMotorSpeed.LargeChange = 10;
            this.trkRightMotorSpeed.Location = new System.Drawing.Point(12, 108);
            this.trkRightMotorSpeed.Maximum = 255;
            this.trkRightMotorSpeed.Minimum = 70;
            this.trkRightMotorSpeed.Name = "trkRightMotorSpeed";
            this.trkRightMotorSpeed.Size = new System.Drawing.Size(215, 45);
            this.trkRightMotorSpeed.TabIndex = 3;
            this.trkRightMotorSpeed.TickFrequency = 19;
            this.trkRightMotorSpeed.Value = 120;
            this.trkRightMotorSpeed.ValueChanged += new System.EventHandler(this.trkRightMotorSpeed_ValueChanged);
            this.trkRightMotorSpeed.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trkRightMotorSpeed_MouseUp);
            // 
            // lblLeftMotorSpeed
            // 
            this.lblLeftMotorSpeed.AutoSize = true;
            this.lblLeftMotorSpeed.Location = new System.Drawing.Point(29, 21);
            this.lblLeftMotorSpeed.Name = "lblLeftMotorSpeed";
            this.lblLeftMotorSpeed.Size = new System.Drawing.Size(113, 13);
            this.lblLeftMotorSpeed.TabIndex = 4;
            this.lblLeftMotorSpeed.Text = "Left Motor Speed: 120";
            // 
            // lblRightMotorSpeed
            // 
            this.lblRightMotorSpeed.AutoSize = true;
            this.lblRightMotorSpeed.Location = new System.Drawing.Point(29, 92);
            this.lblRightMotorSpeed.Name = "lblRightMotorSpeed";
            this.lblRightMotorSpeed.Size = new System.Drawing.Size(120, 13);
            this.lblRightMotorSpeed.TabIndex = 5;
            this.lblRightMotorSpeed.Text = "Right Motor Speed: 120";
            // 
            // trkLeftMotorSpeed
            // 
            this.trkLeftMotorSpeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trkLeftMotorSpeed.LargeChange = 10;
            this.trkLeftMotorSpeed.Location = new System.Drawing.Point(12, 37);
            this.trkLeftMotorSpeed.Maximum = 255;
            this.trkLeftMotorSpeed.Minimum = 70;
            this.trkLeftMotorSpeed.Name = "trkLeftMotorSpeed";
            this.trkLeftMotorSpeed.Size = new System.Drawing.Size(215, 45);
            this.trkLeftMotorSpeed.TabIndex = 6;
            this.trkLeftMotorSpeed.TickFrequency = 19;
            this.trkLeftMotorSpeed.Value = 120;
            this.trkLeftMotorSpeed.ValueChanged += new System.EventHandler(this.trkLeftMotorSpeed_ValueChanged);
            this.trkLeftMotorSpeed.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trkLeftMotorSpeed_MouseUp);
            // 
            // lblLeftMotorMin
            // 
            this.lblLeftMotorMin.AutoSize = true;
            this.lblLeftMotorMin.Location = new System.Drawing.Point(0, 52);
            this.lblLeftMotorMin.Name = "lblLeftMotorMin";
            this.lblLeftMotorMin.Size = new System.Drawing.Size(19, 13);
            this.lblLeftMotorMin.TabIndex = 7;
            this.lblLeftMotorMin.Text = "70";
            // 
            // lblRightMotorMin
            // 
            this.lblRightMotorMin.AutoSize = true;
            this.lblRightMotorMin.Location = new System.Drawing.Point(0, 121);
            this.lblRightMotorMin.Name = "lblRightMotorMin";
            this.lblRightMotorMin.Size = new System.Drawing.Size(19, 13);
            this.lblRightMotorMin.TabIndex = 8;
            this.lblRightMotorMin.Text = "70";
            // 
            // lblLeftMotorMax
            // 
            this.lblLeftMotorMax.AutoSize = true;
            this.lblLeftMotorMax.Location = new System.Drawing.Point(224, 52);
            this.lblLeftMotorMax.Name = "lblLeftMotorMax";
            this.lblLeftMotorMax.Size = new System.Drawing.Size(25, 13);
            this.lblLeftMotorMax.TabIndex = 9;
            this.lblLeftMotorMax.Text = "255";
            // 
            // lblRightMotorMax
            // 
            this.lblRightMotorMax.AutoSize = true;
            this.lblRightMotorMax.Location = new System.Drawing.Point(224, 121);
            this.lblRightMotorMax.Name = "lblRightMotorMax";
            this.lblRightMotorMax.Size = new System.Drawing.Size(25, 13);
            this.lblRightMotorMax.TabIndex = 10;
            this.lblRightMotorMax.Text = "255";
            // 
            // btnControlBrake
            // 
            this.btnControlBrake.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnControlBrake.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnControlBrake.Location = new System.Drawing.Point(34, 200);
            this.btnControlBrake.Name = "btnControlBrake";
            this.btnControlBrake.Size = new System.Drawing.Size(179, 40);
            this.btnControlBrake.TabIndex = 15;
            this.btnControlBrake.Text = "Emergency Brake";
            this.btnControlBrake.UseVisualStyleBackColor = true;
            this.btnControlBrake.Click += new System.EventHandler(this.btnControlBrake_Click);
            // 
            // gbxMovementControls
            // 
            this.gbxMovementControls.Controls.Add(this.btnControlBrake);
            this.gbxMovementControls.Controls.Add(this.btnControlReverse);
            this.gbxMovementControls.Controls.Add(this.btnControlRight);
            this.gbxMovementControls.Controls.Add(this.btnControlLeft);
            this.gbxMovementControls.Controls.Add(this.btnControlForward);
            this.gbxMovementControls.Location = new System.Drawing.Point(331, 169);
            this.gbxMovementControls.Name = "gbxMovementControls";
            this.gbxMovementControls.Size = new System.Drawing.Size(248, 260);
            this.gbxMovementControls.TabIndex = 16;
            this.gbxMovementControls.TabStop = false;
            this.gbxMovementControls.Text = "Movement Controls";
            // 
            // btnControlReverse
            // 
            this.btnControlReverse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnControlReverse.Image = ((System.Drawing.Image)(resources.GetObject("btnControlReverse.Image")));
            this.btnControlReverse.Location = new System.Drawing.Point(97, 141);
            this.btnControlReverse.Name = "btnControlReverse";
            this.btnControlReverse.Size = new System.Drawing.Size(57, 53);
            this.btnControlReverse.TabIndex = 14;
            this.btnControlReverse.UseVisualStyleBackColor = true;
            this.btnControlReverse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnControlReverse_MouseDown);
            this.btnControlReverse.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnControlReverse_MouseUp);
            // 
            // btnControlRight
            // 
            this.btnControlRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnControlRight.Image = ((System.Drawing.Image)(resources.GetObject("btnControlRight.Image")));
            this.btnControlRight.Location = new System.Drawing.Point(156, 82);
            this.btnControlRight.Name = "btnControlRight";
            this.btnControlRight.Size = new System.Drawing.Size(57, 53);
            this.btnControlRight.TabIndex = 13;
            this.btnControlRight.UseVisualStyleBackColor = true;
            this.btnControlRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnControlRight_MouseDown);
            this.btnControlRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnControlRight_MouseUp);
            // 
            // btnControlLeft
            // 
            this.btnControlLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnControlLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnControlLeft.Image")));
            this.btnControlLeft.Location = new System.Drawing.Point(34, 83);
            this.btnControlLeft.Name = "btnControlLeft";
            this.btnControlLeft.Size = new System.Drawing.Size(57, 53);
            this.btnControlLeft.TabIndex = 12;
            this.btnControlLeft.UseVisualStyleBackColor = true;
            this.btnControlLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnControlLeft_MouseDown);
            this.btnControlLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnControlLeft_MouseUp);
            // 
            // btnControlForward
            // 
            this.btnControlForward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnControlForward.Image = ((System.Drawing.Image)(resources.GetObject("btnControlForward.Image")));
            this.btnControlForward.Location = new System.Drawing.Point(97, 24);
            this.btnControlForward.Name = "btnControlForward";
            this.btnControlForward.Size = new System.Drawing.Size(57, 53);
            this.btnControlForward.TabIndex = 11;
            this.btnControlForward.UseVisualStyleBackColor = true;
            this.btnControlForward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnControlForward_MouseDown);
            this.btnControlForward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnControlForward_MouseUp);
            // 
            // gbxSpeedControls
            // 
            this.gbxSpeedControls.Controls.Add(this.lblRightMotorMax);
            this.gbxSpeedControls.Controls.Add(this.lblLeftMotorMax);
            this.gbxSpeedControls.Controls.Add(this.lblRightMotorMin);
            this.gbxSpeedControls.Controls.Add(this.lblLeftMotorMin);
            this.gbxSpeedControls.Controls.Add(this.trkLeftMotorSpeed);
            this.gbxSpeedControls.Controls.Add(this.lblRightMotorSpeed);
            this.gbxSpeedControls.Controls.Add(this.lblLeftMotorSpeed);
            this.gbxSpeedControls.Controls.Add(this.trkRightMotorSpeed);
            this.gbxSpeedControls.Location = new System.Drawing.Point(23, 21);
            this.gbxSpeedControls.Name = "gbxSpeedControls";
            this.gbxSpeedControls.Size = new System.Drawing.Size(265, 161);
            this.gbxSpeedControls.TabIndex = 17;
            this.gbxSpeedControls.TabStop = false;
            this.gbxSpeedControls.Text = "Speed Controls";
            // 
            // btnDistReading
            // 
            this.btnDistReading.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDistReading.Location = new System.Drawing.Point(10, 17);
            this.btnDistReading.Name = "btnDistReading";
            this.btnDistReading.Size = new System.Drawing.Size(100, 40);
            this.btnDistReading.TabIndex = 18;
            this.btnDistReading.Text = "Get Distance Reading";
            this.btnDistReading.UseVisualStyleBackColor = true;
            this.btnDistReading.Click += new System.EventHandler(this.btnDistReading_Click);
            // 
            // btnCalcSpeed
            // 
            this.btnCalcSpeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcSpeed.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCalcSpeed.Location = new System.Drawing.Point(10, 76);
            this.btnCalcSpeed.Name = "btnCalcSpeed";
            this.btnCalcSpeed.Size = new System.Drawing.Size(100, 40);
            this.btnCalcSpeed.TabIndex = 19;
            this.btnCalcSpeed.Text = "Calculate Speed";
            this.btnCalcSpeed.UseVisualStyleBackColor = true;
            this.btnCalcSpeed.Click += new System.EventHandler(this.btnCalcSpeed_Click);
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(127, 87);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(100, 20);
            this.txtSpeed.TabIndex = 20;
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(127, 28);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(100, 20);
            this.txtDistance.TabIndex = 21;
            // 
            // lblCm
            // 
            this.lblCm.AutoSize = true;
            this.lblCm.Location = new System.Drawing.Point(233, 31);
            this.lblCm.Name = "lblCm";
            this.lblCm.Size = new System.Drawing.Size(21, 13);
            this.lblCm.TabIndex = 22;
            this.lblCm.Text = "cm";
            // 
            // lblCmPerSec
            // 
            this.lblCmPerSec.AutoSize = true;
            this.lblCmPerSec.Location = new System.Drawing.Point(233, 90);
            this.lblCmPerSec.Name = "lblCmPerSec";
            this.lblCmPerSec.Size = new System.Drawing.Size(31, 13);
            this.lblCmPerSec.TabIndex = 23;
            this.lblCmPerSec.Text = "cm/s";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(124, 12);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(52, 13);
            this.lblDistance.TabIndex = 24;
            this.lblDistance.Text = "Distance:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Speed:";
            // 
            // gbxMiscControls
            // 
            this.gbxMiscControls.Controls.Add(this.label4);
            this.gbxMiscControls.Controls.Add(this.lblDistance);
            this.gbxMiscControls.Controls.Add(this.lblCmPerSec);
            this.gbxMiscControls.Controls.Add(this.lblCm);
            this.gbxMiscControls.Controls.Add(this.txtDistance);
            this.gbxMiscControls.Controls.Add(this.txtSpeed);
            this.gbxMiscControls.Controls.Add(this.btnCalcSpeed);
            this.gbxMiscControls.Controls.Add(this.btnDistReading);
            this.gbxMiscControls.Location = new System.Drawing.Point(315, 21);
            this.gbxMiscControls.Name = "gbxMiscControls";
            this.gbxMiscControls.Size = new System.Drawing.Size(273, 129);
            this.gbxMiscControls.TabIndex = 26;
            this.gbxMiscControls.TabStop = false;
            this.gbxMiscControls.Text = "Miscellaneous Controls";
            // 
            // txtSerialInput
            // 
            this.txtSerialInput.Location = new System.Drawing.Point(60, 17);
            this.txtSerialInput.Name = "txtSerialInput";
            this.txtSerialInput.Size = new System.Drawing.Size(215, 20);
            this.txtSerialInput.TabIndex = 27;
            this.txtSerialInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSerialInput_KeyPress);
            // 
            // txtSerialTerminal
            // 
            this.txtSerialTerminal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSerialTerminal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtSerialTerminal.ForeColor = System.Drawing.SystemColors.Info;
            this.txtSerialTerminal.Location = new System.Drawing.Point(13, 43);
            this.txtSerialTerminal.Multiline = true;
            this.txtSerialTerminal.Name = "txtSerialTerminal";
            this.txtSerialTerminal.ReadOnly = true;
            this.txtSerialTerminal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSerialTerminal.Size = new System.Drawing.Size(262, 183);
            this.txtSerialTerminal.TabIndex = 28;
            this.txtSerialTerminal.Text = "Type \'/h\' for tips on how to use the controller. \r\n\r\nType \'/i\' for more informati" +
    "on on Hydra.\r\n\r\nType \'/c\' to clear the terminal.";
            // 
            // gbxSerialTerminal
            // 
            this.gbxSerialTerminal.Controls.Add(this.btnTerminalInput);
            this.gbxSerialTerminal.Controls.Add(this.txtSerialTerminal);
            this.gbxSerialTerminal.Controls.Add(this.txtSerialInput);
            this.gbxSerialTerminal.Location = new System.Drawing.Point(13, 193);
            this.gbxSerialTerminal.Name = "gbxSerialTerminal";
            this.gbxSerialTerminal.Size = new System.Drawing.Size(280, 239);
            this.gbxSerialTerminal.TabIndex = 29;
            this.gbxSerialTerminal.TabStop = false;
            this.gbxSerialTerminal.Text = "Serial Terminal";
            // 
            // btnTerminalInput
            // 
            this.btnTerminalInput.Location = new System.Drawing.Point(6, 16);
            this.btnTerminalInput.Name = "btnTerminalInput";
            this.btnTerminalInput.Size = new System.Drawing.Size(48, 21);
            this.btnTerminalInput.TabIndex = 29;
            this.btnTerminalInput.Text = "Input";
            this.btnTerminalInput.UseVisualStyleBackColor = true;
            this.btnTerminalInput.Click += new System.EventHandler(this.btnTerminalInput_Click);
            // 
            // gbxManualControls
            // 
            this.gbxManualControls.Controls.Add(this.gbxSerialTerminal);
            this.gbxManualControls.Controls.Add(this.gbxMiscControls);
            this.gbxManualControls.Controls.Add(this.gbxSpeedControls);
            this.gbxManualControls.Controls.Add(this.gbxMovementControls);
            this.gbxManualControls.Enabled = false;
            this.gbxManualControls.Location = new System.Drawing.Point(9, 61);
            this.gbxManualControls.Name = "gbxManualControls";
            this.gbxManualControls.Size = new System.Drawing.Size(608, 435);
            this.gbxManualControls.TabIndex = 30;
            this.gbxManualControls.TabStop = false;
            // 
            // btnConnectBluetooth
            // 
            this.btnConnectBluetooth.Location = new System.Drawing.Point(520, 12);
            this.btnConnectBluetooth.Name = "btnConnectBluetooth";
            this.btnConnectBluetooth.Size = new System.Drawing.Size(104, 40);
            this.btnConnectBluetooth.TabIndex = 31;
            this.btnConnectBluetooth.Text = "Manually Connect to Device";
            this.btnConnectBluetooth.UseVisualStyleBackColor = true;
            this.btnConnectBluetooth.Click += new System.EventHandler(this.btnConnectBluetooth_Click);
            // 
            // frmHydraController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(636, 500);
            this.Controls.Add(this.btnConnectBluetooth);
            this.Controls.Add(this.gbxManualControls);
            this.Controls.Add(this.btnManualMode);
            this.Controls.Add(this.btnAutoMode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHydraController";
            this.Text = "Hydra Remote Controller (Not Connected)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHydraController_FormClosing);
            this.Load += new System.EventHandler(this.frmHydraController_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trkRightMotorSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkLeftMotorSpeed)).EndInit();
            this.gbxMovementControls.ResumeLayout(false);
            this.gbxSpeedControls.ResumeLayout(false);
            this.gbxSpeedControls.PerformLayout();
            this.gbxMiscControls.ResumeLayout(false);
            this.gbxMiscControls.PerformLayout();
            this.gbxSerialTerminal.ResumeLayout(false);
            this.gbxSerialTerminal.PerformLayout();
            this.gbxManualControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnAutoMode;
        private System.Windows.Forms.Button btnManualMode;
        private System.Windows.Forms.TrackBar trkRightMotorSpeed;
        private System.Windows.Forms.Label lblLeftMotorSpeed;
        private System.Windows.Forms.Label lblRightMotorSpeed;
        private System.Windows.Forms.TrackBar trkLeftMotorSpeed;
        private System.Windows.Forms.Label lblLeftMotorMin;
        private System.Windows.Forms.Label lblRightMotorMin;
        private System.Windows.Forms.Label lblLeftMotorMax;
        private System.Windows.Forms.Label lblRightMotorMax;
        private System.Windows.Forms.Button btnControlForward;
        private System.Windows.Forms.Button btnControlLeft;
        private System.Windows.Forms.Button btnControlRight;
        private System.Windows.Forms.Button btnControlReverse;
        private System.Windows.Forms.Button btnControlBrake;
        private System.Windows.Forms.GroupBox gbxMovementControls;
        private System.Windows.Forms.GroupBox gbxSpeedControls;
        private System.Windows.Forms.Button btnDistReading;
        private System.Windows.Forms.Button btnCalcSpeed;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label lblCm;
        private System.Windows.Forms.Label lblCmPerSec;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbxMiscControls;
        private System.Windows.Forms.TextBox txtSerialInput;
        private System.Windows.Forms.TextBox txtSerialTerminal;
        private System.Windows.Forms.GroupBox gbxSerialTerminal;
        private System.Windows.Forms.GroupBox gbxManualControls;
        private System.Windows.Forms.Button btnConnectBluetooth;
        private System.Windows.Forms.Button btnTerminalInput;
    }
}

