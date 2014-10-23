﻿using System;
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
        public int checkp1_x1, checkp1_x2, checkp2_x1, checkp2_x2, checkp3_x1, checkp3_x2, checkp4_x1, checkp4_x2, checkp5_x1, checkp5_x2, checkp6_x1, checkp6_x2;
        public int checkp1_y1, checkp1_y2, checkp2_y1, checkp2_y2, checkp3_y1, checkp3_y2, checkp4_y1, checkp4_y2, checkp5_y1, checkp5_y2, checkp6_y1, checkp6_y2;
        //

        public void SetTrack(byte trk)
        {
            track_nr = trk;
            switch(trk)
            {
                case 0:
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
                    break;
            }
        }
    }
}
