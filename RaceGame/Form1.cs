using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using System.Data;
using System.Drawing;
using Color = System.Drawing.Color;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows;

namespace RaceGame
{
    //Met commentaar heb ik even een todo lijst toegevoegd bij de code die miss verrandert kan worden.(Eelke/Wolfgang) :D
    //Of dat er iets mee gedaan moet worden.
    public partial class Form1 : Form
    {
        Player player1 = new Player();
        Track track = new Track();

        Bitmap Backbuffer;
        Bitmap paused = new Bitmap(RaceGame.Properties.Resources.text_paused_resized);
        float angle = 0; //Moet nog per player worden gedaan.
        float speed = 0; //Moet nog per player worden gedaan.
        bool r, l, f, b = false; //Moet nog per player worden gedaan.
        int i,j = 0;
        int fuel = 100; //Moet nog per player worden gedaan.
        double distance = 0; //Moet nog per player worden gedaan.
        double countDownTimer = 2;
        System.Windows.Forms.Timer GameTimer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer timerFuel = new System.Windows.Forms.Timer();
        TimeSpan total = new TimeSpan();
        TimeSpan Player1 = new TimeSpan(); //Player1 is een TimeSpan en player1 is een Player, is dit niet ingewikkeld?
        TimeSpan Player2 = new TimeSpan(); // Same as above, maar Player player2 word nooit aangemaakt?
        bool noFuel = false; //Moet nog per player worden gedaan.
        byte checkpointcounter = 0;
        string bestLab = ""; //Moet dit per persoon, of is dit beste rondetijd die speelbeurt?
        public Form1()
        {
            InitializeComponent();

            player1.carPos= new PointF(545f, 515f);
            player1.carSpeed = new PointF(0, 0);
            track.track = new Bitmap(RaceGame.Properties.Resources.racetrack);            
            this.SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.DoubleBuffer, true);
            timer1.Interval = 1;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
            GameTimer.Interval = 10;
            GameTimer.Tick += new EventHandler(GameTimer_Tick);            
            KeyPreview = true;
            timerFuel.Interval = 100;
            timerFuel.Tick += new EventHandler(timerFuel_Tick_1);
            this.ResizeEnd += new EventHandler(Form1_CreateBackBuffer);
            this.Load += new EventHandler(Form1_CreateBackBuffer);
            this.Paint += new PaintEventHandler(Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(Form1_keyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(myForm_MouseClick);
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }
        void ESC()
        {
            if (i == 0)
            {
                GameTimer.Stop();
                timerFuel.Stop();
                timer1.Stop();               
                panel1.Visible = true;
                fuelBar.Visible = false;
                fuelLabel.Visible = false;
                label2.Visible = false;
                label1.Visible = false;
                label4.Visible = false;
                label3.Visible = false;
                i++;
            }
            else
            {
                panel1.Visible = false;
                GameTimer.Start();
                timerFuel.Start();
                timer1.Start();
                fuelBar.Visible = true;
                fuelLabel.Visible = true;
                label2.Visible = true;
                label1.Visible = true;
                label4.Visible = true;
                label3.Visible = true;
                i = 0;
            }
           
        }
        void Form1_keyUp(object sender, System.Windows.Forms.KeyEventArgs e)// wanneer toets losgelaten wordt, gebeurt dit
        {
            if (e.KeyCode == Keys.Left)
            {
                l = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                r = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                b = false;
            }
            else if (e.KeyCode == Keys.Up)
            {
                f = false;
            }
        }
        void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)// wanneer toets ingedrukt wordt, gebeurt dit
        {
            if(noFuel == false)
            {
                switch(e.KeyCode)
                {
                    case Keys.Left:
                        {
                            l = true;
                        }
                        break;
                case Keys.Right:
                    {
                        r = true;
                    }
                    break;
                case Keys.Up:
                    {
                        f = true;
                    }
                    break;
                case Keys.Down:
                    {
                        b = true;
                    }
                    break;
                }
            }
            if (e.KeyCode == Keys.Escape)
                ESC();                  
        }
        void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (Backbuffer != null)
            {
                e.Graphics.DrawImageUnscaled(Backbuffer, System.Drawing.Point.Empty);
            }
        }

        void Form1_CreateBackBuffer(object sender, EventArgs e)
        {
            if (Backbuffer != null)
                Backbuffer.Dispose();

            Backbuffer = new Bitmap(1024, 768);
        }

