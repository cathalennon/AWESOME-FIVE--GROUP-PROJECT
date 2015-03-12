using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketCrickey_
{
    class View
    {
        public string Welcome()
        {
            Console.WriteLine("Welcome to Super Awesome Cricket by Awesone Five");
            Console.WriteLine("What is your Name?");
            string playerName = Console.ReadLine();
            Console.WriteLine("Lets play cricket " + playerName);
            return playerName;
        }
    }
}
