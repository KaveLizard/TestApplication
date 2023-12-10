using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using TestApplication.EventDbContext;
using TestApplication.Models;

namespace TestApplication.Services
{
    public interface IEventService
    {
        Task<List<Event>> GetEvents();
    }

    public class EventService : IEventService
    {
        private readonly EventContext _dbContext;

        public EventService(EventContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Event>> GetEvents()
        {
            return _dbContext.Events.ToList();
        }
        public async Task<List<Event>> GetEventById(int id)
        {
            return _dbContext.Events.Take(id).ToList();
        }
        

        Task<List<Event>> IEventService.GetEvents()
        {
            throw new NotImplementedException();
        }
    }
}

