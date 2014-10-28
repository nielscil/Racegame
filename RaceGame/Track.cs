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
        public PointF carPos1;
        public PointF carPos2;

        public int pit_x1, pit_x2, pit_y1, pit_y2;
        public int checkp1_x1, checkp1_x2, checkp2_x1, checkp2_x2, checkp3_x1, checkp3_x2, checkp4_x1, checkp4_x2, checkp5_x1, checkp5_x2, checkp6_x1, checkp6_x2,finish_x1,finish_x2;
        public int checkp1_y1, checkp1_y2, checkp2_y1, checkp2_y2, checkp3_y1, checkp3_y2, checkp4_y1, checkp4_y2, checkp5_y1, checkp5_y2, checkp6_y1, checkp6_y2, finish_y1, finish_y2;
        public void SetTrack(byte trk)
        {
            track_nr = trk;
            switch (trk)
            {
                case 0:
                    track = new Bitmap(RaceGame.Properties.Resources.Afrika1);
                    collissionMap = new Bitmap(RaceGame.Properties.Resources.Afrika);
                    //cp1
                    checkp1_x1 = 270;
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
                    //Pitstop
                    pit_x1 = 430;
                    pit_x2 = 650;
                    pit_y1 = 680;
                    pit_y2 = 760;
                    //carPos
                    carPos1 = new PointF(545f, 515f);
                    carPos2 = new PointF(545f, 535f);
                    break;

                case 1:
                    track = new Bitmap(RaceGame.Properties.Resources.Antarctica1);
                    collissionMap = new Bitmap(RaceGame.Properties.Resources.Antarctica);
                    //cp1
                    checkp1_x1 = 100;
                    checkp1_x2 = 110;
                    checkp1_y1 = 610;
                    checkp1_y2 = 700;
                    //cp2
                    checkp2_x1 = 430;
                    checkp2_x2 = 440;
                    checkp2_y1 = 445;
                    checkp2_y2 = 525;
                    //cp3
                    checkp3_x1 = 685;
                    checkp3_x2 = 690;
                    checkp3_y1 = 125;
                    checkp3_y2 = 215;
                    //cp4
                    checkp4_x1 = 370;
                    checkp4_x2 = 380;
                    checkp4_y1 = 5;
                    checkp4_y2 = 80;
                    //cp5
                    checkp5_x1 = 840;
                    checkp5_x2 = 850;
                    checkp5_y1 = 10;
                    checkp5_y2 = 111;
                    //cp6
                    checkp6_x1 = 785;
                    checkp6_x2 = 800;
                    checkp6_y1 = 600;
                    checkp6_y2 = 700;
                    //finish
                    finish_x1 = 545;
                    finish_x2 = 550;
                    finish_y1 = 555;
                    finish_y2 = 755;
                    //Pitstop
                    pit_x1 = 510;
                    pit_x2 = 590;
                    pit_y1 = 700;
                    pit_y2 = 750;
                    //carPos
                    carPos1 = new PointF(555f, 557f);
                    carPos2 = new PointF(555f, 575f);
                    break;
                case 2:
                    track = new Bitmap(RaceGame.Properties.Resources.Australie1);
                    collissionMap = new Bitmap(RaceGame.Properties.Resources.Australie);
                    //cp1
                    checkp1_x1 = 220;
                    checkp1_x2 = 225;
                    checkp1_y1 = 585;
                    checkp1_y2 = 680;
                    //cp2
                    checkp2_x1 = 8;
                    checkp2_x2 = 111;
                    checkp2_y1 = 180;
                    checkp2_y2 = 190;
                    //cp3
                    checkp3_x1 = 375;
                    checkp3_x2 = 380;
                    checkp3_y1 = 0;
                    checkp3_y2 = 112;
                    //cp4
                    checkp4_x1 = 835;
                    checkp4_x2 = 840;
                    checkp4_y1 = 235;
                    checkp4_y2 = 330;
                    //cp5
                    checkp5_x1 = 700;
                    checkp5_x2 = 780;
                    checkp5_y1 = 240;
                    checkp5_y2 = 250;
                    //cp6
                    checkp6_x1 = 705;
                    checkp6_x2 = 765;
                    checkp6_y1 = 300;
                    checkp6_y2 = 315;
                    //finish
                    finish_x1 = 425;
                    finish_x2 = 435;
                    finish_y1 = 511;
                    finish_y2 = 747;
                    //Pitstop
                    pit_x1 = 390;
                    pit_x2 = 470;
                    pit_y1 = 610;
                    pit_y2 = 750;
                    //carPos
                    carPos1 = new PointF(435f, 510f);
                    carPos2 = new PointF(435f, 535f);
                    break;
                case 3:
                    track = new Bitmap(RaceGame.Properties.Resources.Azie1);
                    collissionMap = new Bitmap(RaceGame.Properties.Resources.Azie);
                    //cp1
                    checkp1_x1 = 280;
                    checkp1_x2 = 360;
                    checkp1_y1 = 110;
                    checkp1_y2 = 120;
                    //cp2
                    checkp2_x1 = 475;
                    checkp2_x2 = 580;
                    checkp2_y1 = 100;
                    checkp2_y2 = 110;
                    //cp3
                    checkp3_x1 = 560;
                    checkp3_x2 = 565;
                    checkp3_y1 = 285;
                    checkp3_y2 = 400;
                    //cp4
                    checkp4_x1 = 200;
                    checkp4_x2 = 300;
                    checkp4_y1 = 450;
                    checkp4_y2 = 460;
                    //cp5
                    checkp5_x1 = 670;
                    checkp5_x2 = 675;
                    checkp5_y1 = 670;
                    checkp5_y2 = 768;
                    //cp6
                    checkp6_x1 = 70;
                    checkp6_x2 = 144;
                    checkp6_y1 = 500;
                    checkp6_y2 = 510;
                    //finish
                    finish_x1 = 20;
                    finish_x2 = 205;
                    finish_y1 = 325;
                    finish_y2 = 333;
                    //Pitstop
                    pit_x1 = 20;
                    pit_x2 = 70;
                    pit_y1 = 290;
                    pit_y2 = 370;
                    //carPos
                    carPos1 = new PointF(190f, 340f);
                    carPos2 = new PointF(160f, 340f);
                    break;
                case 4:
                    track = new Bitmap(RaceGame.Properties.Resources.Europa1);
                    collissionMap = new Bitmap(RaceGame.Properties.Resources.Europa);
                    //cp1
                    checkp1_x1 = 310;
                    checkp1_x2 = 320;
                    checkp1_y1 = 585;
                    checkp1_y2 = 675;
                    //cp2
                    checkp2_x1 = 315;
                    checkp2_x2 = 320;
                    checkp2_y1 = 160;
                    checkp2_y2 = 225;
                    //cp3
                    checkp3_x1 = 335;
                    checkp3_x2 = 405;
                    checkp3_y1 = 220;
                    checkp3_y2 = 225;
                    //cp4
                    checkp4_x1 = 340;
                    checkp4_x2 = 405;
                    checkp4_y1 = 150;
                    checkp4_y2 = 165;
                    //cp5
                    checkp5_x1 = 760;
                    checkp5_x2 = 880;
                    checkp5_y1 = 130;
                    checkp5_y2 = 140;
                    //cp6
                    checkp6_x1 = 870;
                    checkp6_x2 = 875;
                    checkp6_y1 = 565;
                    checkp6_y2 = 665;
                    //finish
                    finish_x1 = 525;
                    finish_x2 = 540;
                    finish_y1 = 510;
                    finish_y2 = 750;
                    //Pitstop
                    pit_x1 = 490;
                    pit_x2 = 575;
                    pit_y1 = 690;
                    pit_y2 = 750;
                    //carPos
                    carPos1 = new PointF(540f, 510f);
                    carPos2 = new PointF(540f, 540f);
                    break;
                case 5:
                    track = new Bitmap(RaceGame.Properties.Resources.Noord_Amerika1);
                    collissionMap = new Bitmap(RaceGame.Properties.Resources.Noord_Amerika);
                    //cp1
                    checkp1_x1 = 0;
                    checkp1_x2 = 90;
                    checkp1_y1 = 495;
                    checkp1_y2 = 500;
                    //cp2
                    checkp2_x1 = 545;
                    checkp2_x2 = 550;
                    checkp2_y1 = 675;
                    checkp2_y2 = 770;
                    //cp3
                    checkp3_x1 = 930;
                    checkp3_x2 = 1000;
                    checkp3_y1 = 485;
                    checkp3_y2 = 500;
                    //cp4
                    checkp4_x1 = 750;
                    checkp4_x2 = 760;
                    checkp4_y1 = 10;
                    checkp4_y2 = 140;
                    //cp5
                    checkp5_x1 = 155;
                    checkp5_x2 = 270;
                    checkp5_y1 = 160;
                    checkp5_y2 = 170;
                    //cp6
                    checkp6_x1 = 635;
                    checkp6_x2 = 640;
                    checkp6_y1 = 225;
                    checkp6_y2 = 340;
                    //finish
                    finish_x1 = 575;
                    finish_x2 = 585;
                    finish_y1 = 340;
                    finish_y2 = 570;
                    //Pitstop
                    pit_x1 = 545;
                    pit_x2 = 620;
                    pit_y1 = 510;
                    pit_y2 = 575;
                    //carPos
                    carPos1 = new PointF(585f, 345f);
                    carPos2 = new PointF(585f, 370f);
                    break;
                case 6:
                    track = new Bitmap(RaceGame.Properties.Resources.Zuid_Amerika1);
                    collissionMap = new Bitmap(RaceGame.Properties.Resources.Zuid_Amerika);
                    //cp1
                    checkp1_x1 = 300;
                    checkp1_x2 = 360;
                    checkp1_y1 = 225;
                    checkp1_y2 = 230;
                    //cp2
                    checkp2_x1 = 300;
                    checkp2_x2 = 360;
                    checkp2_y1 = 170;
                    checkp2_y2 = 180;
                    //cp3
                    checkp3_x1 = 760;
                    checkp3_x2 = 765;
                    checkp3_y1 = 50;
                    checkp3_y2 = 145;
                    //cp4
                    checkp4_x1 = 925;
                    checkp4_x2 = 1024;
                    checkp4_y1 = 605;
                    checkp4_y2 = 615;
                    //cp5
                    checkp5_x1 = 280;
                    checkp5_x2 = 290;
                    checkp5_y1 = 600;
                    checkp5_y2 = 735;
                    //cp6
                    checkp6_x1 = 835;
                    checkp6_x2 = 845;
                    checkp6_y1 = 175;
                    checkp6_y2 = 300;
                    //finish
                    finish_x1 = 530;
                    finish_x2 = 550;
                    finish_y1 = 430;
                    finish_y2 = 655;
                    //Pitstop
                    pit_x1 = 500;
                    pit_x2 = 580;
                    pit_y1 = 600;
                    pit_y2 = 660;
                    //carPos
                    carPos1 = new PointF(550f, 430f);
                    carPos2 = new PointF(550f, 545f);
                    break;
            }
        }

    }
}
