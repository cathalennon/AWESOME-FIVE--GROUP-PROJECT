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


        public bool OptionToBat()
        {
            int coin = 1;

            if (coin == 1)
            {
                return true;
            }

            return false;

        }
=======
        int TotalScore = 0;

        private Random rnd = new Random();



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

>>>>>>> origin
    }
}
