using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
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
        public Key SnakeDirection { get; set; }

        public Snake(Size s)
        {
            fieldSize = s;
            PosX = new Random().Next(0, (int)s.Width);
            PosY = new Random().Next(0, (int)s.Height);
        
            SnakeKrodyotsa();
        }

        public async void SnakeKrodyotsa()
        {
            while (PosX > 0 && PosX < fieldSize.Width && PosY > 0 && PosY < fieldSize.Height)
            {
                await Task.Run(() =>
                {
                    if (SnakeDirection == Key.Right)
                        PosX += snakeSize;
                    else if (SnakeDirection == Key.Left)
                        PosX -= snakeSize;
                    else if (SnakeDirection == Key.Up)
                        PosY -= snakeSize;
                    else if (SnakeDirection == Key.Down)
                        PosY += snakeSize;
                    else
                        PosX -= snakeSize;
                    Debug.WriteLine(GetSnakePosition().X + "; " + GetSnakePosition().Y);
                    Thread.Sleep(500);

                });
                SnakePosChanged(this);
            }
        }

        public Point GetSnakePosition()
        {
            return new Point(PosX, PosY);
        }
    }
}
