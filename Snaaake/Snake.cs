using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Snaaake
{
    class Snake
    {
        Size fieldSize;
        int length = 1;
        private int PosX;
        private int PosY;
        private int snakeSize = 20;
        public event Action<Snake> SnakePosChanged;
        public Snake(Size s)
        {
            fieldSize = s;
            PosX = new Random().Next(0, (int)s.Width);
            PosY = new Random().Next(0, (int)s.Height);
            SnakeKrodyotsa();
        }

        public async void SnakeKrodyotsa()
        {
            await Task.Run(() =>
            {
                while (PosX > 0 && PosX < fieldSize.Width && PosY > 0 && PosY < fieldSize.Height)
                {
                    PosX += snakeSize;
                    Debug.WriteLine(GetSnakePosition().X + "; " + GetSnakePosition().Y);
                    Thread.Sleep(500);
                    
                }

                
            });
            SnakePosChanged(this);
        }

        public Point GetSnakePosition()
        {
            return new Point(PosX, PosY);
        }
    }
}
