using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bet_and_Get
{
    public partial class Form1 : Form
    {
        Greyhound[] cars = new Greyhound[4];
        Guy[] guys = new Guy[3];

        public Form1()
        {
            InitializeComponent();
            setupTrack();
        }

        private void setupTrack()
        {

            int startingPosition = pictureBox2.Right - pictureBox1.Left;
            int raceTrackLength = pictureBox1.Size.Width;


            cars[0] = new Greyhound()
            {
                MyPictureBox = pictureBox2,
                RacetrackLength = raceTrackLength,
                StartingPosition = startingPosition
            };
            cars[1] = new Greyhound()
            {
                MyPictureBox = pictureBox3,
                RacetrackLength = raceTrackLength,
                StartingPosition = startingPosition
            };
            cars[2] = new Greyhound()
            {
                MyPictureBox = pictureBox4,
                RacetrackLength = raceTrackLength,
                StartingPosition = startingPosition
            };
            cars[3] = new Greyhound()
            {
                MyPictureBox = pictureBox5,
                RacetrackLength = raceTrackLength,
                StartingPosition = startingPosition
            };

            guys[0] = new Guy("Jim", null, 50, radioButton1, label4);
            guys[1] = new Guy("Kim", null, 75, radioButton2, label5);
            guys[2] = new Guy("Tim", null, 45, radioButton3, label6);

            foreach (Guy guy in guys)
            {
                guy.UpdateLabels();
            }
        }

        private void Setlevel3TextLabel(string Name)
        {
            label3.Text = Name;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Setlevel3TextLabel("Jim");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Setlevel3TextLabel("Kim");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Setlevel3TextLabel("Tim");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int GuyNumber = 0;
            if (radioButton1.Checked)
            {
                GuyNumber = 0;
            }

            if (radioButton2.Checked)
            {
                GuyNumber = 1;
            }
            if (radioButton3.Checked)
            {
                GuyNumber = 2;
            }

            guys[GuyNumber].PlaceBet((int)numericUpDown1.Value, (int)comboBox1.SelectedIndex);
            guys[GuyNumber].UpdateLabels();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool NoWinner = true;
            int winningCar;
            button1.Enabled = false;

            while (NoWinner)
            {
                Application.DoEvents();
                for (int i = 0; i < cars.Length; i++)
                {
                    if (cars[i].Run())
                    {
                        winningCar = i ;
                        NoWinner = false;
                        MessageBox.Show("We have a winner - car F" + winningCar);
                        foreach (Guy guy in guys)
                        {
                            if (guy.MyBet != null)
                            {
                                guy.Collect(winningCar);
                                guy.MyBet = null;
                                guy.UpdateLabels();
                            }
                        }
                        foreach (Greyhound car in cars)
                        {
                            car.TakeStartingPosition();
                        }
                        break;
                    }

                }
            }

            button1.Enabled = true;
        }
    }
}

