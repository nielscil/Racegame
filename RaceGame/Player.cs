using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceGame
{
    class Player
    {
        //private Form1 form1 = new Form1();
        private Track track = new Track();
        public string naam;
        private bool l,r,f,b = false;
        private float speed,angle = 0f;
        public int fuel = 100;
        public double distance = 0;
        private bool checkedCheckpoint1 = false;
        private bool checkedCheckpoint2 = false;
        private bool checkedCheckpoint3 = false;
        private bool checkedCheckpoint4 = false;
        private bool checkedCheckpoint5 = false;
        private bool checkedCheckpoint6 = false;
        public bool noFuel = false;
        public PointF carPos;
        public PointF carSpeed;
        public string ronde;
        public string bestlab;
        public string breaktime;
        private Bitmap auto = new Bitmap(RaceGame.Properties.Resources.AutoVierkantRood, 30, 30);
        public TimeSpan time = new TimeSpan();
        byte i = 0;
        byte checkpointcounter = 0;

        public void SetAuto(int nr)
        {
            switch(nr)
            {
                case 0:
                    auto = new Bitmap(RaceGame.Properties.Resources.AutoVierkantRood, 30, 30);
                    break;
                case 1:
                    auto = new Bitmap(RaceGame.Properties.Resources.AutoVierkantGroen, 30, 30);
                    break;
                case 2:
                    auto = new Bitmap(RaceGame.Properties.Resources.AutoVierkantBlauw, 30, 30);
                    break;
                case 3:
                    auto = new Bitmap(RaceGame.Properties.Resources.AutoVierkantGrijs, 30, 30);
                    break;
                case 4:
                    auto = new Bitmap(RaceGame.Properties.Resources.AutoVierkantRegenboog, 30, 30);
                    break;
            }
            
        }

        public Bitmap GetAuto()
        {
            return auto;
        }

        public void Finish()
        {
            if ((carPos.X >= track.finish_x1 & carPos.X <= track.finish_x2) & (carPos.Y >= track.finish_y1 & carPos.Y <= track.finish_y2) && FinishCheck() == true) // check ckepoint toevoegen
            {
                switch (i)
                {
                    case 0:
                        ronde = "Ronde: 2";
                        bestlab = time.ToString();
                        bestlab = "Best lap: " + bestlab;
                        time = TimeSpan.Zero;
                        i++;
                        break;

                    case 1:
                        ronde = "Ronde: 3";
                        //if (TimeSpan.Parse(bestlab) < time)
                        {
                            bestlab = time.ToString(); //Hoe komt dit voor Player2?
                        }
                        time = TimeSpan.Zero;
                        i++;
                        break;

                    case 2:
                        ronde = "Ronde: 4";
                       // if (TimeSpan.Parse(bestlab) < time)
                        {
                            bestlab = time.ToString();
                        }
                        time = TimeSpan.Zero;
                        i++;
                        break;
                    case 3:
                        ronde = "Ronde: 5";
                       // if (TimeSpan.Parse(bestlab) < time)
                        {
                            bestlab = time.ToString();
                        }
                        time = TimeSpan.Zero;
                        i++;
                        break;

                    case 4:
                        ronde = "Finish";
                        //if (TimeSpan.Parse(bestlab) < time)
                        {
                            bestlab = time.ToString();
                        }
                        time = TimeSpan.Zero;
                        i++;
                        break;
                }
            }
        }

        public void Race()
        {
            if (l == true && (speed < -0.001f || speed > 0.001f))
            {
                angle -= 0.03f;
            }
            else if (r == true && (speed < -0.001f || speed > 0.001f))
            {
                angle += 0.03f;
            }

            if (f == true && noFuel == false && speed > -3)
            {
                speed -= 0.1f;
            }
            else if (b == true && noFuel == false  && speed < 0.5)
            {
                speed += 0.05f;
            }
            if (f== false && noFuel == false && speed < -0.001f)
            {
                speed += 0.05f;
            }
            else if(b == false && noFuel == false && speed > 0.001f)
            {
                speed -= 0.05f;
            }
            else if(f == false && speed == -0.05)
            {
                speed = 0;
            }
            else if (b == false && speed == 0.05)
            {
                speed = 0;
            }
            time = time.Add(TimeSpan.FromMilliseconds(10));
            carSpeed.X = (float)(speed * Math.Cos(angle));
            carSpeed.Y = (float)(speed * Math.Sin(angle));
            carPos.X += carSpeed.X;
            carPos.Y += carSpeed.Y;
            distance += Math.Sqrt(Math.Pow(carSpeed.X, 2) + Math.Pow(carSpeed.Y, 2));
        }

        public void Fuel()
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
            else
                noFuel = false;
            if ((carPos.X + 25) > 425f && (carPos.X + 25) < 650f && (carPos.Y + 25) > 680 && (carPos.Y + 25) < 750 && speed < 0.001f && speed > -0.001f)//checkt of balletje stil is in het aangegeven vak.
            {
                if (fuel < 100)
                {
                    fuel++;
                }
            }
        }
        public string checkPointtimeplayer()
        {
            for (int i = 0; i < checkpointcounter; )
            {

                breaktime = time.ToString();
                i++;
            }
            return breaktime;
        }
        
        public void Checkpoints()
        {
            //checkpoint 1. op track 1, deze punten moeten dus in class voor track1 komen te staan ofzo.
            if ((carPos.X + 25 >= track.checkp1_x1 & carPos.X + 25 <= track.checkp1_x2) & (carPos.Y >= track.checkp1_y1 & carPos.Y <= track.checkp1_y2))
            {
                SetCheckpoint(1);
                checkpointcounter++;
                checkPointtimeplayer();
            }
            //checkpoint 2???
            if ((carPos.X + 25 >= track.checkp2_x1 & carPos.X <= track.checkp2_x2) & (carPos.Y >= track.checkp2_y1 & carPos.Y <= track.checkp2_y2) & CheckCheckpoint(1) == true)
            {
                SetCheckpoint(2);
                checkpointcounter++;
                checkPointtimeplayer();
            }
            //checkpoint 3???
            if ((carPos.X >= track.checkp3_x1 & carPos.X <= track.checkp2_x2) & (carPos.Y >= track.checkp3_y1 & carPos.Y <= track.checkp3_y2) & CheckCheckpoint(2) == true)
            {
                SetCheckpoint(3);
                checkpointcounter++;
                checkPointtimeplayer();
            }
            //checkpoint 4???
            if ((carPos.X >= track.checkp4_x1 & carPos.X <= track.checkp4_x2) & (carPos.Y >= track.checkp4_y1 & carPos.Y <= track.checkp4_y2) & CheckCheckpoint(3) == true)
            {
                SetCheckpoint(4);
                checkpointcounter++;
                checkPointtimeplayer();
            }
            //checkpoint 5???
            if ((carPos.X >= track.checkp5_x1 & carPos.X <= track.checkp5_x2) & (carPos.Y >= track.checkp5_y1 & carPos.Y <= track.checkp5_y2) & CheckCheckpoint(4) == true)
            {
                SetCheckpoint(5);
                checkpointcounter++;
                checkPointtimeplayer();
            }
            //checkpoint 6???
            if ((carPos.X >= track.checkp6_x1 & carPos.X <= track.checkp6_x1) & (carPos.Y >= track.checkp6_y1 & carPos.Y <= track.checkp6_y2) & CheckCheckpoint(5) == true)
            {
                SetCheckpoint(6);
                checkpointcounter++;
                checkPointtimeplayer();
            }
        }

        public Color GetFuelColor()
        {
            if(fuel >= 50)
            {
                return Color.Green;
            }
            else if (fuel < 50 && fuel > 30)
            {
                return Color.Orange;
            }
            else if (fuel <= 30 && fuel > 10)
            {
                return Color.OrangeRed;
            }
            else //if (fuel <= 10)
            {
                return Color.Red;
            }
        }

        public Bitmap rotateCenter()
        {
            Bitmap returnBitmap = new Bitmap(auto.Width, auto.Height + 1);
            Graphics g = Graphics.FromImage(returnBitmap);
            g.TranslateTransform((float)auto.Width / 2, (float)auto.Height / 2);
            g.RotateTransform(angle * (float)(57.1));
            g.TranslateTransform(-(float)auto.Width / 2, -(float)auto.Height / 2);
            g.DrawImage(auto, auto.Width / 2 - auto.Height / 2, auto.Height / 2 - auto.Width / 2, auto.Height, auto.Width);
            return returnBitmap;
        }

        public void Key_down(object sender, System.Windows.Forms.KeyEventArgs e,byte player)
        {
            if (player == 0)
            {
                switch (e.KeyCode)
                {
                    case Keys.Left:
                        l = true;
                        break;
                    case Keys.Right:
                        r = true;
                        break;
                    case Keys.Up:
                        f = true;
                        break;
                    case Keys.Down:
                        b = true;
                        break;
                }
            }
            else if (player == 1)
            {
                switch (e.KeyCode)
                {
                    case Keys.A:
                        l = true;
                        break;
                    case Keys.D:
                        r = true;
                        break;
                    case Keys.W:
                        f = true;
                        break;
                    case Keys.S:
                        b = true;
                        break;
                }
            }
        }

        public void Key_up(object sender, System.Windows.Forms.KeyEventArgs e,byte player)
        {
            if (player == 0)
            {
                switch (e.KeyCode)
                {
                    case Keys.Left:
                        l = false;
                        break;
                    case Keys.Right:
                        r = false;
                        break;
                    case Keys.Up:
                        f = false;
                        break;
                    case Keys.Down:
                        b = false;
                        break;
                }
            }
            else if (player == 1)
            {
                switch (e.KeyCode)
                {
                    case Keys.A:
                        l = false;
                        break;
                    case Keys.D:
                        r = false;
                        break;
                    case Keys.W:
                        f = false;
                        break;
                    case Keys.S:
                        b = false;
                        break;
                }
            }
        }

        /// <summary>
        /// zet checkpoint op true
        /// </summary>
        /// <param name="checkpointNummer">Nummer van checkpoint dat ge passeerd is</param>
        public void SetCheckpoint(int checkpointNummer)
        {
            switch (checkpointNummer)
            {
                case 1:
                    checkedCheckpoint1 = true;
                    break;

                case 2:
                    checkedCheckpoint2 = true;
                    break;

                case 3:
                    checkedCheckpoint3 = true;
                    break;

                case 4:
                    checkedCheckpoint4 = true;
                    break;

                case 5:
                    checkedCheckpoint5 = true;
                    break;

                case 6:
                    checkedCheckpoint6 = true;
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// Geeft bool waarde van checkpoint terug.
        /// </summary>
        /// <param name="checkpointNummer">Nummer van checkpoint waarvan je de waarde wilt hebben</param>
        /// <returns>bool van checkpoint</returns>
        public bool CheckCheckpoint(int checkpointNummer)
        {
            switch(checkpointNummer)
            {
                case 1:
                    return checkedCheckpoint1;
                case 2:
                    return checkedCheckpoint2;
                case 3:
                    return checkedCheckpoint3;
                case 4:
                    return checkedCheckpoint4;
                case 5:
                    return checkedCheckpoint5;
                case 6:
                    return checkedCheckpoint6;
            }
            return false;
        }

        /// <summary>
        /// Checkt of alle checkpoints zijn gechacked.
        /// </summary>
        /// <returns>True als alles gechecked is en reset alles,
        /// false Als er checkpoints false zijn</returns>
        public void ResetCheckpoint()
        {
                checkedCheckpoint1 = false;
                checkedCheckpoint2 = false;
                checkedCheckpoint3 = false;
                checkedCheckpoint4 = false;
                checkedCheckpoint5 = false;
                checkedCheckpoint6 = false;
        }

        public bool FinishCheck()
        {
            if(checkedCheckpoint1 == true && checkedCheckpoint2 == true && checkedCheckpoint3 == true && checkedCheckpoint4 == true && checkedCheckpoint5 == true && checkedCheckpoint6 == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
