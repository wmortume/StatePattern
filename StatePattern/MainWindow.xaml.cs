using System;
using System.Windows;
using System.Windows.Threading;

namespace StatePattern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int time = 7;
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            if (time == -1)
            {
                time = 7;
            }

            Light.StartLight(time, ellipseLight);
            timerLabel.Content = $"Time: {time--}";
        }

        private void ChangeLightBtn(object sender, RoutedEventArgs e)
        {
            time = Light.ChangeLight(ellipseLight);
        }
    }
}
