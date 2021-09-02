using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Snaaake
{
    static class Eat
    {
        public static Point Position { get; private set; }

        public static Point GetPosition(Size size)
        {
            Position = new Point(20 * new Random().Next(1, (int)size.Height / 20), 20 * new Random().Next(1, (int)size.Width / 20));

            return Position;
        }
    }
}
