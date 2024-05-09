using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;

namespace SnakeCsRaylib
{
    internal class Snake
    {
        List<int> snakeX, snakeY, snakeXBuffer, snakeYBuffer;
        int direction;

        public Snake()
        {
            direction = 0;
            snakeX = new List<int>();
            snakeY = new List<int>();
            snakeX.Add(15);
            snakeY.Add(15);
        }

        public List<int> SnakeX { get {  return snakeX; } }
        public List<int> SnakeY { get {  return snakeY; } }

        public void Update()
        {
            UpdateDirection();
            Move();
        }

        private void UpdateDirection()
        {
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_W))
            {
                direction = 0;
            }
            else if (Raylib.IsKeyPressed(KeyboardKey.KEY_D))
            {
                direction = 1;
            }
            else if (Raylib.IsKeyPressed(KeyboardKey.KEY_S))
            {
                direction = 2;
            }
            else if (Raylib.IsKeyPressed(KeyboardKey.KEY_A))
            {
                direction = 3;
            }
        }

        private void Move()
        {
            switch (direction)
            {
                case 0:
                    snakeY[0]--;
                    break;
                case 1:
                    snakeX[0]++;
                    break;
                case 2:
                    snakeY[0]++;
                    break;
                case 3:
                    snakeX[0]--;
                    break;
            }
        }
    }
}
