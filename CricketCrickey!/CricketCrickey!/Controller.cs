using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketCrickey_
{
    class Controller
    {

        Model model = new Model();
        View view = new View();

        public Controller()
        {
            view.Welcome();
            view.PlayerInstructions();
        }

        public void Play()
        {
            
        }
    }
}
