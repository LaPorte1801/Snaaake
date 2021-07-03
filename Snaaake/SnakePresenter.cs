using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Snaaake
{
    class SnakePresenter
    {
        Snake snake;
        public Rectangle snakeRect;
        int snakeSize = 20;

        public SnakePresenter(Size s)
        {
            snake = new Snake(s);
            snakeRect = new Rectangle();
            snakeRect.Width = snakeSize;
            snakeRect.Height = snakeSize;
            snakeRect.Fill = Brushes.Black;
            snakeRect.Stroke = Brushes.White;
            snakeRect.StrokeThickness = 1;
            Canvas.SetLeft(snakeRect, snake.GetSnakePosition().X - (snakeSize / 2));
            Canvas.SetTop(snakeRect, snake.GetSnakePosition().Y - (snakeSize / 2));
            snake.SnakePosChanged += Snake_SnakePosChanged;
        }

        private void Snake_SnakePosChanged(Snake snake)
        {
            Canvas.SetLeft(snakeRect, snake.GetSnakePosition().X - (snakeSize / 2));
            Canvas.SetTop(snakeRect, snake.GetSnakePosition().Y - (snakeSize / 2));
        }
    }
}
