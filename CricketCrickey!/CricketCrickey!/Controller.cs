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
            view.OptionChosen(model);
            view.PlayerInstructions();
            view.ReadyToPlay();
        }

        public void Play()
        {
            while (true)
            {
                model.ShotAssign(view.ShotChoice());
                Console.WriteLine(model.BallsLeft);
                Console.ReadKey();
                
                Console.Clear();
                view.PlayerScore(model.TotalScore, model.Outs);
            }
        }
    }
}
