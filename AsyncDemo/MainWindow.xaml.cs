using System;
using System.Threading.Tasks;
using System.Windows;

namespace AsyncDemo
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            ComputeAsync();
        }

        private void Window_Loaded(object sender, EventArgs e)
        {
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button clicked");
        }

        private async void ComputeAsync()
        {
            while (true)
            {
                MessageTextBlock.Text = "Running";

                double sum = 0.0;

                await Task.Run(() =>
                {
                    for (int n = 1; n < 200000000; n++)
                    {
                        sum += Math.Sqrt(n);
                    }
                });

                MessageTextBlock.Text = $"Sum = {sum}";

                await Task.Run(() =>
                {
                    for (int n = 1; n < 200000000; n++)
                    {
                        sum += Math.Sqrt(n);
                    }
                });

                MessageTextBlock.Text = $"Sum = {sum}";

                await Task.Run(() =>
                {
                    for (int n = 1; n < 200000000; n++)
                    {
                        sum += Math.Sqrt(n);
                    }
                });

                MessageTextBlock.Text = $"Sum = {sum}";

                await Task.Run(() =>
                {
                    for (int n = 1; n < 200000000; n++)
                    {
                        sum += Math.Sqrt(n);
                    }
                });

                MessageTextBlock.Text = $"Sum = {sum}";
            }
        }
    }
}
