﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace CricketCrickey_
{
    class View
    {

        public void OptionChosen(Model x)
        {
            if (x.OptionToBat())
            {
                Console.WriteLine("We are about to flip the coin to decide who is batting and who is bowling.");
                Console.WriteLine("To make your choice, either type: heads or tails . And hit enter!");
                Console.ReadLine();
                x.OptionToBat();
                Console.WriteLine("Congrats!!! You have Chosen To bat "); 
            }
        }

        public string Welcome()
        {
            Console.WriteLine("Welcome to Super Awesome Cricket by Awesone Five");
            Console.WriteLine("What is your Name?");
            string playerName = Console.ReadLine();
            Console.WriteLine("Lets play cricket " + playerName);
            return playerName;
        }


        public void PlayerInstructions()
        {

            Console.WriteLine("Please read the instructions below to understand how this game works, hit enter to flow through");
            Console.ReadLine();
            Console.WriteLine("You, the player have flipped and are now batting");
            Console.ReadLine();
            Console.WriteLine("You will enter a number between 1 and 4, this will correspond to the type of shot you produce");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Pressing 1 will produce a straight drive, hitting down the ground with power");
            Console.ReadLine();
            Console.WriteLine("Pressing 2 will produce a cover drive, a classy cricket shot, Hit it BRUDDAA!!!");
            Console.ReadLine();
            Console.WriteLine("Pressing 3 will produce a reverse sweep, a risky shot, but one that gets the crowd going");
            Console.ReadLine();
            Console.WriteLine("Pressing 4 will produce a slog, who do you you think you are, Brendon McCullum?");

        }

       
        public void PlayerScore(int score, int outs)
        {
            Console.WriteLine("Score/Number of Outs");
            Console.WriteLine(" {0} /{1}", score,outs);
        }

        public string ShotChoice()
        {
            Console.WriteLine("Choose 1,2,3 or 4");
            return Console.ReadLine();
   
        }

        public void SayOut()
        {

            Console.WriteLine("HowZatttt!!!!!!!!");
            Console.Clear();
            Console.WriteLine("Thats OUT!!!!!!!!!!");
        }

        public void GameOver()
        {
            Console.WriteLine("That's the last wicket to fall");
            Console.ReadLine();
            Console.WriteLine("How is the taste of defeat........?");
            Console.ReadLine();
            Console.WriteLine("Everyone is leaving the ground, time to close.......");
            
        }

    }
}
