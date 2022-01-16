using System;
using System.Windows;
using System.Windows.Threading;

namespace Press3._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private cx _db;
        public MainWindow()
        {
            InitializeComponent();
            _db = new cx();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
            void timer_Tick(object sender, EventArgs e)
            {
                lblTime.Content = DateTime.Now.ToLongTimeString();
            }

        }

        private void Send_Click(object sender, RoutedEventArgs e)
        {
            DateTime DateandTime = DateTime.Now;
            int UpPressure = Convert.ToInt32(Up.Text);
            int DownPressure = Convert.ToInt32(Down.Text);
            string Comment = (Commentx.Text);
            Hlass sd = new Hlass(DateandTime, UpPressure, DownPressure, Comment);
            _db.Main.Add(sd);
            _db.SaveChanges();
        }
    }
}
