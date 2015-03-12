using System;
using System.Collections.Generic;
using System.Linq;
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
                Console.WriteLine("Cograts!!! You have Chosen To bat "); 
            }
        }
    }
}
