﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bet_and_Get
{
    class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random MyRandom;


        public bool Run()
        {
            MyRandom = new Random();
            int distance = MyRandom.Next(1, 5);

            MoveMyPictureBox(distance);


            Location += distance;
            if (Location >= (RacetrackLength - StartingPosition))
            {
                return true;
            }
            return false;
        }

        public void TakeStartingPosition()
        {
            MoveMyPictureBox(-Location);
            Location = 0;
        }

        public void MoveMyPictureBox(int distance)
        {
            Point p = MyPictureBox.Location;
            p.X += distance;
            MyPictureBox.Location = p;
        }
    }
}
