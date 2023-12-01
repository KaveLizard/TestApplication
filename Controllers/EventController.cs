using TestApplication.Models;
using TestApplication.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Validations;

namespace TestApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private IEventRepository _eventRepository;

        public EventController(IEventRepository repository)
        {
            _eventRepository = repository;
        }

        [HttpGet("/get")]

        public ActionResult<List<Event>> Get() //getall
        {
            var events = _eventRepository.GetAllEvents();
            return Ok(events);
        }

        [HttpPost("/post")] //

        public ActionResult Post(EventViewModel ev)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            _eventRepository.AddEvent(new Event()
            {
                Name = ev.Name,
                Cost = ev.Cost
            });
            return Ok();
        }

        [HttpGet("/get/{id}")]
        public ActionResult<Event> GetEventById(int id)
        {
            var ev = _eventRepository.GetEventById(id);
            if (ev == null)
                return NotFound();

            return Ok(ev);
        }

        [HttpDelete("/delete/{id}")]

        public ActionResult DeleteEventById(int id)
        {
            var ev = _eventRepository.GetEventById(id);

            if (ev == null)
                return NotFound();

            _eventRepository.DeleteEvent(ev);
            return Ok();
        }
    }
}
