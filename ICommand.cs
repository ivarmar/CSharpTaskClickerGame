﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTaskClickerGame
{
    interface ICommand
    {

        void Run();
        char Character { get; }
    }
}
