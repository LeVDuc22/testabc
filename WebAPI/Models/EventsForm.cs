using System.Globalization;

namespace WebAPI.Models
{
    public class EventsForm
    {
        public string eventName { set; get; }
        public string date { set; get; }
        public int startHour { set; get; }
        public int startMinutes { set; get; }
        public int endHour { set; get; }
        public int endMinutes { set; get; }
      
    }
}

