namespace WebAPI.Models
{
    public class Events
    {
        public int id { set; get; }
        public string eventName { set; get; }
        public string date { set; get; }
        public TimeSpan startTime { set; get; }
        public TimeSpan endTime { set; get; }
    }
}