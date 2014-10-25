using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace RaceGame
{
    class Track
    {
        public byte track_nr;
        public Bitmap collissionMap;
        public Bitmap track;
        public PointF carPos1;
        public PointF carPos2;
        public int checkp1_x1, checkp1_x2, checkp2_x1, checkp2_x2, checkp3_x1, checkp3_x2, checkp4_x1, checkp4_x2, checkp5_x1, checkp5_x2, checkp6_x1, checkp6_x2, finish_x1, finish_x2;
        public int checkp1_y1, checkp1_y2, checkp2_y1, checkp2_y2, checkp3_y1, checkp3_y2, checkp4_y1, checkp4_y2, checkp5_y1, checkp5_y2, checkp6_y1, checkp6_y2, finish_y1, finish_y2;

        public void SetTrack(byte trk)
        {
            track_nr = trk;
            switch (trk)
            {
                case 0:
                    track = new Bitmap();
                    collissionMap = new Bitmap(RaceGame.Properties.Resources.Afrika);
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
                    checkp5_x1 = 904;
                    checkp5_x2 = 1016;
                    checkp5_y1 = 338;
                    checkp5_y2 = 348;
                    //cp6
                    checkp6_x1 = 790;
                    checkp6_x2 = 795;
                    checkp6_y1 = 578;
                    checkp6_y2 = 674;
                    //finish
                    finish_x1 = 537;
                    finish_x2 = 547;
                    finish_y1 = 496;
                    finish_y2 = 768;
                    //carPos
                    carPos1 = new PointF(545f, 515f);
                    carPos2 = new PointF(545f, 535f);
                    break;

                case 1:
                    track = new Bitmap(RaceGame.Properties.Resources.Antarctica1);
                    collissionMap = new Bitmap(RaceGame.Properties.Resources.Antarctica);
                    //cp1
                    checkp1_x1 = 297;
                    checkp1_x2 = 302;
                    checkp1_y1 = 612;
                    checkp1_y2 = 688;
                    //cp2
                    checkp2_x1 = 353;
                    checkp2_x2 = 358;
                    checkp2_y1 = 464;
                    checkp2_y2 = 542;
                    //cp3
                    checkp3_x1 = 825;
                    checkp3_x2 = 900;
                    checkp3_y1 = 320;
                    checkp3_y2 = 325;
                    //cp4
                    checkp4_x1 = 395;
                    checkp4_x2 = 400;
                    checkp4_y1 = 0;
                    checkp4_y2 = 70;
                    //cp5
                    checkp5_x1 = 947;
                    checkp5_x2 = 1021;
                    checkp5_y1 = 320;
                    checkp5_y2 = 330;
                    //cp6
                    checkp6_x1 = 769;
                    checkp6_x2 = 774;
                    checkp6_y1 = 604;
                    checkp6_y2 = 692;
                    //finish
                    finish_x1 = 545;
                    finish_x2 = 550;
                    finish_y1 = 547;
                    finish_y2 = 755;
                    //carPos
                    carPos1 = new PointF(557f, 552f);
                    carPos2 = new PointF(557f, 572f);
                    break;
                case 2:
                    track = new Bitmap(RaceGame.Properties.Resources.Australie1);
                    collissionMap = new Bitmap(RaceGame.Properties.Resources.Australie);
                    //cp1
                    checkp1_x1 = 68;
                    checkp1_x2 = 144;
                    checkp1_y1 = 438;
                    checkp1_y2 = 443;
                    //cp2
                    checkp2_x1 = 378;
                    checkp2_x2 = 388;
                    checkp2_y1 = 4;
                    checkp2_y2 = 80;
                    //cp3
                    checkp3_x1 = 922;
                    checkp3_x2 = 1000;
                    checkp3_y1 = 156;
                    checkp3_y2 = 161;
                    //cp4
                    checkp4_x1 = 702;
                    checkp4_x2 = 772;
                    checkp4_y1 = 242;
                    checkp4_y2 = 247;
                    //cp5
                    checkp5_x1 = 702;
                    checkp5_x2 = 774;
                    checkp5_y1 = 305;
                    checkp5_y2 = 310;
                    //cp6
                    checkp6_x1 = 614;
                    checkp6_x2 = 620;
                    checkp6_y1 = 578;
                    checkp6_y2 = 674;
                    //finish
                    finish_x1 = 424;
                    finish_x2 = 428;
                    finish_y1 = 504;
                    finish_y2 = 758;
                    //carPos
                    carPos1 = new PointF(433f, 515f);
                    carPos2 = new PointF(433f, 535f);
                    break;
                case 3:
                    track = new Bitmap(RaceGame.Properties.Resources.Azie1);
                    collissionMap = new Bitmap(RaceGame.Properties.Resources.Azie);
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
                    checkp6_x1 = 790;
                    checkp6_x2 = 795;
                    checkp6_y1 = 578;
                    checkp6_y2 = 674;
                    //finish
                    finish_x1 = 537;
                    finish_x2 = 547;
                    finish_y1 = 496;
                    finish_y2 = 768;
                    //carPos
                    carPos1 = new PointF(545f, 515f);
                    carPos2 = new PointF(545f, 535f);
                    break;
                case 4:
                    track = new Bitmap(RaceGame.Properties.Resources.Europa1);
                    collissionMap = new Bitmap(RaceGame.Properties.Resources.Europa);
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
                    checkp6_x1 = 790;
                    checkp6_x2 = 795;
                    checkp6_y1 = 578;
                    checkp6_y2 = 674;
                    //finish
                    finish_x1 = 537;
                    finish_x2 = 547;
                    finish_y1 = 496;
                    finish_y2 = 768;
                    //carPos
                    carPos1 = new PointF(545f, 515f);
                    carPos2 = new PointF(545f, 535f);
                    break;
                case 5:
                    track = new Bitmap(RaceGame.Properties.Resources.Noord_Amerika1);
                    collissionMap = new Bitmap(RaceGame.Properties.Resources.Noord_Amerika);
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
                    checkp6_x1 = 790;
                    checkp6_x2 = 795;
                    checkp6_y1 = 578;
                    checkp6_y2 = 674;
                    //finish
                    finish_x1 = 537;
                    finish_x2 = 547;
                    finish_y1 = 496;
                    finish_y2 = 768;
                    //carPos
                    carPos1 = new PointF(545f, 515f);
                    carPos2 = new PointF(545f, 535f);
                    break;
                case 6:
                    track = new Bitmap(RaceGame.Properties.Resources.Zuid_Amerika1);
                    collissionMap = new Bitmap(RaceGame.Properties.Resources.Zuid_Amerika);
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
                    checkp6_x1 = 790;
                    checkp6_x2 = 795;
                    checkp6_y1 = 578;
                    checkp6_y2 = 674;
                    //finish
                    finish_x1 = 537;
                    finish_x2 = 547;
                    finish_y1 = 496;
                    finish_y2 = 768;
                    //carPos
                    carPos1 = new PointF(545f, 515f);
                    carPos2 = new PointF(545f, 535f);
                    break;
            }
        }

        public int GetCheckpointPosX(byte nr)
        {
            switch (nr)
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