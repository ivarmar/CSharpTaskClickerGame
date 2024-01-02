using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTaskClickerGame
{
    internal class CommandSet

    {

        private readonly ICommand[] _commands;


        public CommandSet(ClickerGame clickerGame)
        {
            _commands = new ICommand[]
            {
                new GetPointsCommand(clickerGame),
                new GetPointsPerClickCommand(clickerGame),
                new GetPointsPerClickIncreaseCommand(clickerGame)
            };
        }

        public void RunCommand(char key)
        {
            foreach (var command in _commands)
            {
                if (key == command.Character)
                {
                    command.Run();
                }
            }
        }
    }
}
