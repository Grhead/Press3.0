using System;
using System.Windows;
using System.Windows.Threading;

namespace Press3._0
{
    public partial class MainWindow
    {
        private readonly Cx _db;
        public MainWindow()
        {
            InitializeComponent();
            _db = new Cx();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += TimerTick;
            timer.Start();
            void TimerTick(object sender, EventArgs e)
            {
                LblTime.Content = DateTime.Now.ToLongTimeString();
            }

        }

        private void Handx_sd(object sender, RoutedEventArgs e)
        {
            Sobutie();
        }

        static bool Sobutie()
        {
            bool handx = true;
            return handx;
        }
        private void Send_Click(object sender, RoutedEventArgs e)
        {
            DateTime dateandTime = DateTime.Now;
            int upPressure = Convert.ToInt32(Up.Text);
            int downPressure = Convert.ToInt32(Down.Text);
            string comment = (Commentx.Text);
            bool hand = Sobutie();
            Hlass sd = new Hlass(dateandTime, upPressure, downPressure, comment, hand);
            _db.Main.Add(sd);
            _db.SaveChanges();
        }

        
    }
}
