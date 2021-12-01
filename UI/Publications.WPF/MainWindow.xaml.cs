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

namespace Publications.WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var fib_thread = new Thread(() => Fibonacci(10));
            fib_thread.Start();
        }

        private void Fibonacci(int number)
        {
            int first = 0;
            int second = 1;
            int sum = 0;
            int count = 0;
            while (count != number)
            {
                for (int i = 3; i >= 0; i--)
                {
                    Thread.Sleep(1000);
                    TimerTextBlock.Dispatcher.Invoke(() =>
                    {
                        TimerTextBlock.Text = i.ToString();
                    });
                }
                sum = first + second;
                FibTextBlock.Dispatcher.Invoke(() =>
                {
                    FibTextBlock.Text = sum.ToString();
                });
                first = second;
                second = sum;
                count++;
            } 
        }
    }
}
