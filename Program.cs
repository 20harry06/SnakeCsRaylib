using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeCsRaylib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game.Setup();

            Game.Loop();
        }
    }
}
