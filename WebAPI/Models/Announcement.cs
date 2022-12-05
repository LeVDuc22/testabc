using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
   
    public class Announcement
    {
        public int announcementId { set; get; }
        public string title { set; get; }
        public string content { set; get; }
        public string date { set; get; }
        public string imageSrc { set; get; }
        public string department { set; get; }
    }
   
}
