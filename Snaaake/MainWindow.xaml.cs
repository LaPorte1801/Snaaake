using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Snaaake
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SnakePresenter snake;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnPolzti_Click(object sender, RoutedEventArgs e)
        {
            snake = new SnakePresenter(gameCanvas.RenderSize);
            gameCanvas.Children.Add(snake.snakeRect);
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            snake.direction = e.Key;
        }
    }
}
