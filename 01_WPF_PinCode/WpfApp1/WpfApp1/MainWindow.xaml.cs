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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void _X_Click(object sender, RoutedEventArgs e)
        {
            if (_error.Content != null) _error.Content = null;
            _box.Clear();
        }

        private void _tick_Click(object sender, RoutedEventArgs e)
        {
            string temp = _box.Password;
            _box.Clear();
            if (temp == "2004")
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

        private void _0_Click_1(object sender, RoutedEventArgs e)
        {
            if(_error.Content != null) _error.Content = null;
            _box.Password += "0";
        }

        private void _9_Click_1(object sender, RoutedEventArgs e)
        {
            if (_error.Content != null) _error.Content = null;
            _box.Password += "9";
        }

        private void _8_Click_1(object sender, RoutedEventArgs e)
        {
            if (_error.Content != null) _error.Content = null;
            _box.Password += "8";
        }

        private void _7_Click(object sender, RoutedEventArgs e)
        {
            if (_error.Content != null) _error.Content = null;
            _box.Password += "7";
        }

        private void _6_Click(object sender, RoutedEventArgs e)
        {
            if (_error.Content != null) _error.Content = null;
            _box.Password += "6";
        }

        private void _5_Click(object sender, RoutedEventArgs e)
        {
            if (_error.Content != null) _error.Content = null;
            _box.Password += "5";
        }

        private void _4_Click(object sender, RoutedEventArgs e)
        {
            if (_error.Content != null) _error.Content = null;
            _box.Password += "4";
        }

        private void _3_Click(object sender, RoutedEventArgs e)
        {
            if (_error.Content != null) _error.Content = null;
            _box.Password += "3";
        }

        private void _2_Click(object sender, RoutedEventArgs e)
        {
            if (_error.Content != null) _error.Content = null;
            _box.Password += "2";
        }

        private void _1_Click(object sender, RoutedEventArgs e)
        {
            if (_error.Content != null) _error.Content = null;
            _box.Password += "1";
        }
    }
}