using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        new Random red = new Random();
        new Random green = new Random();
        new Random blue = new Random();
        new Random left = new Random();
        new Random top = new Random();

        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timertick);
            timer.Interval = new TimeSpan(0, 0, 3);
            timer.Start();
        }

        private void timertick(object sender, EventArgs e)
        {
            Button button = new Button();
            button
                .Content = ("Click me\nif you can");
            button
                .Background = new SolidColorBrush(Color.FromRgb(
                    (byte)red.Next(0, 255),
                    (byte)green.Next(0, 255),
                    (byte)blue.Next(0, 255)));
            button.Width = 160;
            button.Height = 90;
            button.Margin = new Thickness
            {
                Top = top.Next(-360, 360),
                Left = left.Next(-590, 590)
            };
            grid.Children.Add(button);
            button.MouseEnter += Button_MouseEnter;
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            button.Margin = new Thickness
            {
                Top = top.Next(-360, 360),
                Left = left.Next(-590, 590)
            };
        }
    }
}
