using System;

namespace Press3._0
{
    public class Hlass
    {
        public int Id { get; set; }
        public DateTime DateandTime { get; set; }
        public int UpPressure { get; set; }
        public int DownPressure { get; set; }
        public string? Comment { get; set; }
        public bool Hand { get; set; }
        public Hlass() { }

        public Hlass(DateTime dateandTime, int upPressure, int downPressure, string comment, bool hand)
        {
            this.DateandTime = dateandTime;
            this.UpPressure = upPressure;
            this.DownPressure = downPressure;
            this.Comment = comment;
            this.Hand = hand;
        }
    }
}
