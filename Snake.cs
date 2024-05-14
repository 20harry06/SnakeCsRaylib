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
        private List<int> snakeX, snakeY, snakeXBuffer, snakeYBuffer;
        private int direction;

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

        public void Update(int fruitX, int fruitY)
        {
            UpdateDirection();
            if (Eat(fruitX, fruitY))
            {
                Grow();
            }
            Move();
        }

        private void Grow()
        {
            snakeX.Add(snakeX[SnakeX.Count - 1]);
            snakeY.Add(snakeY[snakeY.Count - 1]);
        }

        private bool Eat(int fruitX,int fruitY)
        {
            if(fruitX == snakeX[0] && fruitY == snakeY[0])
            {
                return true;
            }
            return false;
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
            MoveBody();

            MoveHead();
        }

        private void MoveBody()
        {
            snakeXBuffer = new List<int>();
            snakeYBuffer = new List<int>();

            for(int i = 0; i < snakeX.Count; i++)
            {
                snakeXBuffer.Add(snakeX[i]);
                snakeYBuffer.Add(snakeY[i]);
            }

            snakeX = new List<int> { 10 };
            snakeY = new List<int> { 10 };

            for(int i = 0; i < snakeXBuffer.Count; i++)
            {
                snakeX.Add(snakeXBuffer[i]); 
                snakeY.Add(snakeYBuffer[i]);
            }
        }

        private void MoveHead()
        {
            switch (direction)
            {
                case 0:
                    snakeY[0] = snakeYBuffer[0] - 1;
                    snakeX[0] = snakeXBuffer[0];
                    break;
                case 1:
                    snakeX[0] = snakeXBuffer[0] + 1;
                    snakeY[0] = snakeYBuffer[0];
                    break;
                case 2:
                    snakeY[0] = snakeYBuffer[0] + 1;
                    snakeX[0] = snakeXBuffer[0];
                    break;
                case 3:
                    snakeX[0] = snakeXBuffer[0] - 1;
                    snakeY[0] = snakeYBuffer[0];
                    break;
            }
        }
    }
}
