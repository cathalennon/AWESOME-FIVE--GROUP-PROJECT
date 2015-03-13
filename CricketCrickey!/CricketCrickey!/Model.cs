using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketCrickey_
{
    internal class Model
    {
<<<<<<< HEAD
=======

        public int Score { get; set; }

>>>>>>> origin

        private Random rnd = new Random();
        public int TotalScore { get; set; }

        public Model()
        {
            TotalScore = 0;
        }

        public bool OptionToBat()
        {

                return true;

        }
<<<<<<< HEAD
=======

        int TotalScore = 0;

        private Random rnd = new Random();

>>>>>>> origin

        public void ShotAssign(string input)
        {
            switch (input)
            {
                case "1":
                    TotalScore += StraightDrive();
                    break;
                case "2":
                    TotalScore += CoverDrive();
                    break;
                case "3":
                    TotalScore += ReverseSweep();
                    break;
                case "4":
                    TotalScore += Slog();
                    break;
            }
        }

        public int StraightDrive()
        {
            int X = rnd.Next(0, 11);

            if (X == 1)
            {
                return 6;
            }

            if (X > 1 && X < 4)
            {
                return 4;
            }

            return 1;
        }

        public int CoverDrive()
        {
            int X = rnd.Next(0, 11);

            if (X == 1)
            {
                return 6;
            }

            if (X > 1 && X < 5)
            {
                return 4;
            }

            return 1;

        }

        public int ReverseSweep()
        {
            int X = rnd.Next(0, 11);

            if (X == 1)
            {
                return 6;
            }

            if (X > 1 && X < 5)
            {
                return 4;
            }

            return 1;

        }

        public int Slog()
        {
            int X = rnd.Next(0, 11);

            if (X <= 4)
            {
                return 6;
            }

            if (X == 5)
            {
                return 4;
            }

            return 1;

        }


    }
}
