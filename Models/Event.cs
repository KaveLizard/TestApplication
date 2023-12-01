namespace TestApplication.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
    }

    public class EventViewModel
    {
        public string Name { get; set; } = string.Empty;
        public int Cost { get; set; }
    }
}
