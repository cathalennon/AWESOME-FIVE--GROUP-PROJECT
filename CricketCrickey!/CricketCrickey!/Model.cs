using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CricketCrickey_
{
    public class Model
    {

        private Random rnd = new Random();
        
        public int Score { get; set; }
        public int TotalScore { get; set; }

        public int BallsLeft { get; set; }
        public int Outs { get; set; }
        public int Temp { get; set; }



        public Model()
        {
            TotalScore = 0;
            BallsLeft = 30;
            Outs = 0;
        }

        public bool OptionToBat()
        {
            return true;
        }


        public bool IsOut()
        {

            Temp = rnd.Next(0, 11);

            if (Temp == 1)
            {
                Outs ++;
                return true;
            }

            return false;
        }


        public bool EndGame()
        {

            if (Outs == 3 || BallsLeft == 0)
            {
                return true;
            }
            return false;
            
        }



        public void ShotAssign(string input)
        {
            switch (input)
            {
                case "1":
                    TotalScore += StraightDrive();
                    BallsLeft -= 1;
                    Console.WriteLine("You hit a " + StraightDrive() + "!");
                    break;
                case "2":
                    TotalScore += CoverDrive();
                    BallsLeft -= 1;
                    Console.WriteLine("You hit a " + CoverDrive() + "!");
                    break;
                case "3":
                    TotalScore += ReverseSweep();
                    BallsLeft -= 1;
                    Console.WriteLine("You hit a " + ReverseSweep() + "!");
                    break;
                case "4":
                    TotalScore += Slog();
                    BallsLeft -= 1;
                    Console.WriteLine("You hit a " + Slog() + "!");
                    break;
                default:
                    Console.WriteLine("Sorry you can only chose 1 , 2 , 3 or 4!");
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
