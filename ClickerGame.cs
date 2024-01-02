using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;


namespace CSharpTaskClickerGame
{
    internal class ClickerGame

    {

    public int Points { get; private set; } = 0;

    int _pointsPerClick = 1;

    int _pointsPerClickIncrease = 10;


    public void GetPointsPerClick()
    {
        Points += _pointsPerClick;
    }

    public void Upgrade()
    {
        if (Points >= 10)
        {
            Points -= 10;
            _pointsPerClick++;
            Console.WriteLine($"You get {_pointsPerClick} Points each click");
        }
        else
        {
            Console.WriteLine("You don't have enough points");
            Thread.Sleep(2000);
            }


    }
    public void SuperUpgrade()
    {
        if (Points >= 100)
        {
            Points -= 100;
            _pointsPerClickIncrease++;
            Console.WriteLine($"Current point increase: {_pointsPerClickIncrease}");
            Thread.Sleep(2000);
        }
        else
        {
            Console.WriteLine("You don't have enough points");
            Thread.Sleep(2000);

            }
        }
    }
}