        Bitmap rotateCenter(Image b, float angle)
        {
            Bitmap returnBitmap = new Bitmap(b.Width, b.Height + 1);
            Graphics g = Graphics.FromImage(returnBitmap);
            g.TranslateTransform((float)b.Width / 2, (float)b.Height / 2);
            g.RotateTransform(angle * (float)(57.1));
            g.TranslateTransform(-(float)b.Width / 2, -(float)b.Height / 2);
            g.DrawImage(b, b.Width / 2 - b.Height / 2, b.Height / 2 - b.Width / 2, b.Height, b.Width);

            return returnBitmap;
        }
        void Draw()
        {
            using (var g = Graphics.FromImage(Backbuffer))
            {
                if (Backbuffer != null)
                {
                    System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Brushes.Black);
                    g.DrawImage(track.track, 0, 0, 1024, 768);
                    Invalidate();
                    g.DrawImage(rotateCenter(player1.Auto, angle), player1.carPos);
                }
            }
        }
        void timer1_Tick(object sender, EventArgs e)
        {
            Draw();
            if (countDownTimer != 0)
            {
                timer1.Interval = 1000;
                countDownTimer = countDownTimer - 0.5;
                label4.Text = Convert.ToString(countDownTimer);
                label3.Text = "00:00:00:00";
            }
            if (countDownTimer < -0.3) //Waarom -0.3, ==-1 werkt ook toch?
            {
                timer1.Stop();
                label4.Text = "";
                
            }
            if (countDownTimer == 0)
            {
               
                label4.Text = "GO!";
                
                
                GameTimer.Start();
                timerFuel.Start();

                countDownTimer--;
                
            }
            
        }
        
        void GameTimer_Tick(object sender, EventArgs e)
        {
            if (l == true && (speed < -0.001f || speed > 0.001f))
            {
                angle -= 0.03f;
            }
            else if (r == true && (speed < -0.001f || speed > 0.001f))
            {
                angle += 0.03f;
            }
            
            if (f == true && speed > -3)
            {
                speed -= 0.1f;
            }
            else if (b== true && speed < 0.5)
            {
                speed += 0.05f;
            }
            if (f== false && speed < -0.001f)
            {
                speed += 0.02f;
            }
            else if(b == false && speed > 0.001f)
            {
                speed -= 0.02f;
            }
            else if(f == false && speed == -0.05)
            {
                speed = 0;
            }
            else if (b == false && speed == 0.05)
            {
                speed = 0;
            }
            player1.carSpeed.X = (float)(speed * Math.Cos(angle));
            player1.carSpeed.Y = (float)(speed * Math.Sin(angle));
            player1.carPos.X += player1.carSpeed.X;
            player1.carPos.Y += player1.carSpeed.Y;
            total = total.Add(TimeSpan.FromMilliseconds(10));
            Player1 = Player1.Add(TimeSpan.FromMilliseconds(10));
            Player2 = Player2.Add(TimeSpan.FromMilliseconds(10));
            label3.Text = total.ToString(); //Betere naam voor label3, zoals labelTijdPlayer1 ofzo?
  //          label5.Text =Player1.ToString();//idem
  //          label12.Text = Player2.ToString(); //idem
            label1.Text = Convert.ToString(fuel);
            distance += Math.Sqrt(Math.Pow(player1.carSpeed.X, 2) + Math.Pow(player1.carSpeed.Y, 2));
            Draw();
            checkPoint();
            finish();
        }

        void timerFuel_Tick_1(object sender, EventArgs e)         
        {
            
            if (distance >= Math.Sqrt(Math.Pow(50, 2) + Math.Pow(70, 2)))
            {
                fuel--;
                distance = 0;
            }
            if (fuel == 0)
            {
                speed = 0;
                noFuel = true;              
            }
            if( (player1.carPos.X + 25) > 425f && (player1.carPos.X + 25) < 650f && (player1.carPos.Y + 25) > 680 && (player1.carPos.Y + 25) < 750 && speed < 0.001f && speed > -0.001f)//checkt of balletje stil is in het aangegeven vak.
            {
                
                if (fuel < 100)
                {
                    fuel++;
                }

            }
            fuelBar.Value = fuel;
            fuelBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            fuelBar.BackColor = Color.Silver;
            fuelBar.ForeColor = Color.Green;
            if (fuel < 50 && fuel > 30)
            {
                fuelBar.ForeColor = Color.Orange;
            }
            else if(fuel <= 30 && fuel > 10)
            {
                fuelBar.ForeColor = Color.OrangeRed;
            }
            else if(fuel <=10)
            {
                fuelBar.ForeColor = Color.Red;
            }
         }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void myForm_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e) //Waarvoor is dit?
        {
            int myX = e.X;
            int myY = e.Y;

            Console.WriteLine("X: " + myX + " Y: " + myY);
        }

        private void checkPointtimeplayer1()
        {
            for (int i = 0; i < checkpointcounter; )
            {
                label5.Text = Player1.ToString();
                i++;
            }

        }
        private void checkPoint()
        {
            //checkpoint 1. op track 1, deze punten moeten dus in class voor track1 komen te staan ofzo.
            if ((player1.carPos.X + 25 >= 275 & player1.carPos.X + 25 <= 280) & (player1.carPos.Y >= 588 & player1.carPos.Y <= 668))
            {
                player1.SetCheckpoint(1);
                checkpointcounter++;
                checkPointtimeplayer1();
            }
            //checkpoint 2???
            if ((player1.carPos.X + 25 >= 165 & player1.carPos.X <= 170) & (player1.carPos.Y >= 74 & player1.carPos.Y <= 148) & player1.CheckCheckpoint(1) == true)
            {
                player1.SetCheckpoint(2);
                checkpointcounter++;
                checkPointtimeplayer1();
            }
            //checkpoint 3???
            if ((player1.carPos.X >= 434 & player1.carPos.X <= 499) & (player1.carPos.Y >= 192 & player1.carPos.Y <= 197) & player1.CheckCheckpoint(2) == true)
            {
                player1.SetCheckpoint(3);
                checkpointcounter++;
                checkPointtimeplayer1();
            }
            //checkpoint 4???
            if ((player1.carPos.X >= 578 & player1.carPos.X <= 583) & (player1.carPos.Y >= 414 & player1.carPos.Y <= 488) & player1.CheckCheckpoint(3) == true)
            {
                player1.SetCheckpoint(4);
                checkpointcounter++;
                checkPointtimeplayer1();
            }
            //checkpoint 5???
            if ((player1.carPos.X >= 852 & player1.carPos.X <= 857) & (player1.carPos.Y >= 0 & player1.carPos.Y <= 69) & player1.CheckCheckpoint(4) == true)
            {
                player1.SetCheckpoint(5);
                checkpointcounter++;
                checkPointtimeplayer1();
            }
            //checkpoint 6???
            if ((player1.carPos.X >= 793 & player1.carPos.X <= 798) & (player1.carPos.Y >= 589 & player1.carPos.Y <= 672) & player1.CheckCheckpoint(5) == true)
            {
                player1.SetCheckpoint(6);
                checkpointcounter++;
                checkPointtimeplayer1();
            }
        }

        private void finish()
        {
            if ((player1.carPos.X >= 537 & player1.carPos.X <= 547) & (player1.carPos.Y >= 501 & player1.carPos.Y <= 768) & player1.finishCheck() == true)
            {
                switch (j)
                {
                    case 0:
                        label6.Text = "Ronde: 2";  
                       // label8.Text = "Best lab: " + bestLab;
                        
                        //bestLab = timestuff.ToString();
                        label8.Text = Player1.ToString();
                        Player1 = TimeSpan.Zero;
                       
                        player1.ResetCheckpoint();
                        
                        j++;
                        break;

                    case 1:
                        label6.Text = "Ronde: 3";
                        //if (TimeSpan.Parse(bestLab) < Player1)
                       // {
                        var now = TimeSpan.;

                            label8.Text = Player1.ToString(); //Hoe komt dit voor Player2? = zet er een 2 voor?
                       
                       // }
                        Player1 = TimeSpan.Zero;
                        player1.ResetCheckpoint();
                        j++;
                        break;

                    case 2:
                        label6.Text = "Ronde: 4";
                       
                        label8.Text = Player1.ToString();
                        
                        Player1 = TimeSpan.Zero;
                        player1.ResetCheckpoint();
                        j++;
                        break;

                    case 3:
                        label6.Text = "Ronde: 5";
                        label8.Text = Player1.ToString();
                        Player1 = TimeSpan.Zero;
                        player1.ResetCheckpoint();
                        j++;
                        break;

                    case 4:
                        label6.Text = "Finish";
                        label8.Text = Player1.ToString();
                        Player1 = TimeSpan.Zero;
                        player1.ResetCheckpoint();
                        j++;
                        break;
                }
            }
        }
    }
}
