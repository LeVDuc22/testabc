namespace WebAPI.Models
{
    public class PagingParameter
    {
        private const int _maxItemsPerPage = 10;
        private int items_PerPage;
        public int Page { set; get; } = 1;
        public int ItemsPerPage {
            get => items_PerPage;
            set => items_PerPage = value > _maxItemsPerPage ?_maxItemsPerPage : value;
        }
    }
}
