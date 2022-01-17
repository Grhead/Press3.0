using System;

namespace Press3._0
{
    public class Hlass
    {
        public int ID { get; set; }
        public DateTime DateandTime { get; set; }
        public int UpPressure { get; set; }
        public int DownPressure { get; set; }
        public string? Comment { get; set; }
        public Hlass() { }

        public Hlass(DateTime DateandTime, int UpPressure, int DownPressure, string Comment)
        {
            this.DateandTime = DateandTime;
            this.UpPressure = UpPressure;
            this.DownPressure = DownPressure;
            this.Comment = Comment;
        }
    }
}
