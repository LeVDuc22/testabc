namespace WebAPI.Models
{
    public class AnnouncementForm
    {
        public IFormFile image { set; get; }
        public string title { set; get; }
        public string content { set; get; }
        public string date { set; get; }
        public string department { set; get; }
    }
}
