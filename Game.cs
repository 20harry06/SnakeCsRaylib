using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;

namespace SnakeCsRaylib
{
    internal class Game
    {

        public Game()
        {
            Raylib.SetTargetFPS(60);
            Raylib.InitWindow(750, 750, "Snake");
        }

        public void Loop()
        {
            while(!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();

                Raylib.ClearBackground(Color.GRAY);

                Raylib.EndDrawing();
            }
        }
    }
}
