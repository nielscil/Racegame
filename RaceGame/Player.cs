using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace RaceGame
{
    class Player
    {
        //private Form1 form1 = new Form1();
        private Track track = new Track();
        List<TimeSpan> bestlap1 = new List<TimeSpan>();
        private bool l, r, f, b = false;
        private float speed, angle = 0f;
        public byte fuel = 100;
		
        public double distance = 0;
        private bool checkedCheckpoint1, checkedCheckpoint2, checkedCheckpoint3 = false;
        private bool checkedCheckpoint4, checkedCheckpoint5, checkedCheckpoint6 = false;
        public bool noFuel = false;
		
        public PointF carPos, carSpeed;
		
        public string ronde = "Ronde 1";
        public string breaktime = "00:00:00";
        private Bitmap auto;
        public string laptime = "00:00:00";
        public TimeSpan time = new TimeSpan();
        public TimeSpan besttime = new TimeSpan();
        byte track_nr, i = 0;

        public void SetAuto(byte nr,byte player)
        {
            switch (nr)
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
            track.SetTrack(track_nr);
            SetCarPos(player);
        }
		
        public void SetCarPos(byte invoer)
        {
            switch (invoer)
            {
                case 0:
                    carPos = track.carPos1;
                    break;
                case 1:
                    carPos = track.carPos2;
                    break;
            }
        }

        public void SetTrack(byte track_nr)
        {
            this.track_nr = track_nr;
        }

        public Bitmap GetTrack()
        {
            return track.track;
        }

        public Bitmap GetAuto()
        {
            return auto;
        }

        public string checkPointtime()
        {
          
            breaktime = time.ToString();
                           
            
            return breaktime;
        }

        public void Finish()
        {
            if ((carPos.X >= track.finish_x1 && carPos.X <= track.finish_x2) && (carPos.Y >= track.finish_y1 && carPos.Y <= track.finish_y2) && checkedCheckpoint6 == true)
            {
                switch (i)
                {
                    case 0:
                        ronde = "Ronde: 2";
                        bestlap1.Add(time);
                        laptime = time.ToString();
                        besttime = time;
                        time = TimeSpan.Zero;
                        i++;
                        checkedCheckpoint6 = false;
                        break;

                    case 1:
                        ronde = "Ronde: 3";
                        
                        int result = TimeSpan.Compare(time, besttime);
                        if (result == -1)
                        {
                            laptime = time.ToString();
                        }
                        time = TimeSpan.Zero;
                        i++;
                        checkedCheckpoint6 = false;
                        break;

                    case 2:
                        ronde = "Ronde: 4";
                        result = TimeSpan.Compare(time, besttime);
                        if (result == -1)
                        {
                            laptime = time.ToString();
                        }
                        time = TimeSpan.Zero;
                        i++;
                        checkedCheckpoint6 = false;
                        break;
                    case 3:
                        ronde = "Ronde: 5";
                        result = TimeSpan.Compare(time, besttime);
                        if (result == -1)
                        {
                            laptime = time.ToString();
                        }
                        time = TimeSpan.Zero;
                        i++;
                        checkedCheckpoint6 = false;
                        break;

                    case 4:
                        ronde = "Finish";
                        result = TimeSpan.Compare(time, besttime);
                        if (result == -1)
                        {
                            laptime = time.ToString();
                        }
                        time = TimeSpan.Zero;
                        i++;
                        checkedCheckpoint6 = false;
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
            else if (b == true && noFuel == false && speed < 0.5)
            {
                speed += 0.05f;
            }
            if (f == false && noFuel == false && speed < -0.001f)
            {
                speed += 0.05f;
            }
            else if (b == false && noFuel == false && speed > 0.001f)
            {
                speed -= 0.05f;
            }
            else if (f == false && speed == -0.05)
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
            Checkpoints();
            Finish();
        }

        #region fuel
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

        public Color GetFuelColor()
        {
            if (fuel >= 50)
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
        #endregion
		
        #region Sturen
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
        public void Key_down(object sender, System.Windows.Forms.KeyEventArgs e, byte player)
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

        public void Key_up(object sender, System.Windows.Forms.KeyEventArgs e, byte player)
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
        #endregion
		
        #region checkpoint methodes
        public void Checkpoints()
        {
            //checkpoint 1. op track 1, deze punten moeten dus in class voor track1 komen te staan ofzo.
            if ((carPos.X + 25 >= track.GetCheckpointPosX(1) && carPos.X + 25 <= track.GetCheckpointPosX(2) && (carPos.Y >= track.GetCheckpointPosY(1) && carPos.Y <= track.GetCheckpointPosY(2))))
            {
                SetCheckpoint(1);
                checkPointtime();
            }
            //checkpoint 2???
            if ((carPos.X + 25 >= track.checkp2_x1 && carPos.X <= track.checkp2_x2) && (carPos.Y >= track.checkp2_y1 && carPos.Y <= track.checkp2_y2) && CheckCheckpoint(1) == true)
            {
                SetCheckpoint(2);
                checkPointtime();
            }
            //checkpoint 3???
            if ((carPos.X >= track.checkp3_x1 && carPos.X <= track.checkp3_x2) && (carPos.Y >= track.checkp3_y1 && carPos.Y <= track.checkp3_y2) && CheckCheckpoint(2) == true)
            {
                SetCheckpoint(3);
                checkPointtime();
            }
            //checkpoint 4???
            if ((carPos.X >= track.checkp4_x1 && carPos.X <= track.checkp4_x2) && (carPos.Y >= track.checkp4_y1 && carPos.Y <= track.checkp4_y2) && CheckCheckpoint(3) == true)
            {
                SetCheckpoint(4);
                checkPointtime();
            }
            //checkpoint 5???
            if ((carPos.X >= track.checkp5_x1 && carPos.X <= track.checkp5_x2) && (carPos.Y >= track.checkp5_y1 && carPos.Y <= track.checkp5_y2) && CheckCheckpoint(4) == true)
            {
                SetCheckpoint(5);
                checkPointtime();
            }
            //checkpoint 6???
            if ((carPos.X >= track.checkp6_x1 && carPos.X <= track.checkp6_x2) && (carPos.Y >= track.checkp6_y1 && carPos.Y <= track.checkp6_y2) && CheckCheckpoint(5) == true)
            {
                SetCheckpoint(6);
                checkPointtime();
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
            }
        }

        /// <summary>
        /// Geeft bool waarde van checkpoint terug.
        /// </summary>
        /// <param name="checkpointNummer">Nummer van checkpoint waarvan je de waarde wilt hebben</param>
        /// <returns>bool van checkpoint</returns>
        public bool CheckCheckpoint(int checkpointNummer)
        {
            switch (checkpointNummer)
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
        public bool finishCheck()
        {
            if (checkedCheckpoint1 == true && checkedCheckpoint2 == true && checkedCheckpoint3 == true && checkedCheckpoint4 == true && checkedCheckpoint5 == true && checkedCheckpoint6 == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
