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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        Thickness startMargin;
        List<Button> buttons;
        Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();

            startMargin = _box.Margin;

            slider.ValueChanged += slider_ValueChanged;

            buttons = new List<Button> { _0, _1, _2, _3, _4, _5, _6, _7, _8, _9 };
            foreach (Button button in buttons)
            {
                button.Click += IfNullContent;
                button.Click += RandomSwap;
                button.Click += button_Click;
                button.Click += RandomPasswordBoxMove;
            }
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += RandomSwap;
            timer.Interval = new TimeSpan(0, 0, 5);
            timer.Start();
        }

        private void IfNullContent(object sender, EventArgs e)
        {
            if (buttons[0].Content != null) return;
            for (int i = 0; i < 10; i++)
            {
                buttons[i].Content = Convert.ToString(i);
            }
        }

        private void RandomPasswordBoxMove(object sender, EventArgs e)
        {
            Thickness margin = _box.Margin;
            if (random.Next(0, 2) == 1)
            {
                margin.Left -= 10;
            }

            else
            {
                margin.Left += 10;
            }

            _box.Margin = margin;
        }

        private void RandomSwap(object sender, EventArgs e)
        {
            List<Button> buts = new List<Button>();
            Button button1 = buttons[random.Next(0, buttons.Count)];
            object content1 = button1.Content;
            object content;
            buttons.Remove(button1);
            int r = random.Next(0, 255),
                g = random.Next(0, 255),
                b = random.Next(0, 255);
            SolidColorBrush brush = new SolidColorBrush(Color.FromRgb((byte)r, (byte)g, (byte)b));
            foreach (Button button in buttons)
            {
                content = button.Content;
                button.Content = content1;
                button.Background = brush;
                r = random.Next(0, 255);
                g = random.Next(0, 255);
                b = random.Next(0, 255);
                button.Foreground = new SolidColorBrush(Color.FromRgb(
                    (byte)((r + 255) % 255),
                    (byte)((g + 255) % 255),
                    (byte)((b + 255) % 255)));
                content1 = content;
                buts.Add(button);
            }
            button1.Content = content1;
            button1.Foreground = new SolidColorBrush(Color.FromRgb(
                (byte)((r + 255) % 255),
                (byte)((g + 255) % 255),
                (byte)((b + 255) % 255)));
            buts.Add(button1);
            buttons = buts;
        }

        private void _X_Click(object sender, RoutedEventArgs e)
        {
            _box.Margin = startMargin;
            if (_error.Content != null) _error.Content = null;
            _box.Clear();
            foreach (Button button in buttons)
            {
                button.Content = null;
            }
        }

        private void _tick_Click(object sender, RoutedEventArgs e)
        {
            string temp = _box.Password;
            _box.Clear();
            if (temp.Length == slider.Value)
            {
                _error.Foreground = new SolidColorBrush(Color.FromRgb(13, 143, 58));
                _error.Content = "CORRECT PIN";
            }
            else
            {
                _error.Foreground = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                _error.Content = "WRONG PIN";
            }
        }

        private void _box_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (_error.Content != null) _error.Content = null;
        }

        private void _box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) _tick_Click(sender, e);
            else if (_error.Content != null) _error.Content = null;
        }

        private void _box_MouseEnter(object sender, MouseEventArgs e)
        {
            _box.Focus();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            _box.Password += (sender as Button).Content;
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            label.Content = $"{slider.Value}";
        }
    }
}