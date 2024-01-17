using System;
using Stride.Engine;

namespace Stride.DepInjection.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
