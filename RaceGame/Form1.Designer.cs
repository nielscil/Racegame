namespace RaceGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelTimer = new System.Windows.Forms.Label();
            this.labelPlayer1Fuel = new System.Windows.Forms.Label();
            this.fuelAmount = new System.Windows.Forms.Label();
            this.progressBarPlayer1Fuel = new System.Windows.Forms.ProgressBar();
            this.timerFuel = new System.Windows.Forms.Timer(this.components);
            this.stopWatch = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonStop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.labelPlayer1FuelHoeveel = new System.Windows.Forms.Label();
            this.labelCountdown = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelPlayer1RondeTijd = new System.Windows.Forms.Label();
            this.labelPlayer1RondeNummer = new System.Windows.Forms.Label();
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.labelPlayer1BestLap = new System.Windows.Forms.Label();
            this.labelPlayer2BestLap = new System.Windows.Forms.Label();
            this.labelPlayer2 = new System.Windows.Forms.Label();
            this.labelPlayer2RondeNummer = new System.Windows.Forms.Label();
            this.labelPlayer2RondeTijd = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelTimer
            // 
            this.labelTimer.BackColor = System.Drawing.Color.Transparent;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.Location = new System.Drawing.Point(541, 125);
            this.labelTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(155, 24);
            this.labelTimer.TabIndex = 5;
            // 
            // labelPlayer1Fuel
            // 
            this.labelPlayer1Fuel.AutoSize = true;
            this.labelPlayer1Fuel.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer1Fuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer1Fuel.Location = new System.Drawing.Point(11, 635);
            this.labelPlayer1Fuel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlayer1Fuel.Name = "labelPlayer1Fuel";
            this.labelPlayer1Fuel.Size = new System.Drawing.Size(83, 37);
            this.labelPlayer1Fuel.TabIndex = 2;
            this.labelPlayer1Fuel.Text = "Fuel";
            // 
            // fuelAmount
            // 
            this.fuelAmount.AutoSize = true;
            this.fuelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelAmount.Location = new System.Drawing.Point(450, 70);
            this.fuelAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fuelAmount.Name = "fuelAmount";
            this.fuelAmount.Size = new System.Drawing.Size(0, 39);
            this.fuelAmount.TabIndex = 3;
            // 
            // progressBarPlayer1Fuel
            // 
            this.progressBarPlayer1Fuel.BackColor = System.Drawing.Color.White;
            this.progressBarPlayer1Fuel.Location = new System.Drawing.Point(14, 679);
            this.progressBarPlayer1Fuel.Margin = new System.Windows.Forms.Padding(2);
            this.progressBarPlayer1Fuel.Name = "progressBarPlayer1Fuel";
            this.progressBarPlayer1Fuel.Size = new System.Drawing.Size(100, 41);
            this.progressBarPlayer1Fuel.TabIndex = 4;
            // 
            // timerFuel
            // 
            this.timerFuel.Enabled = true;
            this.timerFuel.Tick += new System.EventHandler(this.timerFuel_Tick_1);
            // 
            // stopWatch
            // 
            this.stopWatch.Interval = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonStop);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonRestart);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.panel1.Location = new System.Drawing.Point(593, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 476);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(90, 201);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(83, 32);
            this.buttonStop.TabIndex = 4;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(386, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 39);
            this.label2.TabIndex = 3;
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(75, 119);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(111, 39);
            this.buttonRestart.TabIndex = 1;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelPlayer1FuelHoeveel
            // 
            this.labelPlayer1FuelHoeveel.AutoSize = true;
            this.labelPlayer1FuelHoeveel.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer1FuelHoeveel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer1FuelHoeveel.Location = new System.Drawing.Point(118, 683);
            this.labelPlayer1FuelHoeveel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlayer1FuelHoeveel.Name = "labelPlayer1FuelHoeveel";
            this.labelPlayer1FuelHoeveel.Size = new System.Drawing.Size(72, 37);
            this.labelPlayer1FuelHoeveel.TabIndex = 6;
            this.labelPlayer1FuelHoeveel.Text = "100";
            // 
            // labelCountdown
            // 
            this.labelCountdown.AutoSize = true;
            this.labelCountdown.BackColor = System.Drawing.Color.Transparent;
            this.labelCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountdown.Location = new System.Drawing.Point(514, 297);
            this.labelCountdown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCountdown.Name = "labelCountdown";
            this.labelCountdown.Size = new System.Drawing.Size(98, 108);
            this.labelCountdown.TabIndex = 5;
            this.labelCountdown.Text = "3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelPlayer1RondeTijd
            // 
            this.labelPlayer1RondeTijd.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer1RondeTijd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer1RondeTijd.Location = new System.Drawing.Point(416, 628);
            this.labelPlayer1RondeTijd.Name = "labelPlayer1RondeTijd";
            this.labelPlayer1RondeTijd.Size = new System.Drawing.Size(100, 23);
            this.labelPlayer1RondeTijd.TabIndex = 7;
            this.labelPlayer1RondeTijd.Text = "00:00:00";
            // 
            // labelPlayer1RondeNummer
            // 
            this.labelPlayer1RondeNummer.AutoSize = true;
            this.labelPlayer1RondeNummer.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer1RondeNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer1RondeNummer.Location = new System.Drawing.Point(416, 608);
            this.labelPlayer1RondeNummer.Name = "labelPlayer1RondeNummer";
            this.labelPlayer1RondeNummer.Size = new System.Drawing.Size(74, 20);
            this.labelPlayer1RondeNummer.TabIndex = 8;
            this.labelPlayer1RondeNummer.Text = "Ronde: 1";
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer1.Location = new System.Drawing.Point(416, 588);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(65, 20);
            this.labelPlayer1.TabIndex = 9;
            this.labelPlayer1.Text = "Player 1";
            // 
            // labelPlayer1BestLap
            // 
            this.labelPlayer1BestLap.AutoSize = true;
            this.labelPlayer1BestLap.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer1BestLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer1BestLap.Location = new System.Drawing.Point(391, 648);
            this.labelPlayer1BestLap.Name = "labelPlayer1BestLap";
            this.labelPlayer1BestLap.Size = new System.Drawing.Size(143, 20);
            this.labelPlayer1BestLap.TabIndex = 10;
            this.labelPlayer1BestLap.Text = "Best Lap: 00:00:00";
            // 
            // labelPlayer2BestLap
            // 
            this.labelPlayer2BestLap.AutoSize = true;
            this.labelPlayer2BestLap.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer2BestLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer2BestLap.Location = new System.Drawing.Point(550, 648);
            this.labelPlayer2BestLap.Name = "labelPlayer2BestLap";
            this.labelPlayer2BestLap.Size = new System.Drawing.Size(143, 20);
            this.labelPlayer2BestLap.TabIndex = 14;
            this.labelPlayer2BestLap.Text = "Best Lap: 00:00:00";
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.AutoSize = true;
            this.labelPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer2.Location = new System.Drawing.Point(577, 588);
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.Size = new System.Drawing.Size(65, 20);
            this.labelPlayer2.TabIndex = 13;
            this.labelPlayer2.Text = "Player 2";
            // 
            // labelPlayer2RondeNummer
            // 
            this.labelPlayer2RondeNummer.AutoSize = true;
            this.labelPlayer2RondeNummer.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer2RondeNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer2RondeNummer.Location = new System.Drawing.Point(577, 608);
            this.labelPlayer2RondeNummer.Name = "labelPlayer2RondeNummer";
            this.labelPlayer2RondeNummer.Size = new System.Drawing.Size(74, 20);
            this.labelPlayer2RondeNummer.TabIndex = 12;
            this.labelPlayer2RondeNummer.Text = "Ronde: 1";
            // 
            // labelPlayer2RondeTijd
            // 
            this.labelPlayer2RondeTijd.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer2RondeTijd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer2RondeTijd.Location = new System.Drawing.Point(566, 628);
            this.labelPlayer2RondeTijd.Name = "labelPlayer2RondeTijd";
            this.labelPlayer2RondeTijd.Size = new System.Drawing.Size(93, 20);
            this.labelPlayer2RondeTijd.TabIndex = 11;
            this.labelPlayer2RondeTijd.Text = "00:00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::RaceGame.Properties.Resources.racetrack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.labelPlayer2BestLap);
            this.Controls.Add(this.labelPlayer2);
            this.Controls.Add(this.labelPlayer2RondeNummer);
            this.Controls.Add(this.labelPlayer2RondeTijd);
            this.Controls.Add(this.labelPlayer1BestLap);
            this.Controls.Add(this.labelPlayer1);
            this.Controls.Add(this.labelPlayer1RondeNummer);
            this.Controls.Add(this.labelPlayer1RondeTijd);
            this.Controls.Add(this.labelPlayer1FuelHoeveel);
            this.Controls.Add(this.fuelAmount);
            this.Controls.Add(this.labelPlayer1Fuel);
            this.Controls.Add(this.labelCountdown);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.progressBarPlayer1Fuel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Terror Nerds Race Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Label labelPlayer1Fuel;
        private System.Windows.Forms.Label fuelAmount;
        private System.Windows.Forms.ProgressBar progressBarPlayer1Fuel;
        //private System.Windows.Forms.Timer timerFuel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer stopWatch;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelPlayer1FuelHoeveel;
        private System.Windows.Forms.Label labelCountdown;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelPlayer1RondeTijd;
        private System.Windows.Forms.Label labelPlayer1RondeNummer;
        private System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.Label labelPlayer1BestLap;
        private System.Windows.Forms.Label labelPlayer2BestLap;
        private System.Windows.Forms.Label labelPlayer2;
        private System.Windows.Forms.Label labelPlayer2RondeNummer;
        private System.Windows.Forms.Label labelPlayer2RondeTijd;

    }
}

