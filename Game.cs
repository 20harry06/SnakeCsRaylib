using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;

namespace SnakeCsRaylib
{
    internal static class Game
    {
        public static void Setup()
        {
            Raylib.SetTargetFPS(60);
            Raylib.InitWindow(750, 750, "Snake");
        }

        public static void Loop()
        {
            Snake snake = new Snake();

            while(!Raylib.WindowShouldClose())
            {
                snake.Update(0, 0);
                Render(snake.SnakeX, snake.SnakeY, 10, 10);
            }
        }

        private static void Render(List<int> snakeX, List<int> snakeY, int fruitX, int fruitY)
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.GRAY);
            RenderSnake(snakeX, snakeY);
            Raylib.EndDrawing();
        }

        private static void RenderSnake(List<int> snakeX, List<int> snakeY)
        {
            Rectangle snakePiece;
            snakePiece.width = 25;
            snakePiece.height = 25;

            for (int i = 0; i < snakeX.Count; i++)
            {
                snakePiece.x = snakeX[i] * 25;
                snakePiece.y = snakeY[i] * 25;
                Raylib.DrawRectangleRounded(snakePiece, (float)0.9, 5, Color.GREEN);
            }
        }
    }
}
