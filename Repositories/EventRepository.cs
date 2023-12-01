using TestApplication.EventDbContext;
using TestApplication.Models;
namespace TestApplication.Repositories
{
    public class EventRepository : IEventRepository
    {
        private EventContext _eventContext;
        public EventRepository(EventContext context)
        {
            _eventContext = context;
        }

        public bool AddEvent(Event ev)
        {
            _eventContext.Events.Add(ev);
            _eventContext.SaveChanges();

            return true;
        }

        public List<Event> GetAllEvents()
        {
            return _eventContext.Events.ToList();
        }

        public Event? GetEventById(int id)
        {
            return _eventContext.Events.Where(e => e.Id == id).FirstOrDefault();
        }

        public bool DeleteEvent(Event ev)
        {
            _eventContext.Remove(ev);
            _eventContext.SaveChanges();

            return true;
        }
    }

    
}
