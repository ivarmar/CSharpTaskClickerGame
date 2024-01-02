using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTaskClickerGame
{
    internal class GetPointsCommand : ICommand
    {
        private readonly ClickerGame _clickerGame;
        public char Character => ' ';


        public GetPointsCommand(ClickerGame clickerGame)
        {
            _clickerGame = clickerGame;
        }

        public void Run()
        {
                _clickerGame.GetPointsPerClick();
        }
    }
}
