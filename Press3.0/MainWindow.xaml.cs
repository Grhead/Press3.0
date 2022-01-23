using System;
using System.Windows;
using System.Windows.Threading;

namespace Press3._0;

public partial class MainWindow
{
    private readonly Cx _db;

    public MainWindow()
    {
        InitializeComponent();
        _db = new Cx();
        var timer = new DispatcherTimer
        {
            Interval = TimeSpan.FromSeconds(1)
        };
        timer.Tick += TimerTick;
        timer.Start();

        void TimerTick(object sender, EventArgs e)
        {
            LblTime.Content = DateTime.Now.ToLongTimeString();
        }
    }

    private void Handx_sd(object sender, RoutedEventArgs e)
    {
        if (Deffense.Content == "true")
        {
            Deffense.Content = "false";
        }
        else
        {
            Deffense.Content = "true";
        }
        
    }
    private void Send_Click(object sender, RoutedEventArgs e)
    {
        var dateandTime = DateTime.Now;
        var upPressure = Convert.ToInt32(Up.Text);
        var downPressure = Convert.ToInt32(Down.Text);
        var comment = Commentx.Text;
        var hand = Convert.ToBoolean(Deffense.Content);
        var sd = new Hlass(dateandTime, upPressure, downPressure, comment, hand);
        _db.Main.Add(sd);
        _db.SaveChanges();
    }
}