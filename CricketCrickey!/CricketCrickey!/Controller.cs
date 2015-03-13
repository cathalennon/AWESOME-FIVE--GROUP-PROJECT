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
            while (!model.EndGame())
            {
                if (model.IsOut())
                {
                    view.SayOut();
                }
                model.ShotAssign(view.ShotChoice());
                Console.WriteLine("You have " + model.BallsLeft + " balls left on your face");
                Console.ReadKey();
                Console.Clear();
                view.PlayerScore(model.TotalScore, model.Outs);
            }

            if (model.EndGame())
            {
                view.GameOver();
            }

        }
    }
}
