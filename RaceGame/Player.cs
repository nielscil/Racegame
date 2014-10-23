using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace RaceGame
{
    class Player
    {
        Form1 form1 = new Form1();
        private Track track = new Track();
        public string naam;
        private bool checkedCheckpoint1 = false;
        private bool checkedCheckpoint2 = false;
        private bool checkedCheckpoint3 = false;
        private bool checkedCheckpoint4 = false;
        private bool checkedCheckpoint5 = false;
        private bool checkedCheckpoint6 = false;
        public bool noFuel = false;
        public PointF carPos;
        public PointF carSpeed;
        public string bestlab;
        private Bitmap auto;
        byte i = 0;

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
            if ((carPos.X >= 537 & carPos.X <= 547) & (carPos.Y >= 501 & carPos.Y <= 768) & CheckAndResetCheckpoint() == true)
            {
                switch (i)
                {
                    case 0:
                        form1.label6.Text = "Ronde: 2";
                        bestlab = Player1.ToString();
                        label8.Text = "Best lab: " + player1.bestlab;
                        Player1 = TimeSpan.Zero;
                        j++;
                        break;

                    case 1:
                        label6.Text = "Ronde: 3";
                        if (TimeSpan.Parse(bestLab) < Player1)
                        {
                            bestLab = Player1.ToString(); //Hoe komt dit voor Player2?
                        }
                        Player1 = TimeSpan.Zero;
                        j++;
                        break;

                    case 2:
                        label6.Text = "Ronde: 4";
                        if (TimeSpan.Parse(bestLab) < Player1)
                        {
                            bestLab = Player1.ToString();
                        }
                        Player1 = TimeSpan.Zero;
                        j++;
                        break;

                    case 3:
                        label6.Text = "Ronde: 5";
                        if (TimeSpan.Parse(bestLab) < Player1)
                        {
                            bestLab = Player1.ToString();
                        }
                        Player1 = TimeSpan.Zero;
                        j++;
                        break;

                    case 4:
                        label6.Text = "Finish";
                        if (TimeSpan.Parse(bestLab) < Player1)
                        {
                            bestLab = Player1.ToString();
                        }
                        Player1 = TimeSpan.Zero;
                        j++;
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
        public bool CheckAndResetCheckpoint()
        {
            if (checkedCheckpoint1 == true && checkedCheckpoint2 == true && checkedCheckpoint3 == true && checkedCheckpoint4 == true && checkedCheckpoint5 == true && checkedCheckpoint6 == true)
            {
                checkedCheckpoint1 = false;
                checkedCheckpoint2 = false;
                checkedCheckpoint3 = false;
                checkedCheckpoint4 = false;
                checkedCheckpoint5 = false;
                checkedCheckpoint6 = false;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
