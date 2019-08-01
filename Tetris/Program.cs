using System;
using Tetris.Controler;
using Tetris.View;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Service s = new Service();
            s.Start();
        }
    }
}