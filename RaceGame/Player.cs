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
        public string naam;
        private bool checkedCheckpoint1 = false;
        private bool checkedCheckpoint2 = false;
        private bool checkedCheckpoint3 = false;
        private bool checkedCheckpoint4 = false;
        private bool checkedCheckpoint5 = false;
        public PointF carPos;
        public PointF carSpeed;
        public Bitmap Auto = new Bitmap(RaceGame.Properties.Resources.AutoVierkantRegenboog,30,30);

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

                default:
                    break;
            }
        }

        public bool CheckAndResetCheckpoint()
        {
            if (checkedCheckpoint1 == true && checkedCheckpoint2 == true && checkedCheckpoint3 == true && checkedCheckpoint4 == true && checkedCheckpoint5 == true)
            {
                checkedCheckpoint1 = false;
                checkedCheckpoint2 = false;
                checkedCheckpoint3 = false;
                checkedCheckpoint4 = false;
                checkedCheckpoint5 = false;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
