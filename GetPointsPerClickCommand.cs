using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTaskClickerGame
{
    internal class GetPointsPerClickCommand : ICommand
    {
        private readonly ClickerGame _clickerGame;

        public char Character => 'k';


        public GetPointsPerClickCommand(ClickerGame clickerGame)
        {
            _clickerGame = clickerGame;
        }

        public void Run()
        {
                _clickerGame.Upgrade();
        }
    }
}
