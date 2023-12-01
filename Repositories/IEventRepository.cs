using TestApplication.Models;

namespace TestApplication.Repositories;
    public interface IEventRepository
    {
        List<Event> GetAllEvents();
        Event? GetEventById(int id);
    bool AddEvent(Event ev);

    bool DeleteEvent(Event ev);

    }