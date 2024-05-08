using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SnakeCsRaylib
{
    internal class Snake
    {
        private List<int> snakeX, snakeY;

        public Snake()
        {
            snakeX = new List<int>();
            snakeY = new List<int>();
            snakeX[0] = 15;
            snakeY[0] = 15;
        }

        public void Grow(int Direction)
        {

        }
    }
}
