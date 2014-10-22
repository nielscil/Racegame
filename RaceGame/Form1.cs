using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using System.Data;
using System.Drawing;
using Color = System.Drawing.Color;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows;

namespace RaceGame
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Form1 : Form
    {
        Player player1 = new Player();
        Track track = new Track();

        Bitmap Backbuffer;
        Bitmap paused = new Bitmap(RaceGame.Properties.Resources.text_paused_resized);
        float angle = 0;
        float speed = 0;
        bool r,l,f,b = false;
        int i = 0;       
        int fuel = 100;
        double distance = 0;
        Timer GameTimer = new Timer();
        Timer timerFuel = new Timer();
        TimeSpan stopwatch = new TimeSpan();
        bool noFuel = false;
        bool checkPoint_1 = false;
        bool checkPoint_2 = false;
        bool checkPoint_3 = false;
        bool checkPoint_4 = false;
        bool checkPoint_5 = false;
        bool checkPoint_6 = false;
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
            GameTimer.Interval = 10;
            GameTimer.Tick += new EventHandler(GameTimer_Tick);
            GameTimer.Start();
            KeyPreview = true;
            timerFuel.Interval = 5;
            timerFuel.Tick += new EventHandler(timerFuel_Tick_1);
            timerFuel.Start();
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
                panel1.Visible = true;
                fuelBar.Visible = false;
                fuelLabel.Visible = false;
                label2.Visible = false;
                i++;
            }
            else
            {
                panel1.Visible = false;
                GameTimer.Start();
                timerFuel.Start();
                fuelBar.Visible = true;
                fuelLabel.Visible = true;
                label2.Visible = true;
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

        void GameTimer_Tick(object sender, EventArgs e)
        {
            if (l == true && speed != 0)
            {
                angle -= 0.03f;
            }
            else if (r == true && speed != 0)
            {
                angle += 0.03f;
            }
            
            if (f == true && speed > -3)
            {
                speed -= 0.3f;
            }
            else if (b== true && speed < 3)
            {
                speed += 0.3f;
            }

            player1.carSpeed.X = (float)(speed * Math.Cos(angle));
            player1.carSpeed.Y = (float)(speed * Math.Sin(angle));
            player1.carPos.X += player1.carSpeed.X;
            player1.carPos.Y += player1.carSpeed.Y;
            stopwatch = stopwatch.Add(TimeSpan.FromMilliseconds(10));
            label3.Text = stopwatch.ToString();
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
            if( (player1.carPos.X + 25) > 425f && (player1.carPos.X + 25) < 650f && (player1.carPos.Y + 25) > 680 && (player1.carPos.Y + 25) < 750 && player1.carSpeed.X == 0 && player1.carSpeed.Y == 0)//checkt of balletje stil is in het aangegeven vak.
            {
                
                if (fuel < 100)
                {
                    fuel += 1;
                }

            }
            fuelBar.Value = fuel;
            fuelBar.CreateGraphics().DrawString(fuel.ToString(), new Font("Sitka Text", (float)24, System.Drawing.FontStyle.Bold), System.Drawing.Brushes.Black, new PointF(fuelBar.Width / 2 - 30, fuelBar.Height / 2 - 16));
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

        void myForm_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            int myX = e.X;
            int myY = e.Y;

            Console.WriteLine("X: " + myX + " Y: " + myY);
        }

        private void checkPoint()
        {
            //checkpoint 1.
            if ((player1.carPos.X + 25 >= 275 & player1.carPos.X + 25 <= 280) & (player1.carPos.Y >= 588 & player1.carPos.Y <= 668))
            {
                checkPoint_1 = true;
                label1.Text = "Checkpoint 1 reached";
            }

            if ((player1.carPos.X + 25 >= 165 & player1.carPos.X <= 170) & (player1.carPos.Y >= 74 & player1.carPos.Y <= 148) & checkPoint_1 == true)
            {
                checkPoint_2 = true;
                label1.Text = "Checkpoint 2 reached";
            }

            if ((player1.carPos.X >= 434 & player1.carPos.X <= 499) & (player1.carPos.Y >= 192 & player1.carPos.Y <= 197) & checkPoint_2 == true)
            {
                checkPoint_3 = true;
                label1.Text = "Checkpoint 3 reached";
            }

            if ((player1.carPos.X >= 578 & player1.carPos.X <= 583) & (player1.carPos.Y >= 414 & player1.carPos.Y <= 488) & checkPoint_3 == true)
            {
                checkPoint_4 = true;
                label1.Text = "Checkpoint 4 reached";
            }

            if ((player1.carPos.X >= 852 & player1.carPos.X <= 857) & (player1.carPos.Y >= 0 & player1.carPos.Y <= 69) & checkPoint_4 == true)
            {
                checkPoint_5 = true;
                label1.Text = "Checkpoint 5 reached";
            }

            if ((player1.carPos.X >= 793 & player1.carPos.X <= 798) & (player1.carPos.Y >= 589 & player1.carPos.Y <= 672) & checkPoint_5 == true)
            {
                checkPoint_6 = true;
                label1.Text = "Checkpoint 6 reached";
            }
        }

        private void finish()
        {
            if ((player1.carPos.X >= 537 & player1.carPos.X <= 542) & (player1.carPos.Y >= 501 & player1.carPos.Y <= 580) & checkPoint_6 == true)
            {
                switch (label4.Text)
                {
                    case "Ronde: 1":
                        label4.Text = "Ronde: 2";
                        checkPoint_1 = false;
                        checkPoint_2 = false;
                        checkPoint_3 = false;
                        checkPoint_4 = false;
                        checkPoint_5 = false;
                        checkPoint_6 = false;
                        break;

                    case "Ronde: 2":
                        label4.Text = "Ronde: 3";
                        checkPoint_1 = false;
                        checkPoint_2 = false;
                        checkPoint_3 = false;
                        checkPoint_4 = false;
                        checkPoint_5 = false;
                        checkPoint_6 = false;
                        break;

                    case "Ronde: 3":
                        label4.Text = "Ronde: 4";
                        checkPoint_1 = false;
                        checkPoint_2 = false;
                        checkPoint_3 = false;
                        checkPoint_4 = false;
                        checkPoint_5 = false;
                        checkPoint_6 = false;
                        break;

                    case "Ronde: 4":
                        label4.Text = "Ronde: 5";
                        checkPoint_1 = false;
                        checkPoint_2 = false;
                        checkPoint_3 = false;
                        checkPoint_4 = false;
                        checkPoint_5 = false;
                        checkPoint_6 = false;
                        break;

                    case "Ronde: 5":
                        label4.Text = "Finish";
                        checkPoint_1 = false;
                        checkPoint_2 = false;
                        checkPoint_3 = false;
                        checkPoint_4 = false;
                        checkPoint_5 = false;
                        checkPoint_6 = false;
                        break;
                }
            }
        }
    }
}
