using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace RaceGame
{
    public class Track
    {
        public byte track_nr;
        public Bitmap collissionMap;
        public Bitmap track;
        public int checkp1_x1, checkp1_x2, checkp2_x1, checkp2_x2, checkp3_x1, checkp3_x2, checkp4_x1, checkp4_x2, checkp5_x1, checkp5_x2, checkp6_x1, checkp6_x2,finish_x1,finish_x2;
        public int checkp1_y1, checkp1_y2, checkp2_y1, checkp2_y2, checkp3_y1, checkp3_y2, checkp4_y1, checkp4_y2, checkp5_y1, checkp5_y2, checkp6_y1, checkp6_y2, finish_y1, finish_y2;
       
        public void SetTrack(byte trk)
        {
            track_nr = trk;
            switch(trk)
            {
                case 0:
                    track = new Bitmap(RaceGame.Properties.Resources.racetrack);
                    collissionMap = new Bitmap(1, 22);
                    //cp1
                    checkp1_x1 = 260;
                    checkp1_x2 = 280;
                    checkp1_y1 = 579;
                    checkp1_y2 = 671;
                    //cp2
                    checkp2_x1 = 365;
                    checkp2_x2 = 360;
                    checkp2_y1 = 0;
                    checkp2_y2 = 80;
                    //cp3
                    checkp3_x1 = 424;
                    checkp3_x2 = 522;
                    checkp3_y1 = 324;
                    checkp3_y2 = 334;
                    //cp4
                    checkp4_x1 = 850;
                    checkp4_x2 = 855;
                    checkp4_y1 = 0;
                    checkp4_y2 = 80;
                    //cp5
                    checkp5_x1 = 934;
                    checkp5_x2 = 1016;
                    checkp5_y1 = 338;
                    checkp5_y2 = 348;
                    //cp6
                    checkp6_x1 = 793;
                    checkp6_x2 = 798;
                    checkp6_y1 = 578;
                    checkp6_y2 = 674;
                    //finish
                    finish_x1 = 537;
                    finish_x2 = 547;
                    finish_y1 = 496;
                    finish_y2 = 768;
                    break;
                case 1:
                    track = new Bitmap(1,22);
                    collissionMap = new Bitmap(1, 22);
                    checkp1_x1 = 275;
                    checkp1_x2 = 280;
                    checkp2_x1 = 165;
                    checkp2_x2 = 170;
                    checkp3_x1 = 434;
                    checkp3_x2 = 439;
                    checkp4_x1 = 578;
                    checkp4_x2 = 583;
                    checkp5_x1 = 852;
                    checkp5_x2 = 857;
                    checkp6_x1 = 793;
                    checkp6_x2 = 798;
                    checkp1_y1 = 275;
                    checkp1_y2 = 280;
                    checkp2_y1 = 165;
                    checkp2_y2 = 170;
                    checkp3_y1 = 434;
                    checkp3_y2 = 439;
                    checkp4_y1 = 578;
                    checkp4_y2 = 583;
                    checkp5_y1 = 852;
                    checkp5_y2 = 857;
                    checkp6_y1 = 793;
                    checkp6_y2 = 798;
                    finish_x1 = 537;
                    finish_x2 = 547;
                    finish_y1 = 501;
                    finish_y2 = 768;
                    break;
                case 2:
                    track = new Bitmap(1,22);
                    collissionMap = new Bitmap(1, 22);
                    checkp1_x1 = 275;
                    checkp1_x2 = 280;
                    checkp2_x1 = 165;
                    checkp2_x2 = 170;
                    checkp3_x1 = 434;
                    checkp3_x2 = 439;
                    checkp4_x1 = 578;
                    checkp4_x2 = 583;
                    checkp5_x1 = 852;
                    checkp5_x2 = 857;
                    checkp6_x1 = 793;
                    checkp6_x2 = 798;
                    checkp1_y1 = 275;
                    checkp1_y2 = 280;
                    checkp2_y1 = 165;
                    checkp2_y2 = 170;
                    checkp3_y1 = 434;
                    checkp3_y2 = 439;
                    checkp4_y1 = 578;
                    checkp4_y2 = 583;
                    checkp5_y1 = 852;
                    checkp5_y2 = 857;
                    checkp6_y1 = 793;
                    checkp6_y2 = 798;
                    finish_x1 = 537;
                    finish_x2 = 547;
                    finish_y1 = 501;
                    finish_y2 = 768;
                    break;
                case 3:
                    track = new Bitmap(1,22);
                    collissionMap = new Bitmap(1, 22);
                    checkp1_x1 = 275;
                    checkp1_x2 = 280;
                    checkp2_x1 = 165;
                    checkp2_x2 = 170;
                    checkp3_x1 = 434;
                    checkp3_x2 = 439;
                    checkp4_x1 = 578;
                    checkp4_x2 = 583;
                    checkp5_x1 = 852;
                    checkp5_x2 = 857;
                    checkp6_x1 = 793;
                    checkp6_x2 = 798;
                    checkp1_y1 = 275;
                    checkp1_y2 = 280;
                    checkp2_y1 = 165;
                    checkp2_y2 = 170;
                    checkp3_y1 = 434;
                    checkp3_y2 = 439;
                    checkp4_y1 = 578;
                    checkp4_y2 = 583;
                    checkp5_y1 = 852;
                    checkp5_y2 = 857;
                    checkp6_y1 = 793;
                    checkp6_y2 = 798;
                    finish_x1 = 537;
                    finish_x2 = 547;
                    finish_y1 = 501;
                    finish_y2 = 768;
                    break;
                case 4:
                    track = new Bitmap(1,22);
                    collissionMap = new Bitmap(1, 22);
                    checkp1_x1 = 275;
                    checkp1_x2 = 280;
                    checkp2_x1 = 165;
                    checkp2_x2 = 170;
                    checkp3_x1 = 434;
                    checkp3_x2 = 439;
                    checkp4_x1 = 578;
                    checkp4_x2 = 583;
                    checkp5_x1 = 852;
                    checkp5_x2 = 857;
                    checkp6_x1 = 793;
                    checkp6_x2 = 798;
                    checkp1_y1 = 275;
                    checkp1_y2 = 280;
                    checkp2_y1 = 165;
                    checkp2_y2 = 170;
                    checkp3_y1 = 434;
                    checkp3_y2 = 439;
                    checkp4_y1 = 578;
                    checkp4_y2 = 583;
                    checkp5_y1 = 852;
                    checkp5_y2 = 857;
                    checkp6_y1 = 793;
                    checkp6_y2 = 798;
                    finish_x1 = 537;
                    finish_x2 = 547;
                    finish_y1 = 501;
                    finish_y2 = 768;
                    break;
                case 5:
                    track = new Bitmap(1,22);
                    collissionMap = new Bitmap(1, 22);
                    checkp1_x1 = 275;
                    checkp1_x2 = 280;
                    checkp2_x1 = 165;
                    checkp2_x2 = 170;
                    checkp3_x1 = 434;
                    checkp3_x2 = 439;
                    checkp4_x1 = 578;
                    checkp4_x2 = 583;
                    checkp5_x1 = 852;
                    checkp5_x2 = 857;
                    checkp6_x1 = 793;
                    checkp6_x2 = 798;
                    checkp1_y1 = 275;
                    checkp1_y2 = 280;
                    checkp2_y1 = 165;
                    checkp2_y2 = 170;
                    checkp3_y1 = 434;
                    checkp3_y2 = 439;
                    checkp4_y1 = 578;
                    checkp4_y2 = 583;
                    checkp5_y1 = 852;
                    checkp5_y2 = 857;
                    checkp6_y1 = 793;
                    checkp6_y2 = 798;
                    finish_x1 = 537;
                    finish_x2 = 547;
                    finish_y1 = 501;
                    finish_y2 = 768;
                    break;
                case 6:
                    track = new Bitmap(1,22);
                    collissionMap = new Bitmap(1, 22);
                    checkp1_x1 = 275;
                    checkp1_x2 = 280;
                    checkp2_x1 = 165;
                    checkp2_x2 = 170;
                    checkp3_x1 = 434;
                    checkp3_x2 = 439;
                    checkp4_x1 = 578;
                    checkp4_x2 = 583;
                    checkp5_x1 = 852;
                    checkp5_x2 = 857;
                    checkp6_x1 = 793;
                    checkp6_x2 = 798;
                    checkp1_y1 = 275;
                    checkp1_y2 = 280;
                    checkp2_y1 = 165;
                    checkp2_y2 = 170;
                    checkp3_y1 = 434;
                    checkp3_y2 = 439;
                    checkp4_y1 = 578;
                    checkp4_y2 = 583;
                    checkp5_y1 = 852;
                    checkp5_y2 = 857;
                    checkp6_y1 = 793;
                    checkp6_y2 = 798;
                    finish_x1 = 537;
                    finish_x2 = 547;
                    finish_y1 = 501;
                    finish_y2 = 768;
                    break;
            }
        }

        public int GetCheckpointPosX(byte nr)
        { 
            switch(nr)
            {
                case 1:
                return checkp1_x1;
                case 2:
                return checkp1_x2;
                case 3:
                return checkp2_x1;
                case 4:
                return checkp2_x2;
                case 5:
                return checkp3_x1;
                case 6:
                return checkp3_x2;
                case 7:
                return checkp4_x1;
                case 8:
                return checkp4_x2;
                case 9:
                return checkp5_x1;
                case 10:
                return checkp5_x2;
                case 11:
                return checkp6_x1;
                case 12:
                return checkp6_x2;
            }
            return -1;
        }

        public int GetCheckpointPosY(byte nr)
        {
            switch (nr)
            {
                case 1:
                    return checkp1_y1;
                case 2:
                    return checkp1_y2;
                case 3:
                    return checkp2_y1;
                case 4:
                    return checkp2_y2;
                case 5:
                    return checkp3_y1;
                case 6:
                    return checkp3_y2;
                case 7:
                    return checkp4_y1;
                case 8:
                    return checkp4_y2;
                case 9:
                    return checkp5_y1;
                case 10:
                    return checkp5_y2;
                case 11:
                    return checkp6_y1;
                case 12:
                    return checkp6_y2;
            }
            return -1;
        }
        
    }
}
