using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;

namespace SnakeCsRaylib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(600, 600, "Snake");
            Raylib.SetTargetFPS(60);

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);

                Raylib.DrawRectangle(25, 25, 50, 50, Color.BLUE);

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}
