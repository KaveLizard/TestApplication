using TestApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace TestApplication.EventDbContext
{
    public class EventContext : DbContext
    {
       public EventContext(DbContextOptions<EventContext> options) : base(options) { }

        public DbSet<Event> Events { get; set; }
    }
}
