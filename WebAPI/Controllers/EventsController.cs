using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Data;
using Microsoft.Extensions.Logging;
using System.Text.Json;
namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : Controller
    {
       
       
        public readonly DataContext _dataContext;
        
        public EventsController( DataContext dataContext)
        {
            
            _dataContext = dataContext;
           

        }
        [HttpPost("post")]

        public IActionResult Post([FromForm] EventsForm eventsForm)
        {

            try
            {
                var Events = new Events()
                {
                    eventName = eventsForm.eventName,

                    startTime = new TimeSpan(eventsForm.startHour, eventsForm.startMinutes, 0),

                    endTime = new TimeSpan(eventsForm.endHour, eventsForm.endMinutes, 0),
                    date = eventsForm.date,
                };

                _dataContext.events.Add(Events);
                _dataContext.SaveChanges();


                return Ok(

                    new
                    {
                        Success = true,
                        dataPost = Events,
                    });
            }
            catch {
                return BadRequest();
                    }
    
           

        }
        [HttpGet("get_all")]
        public IEnumerable<Events> GetAll([FromQuery] PagingParameter @param)
        {
            try
            {
                var events = _dataContext.events.OrderBy(e => e.id);
                var paginationMetadata = new PaginationMetadata(events.Count(), param.Page, param.ItemsPerPage);
                Response.Headers.Add("Pagination", JsonSerializer.Serialize(paginationMetadata));
                var items = events.Skip((param.Page - 1) * param.ItemsPerPage)
                            .Take(param.ItemsPerPage);
                return items;
            }
            catch {
                return null;
            }
          

        }
        [HttpGet("get/{id}")]
        public Events Get(int id)
        {
            try
            {
                var events = _dataContext.events
                  .Where(a => a.id == id).First();
                if (events == null)
                {
                    return null;
                }
                return events;
            }
            catch
            {

                return null;
            }
        }



        [HttpPut("put/{id}")]
        public IActionResult Put(int id, [FromForm] EventsForm eventsForm)
        {
            try
            {
                var Events = _dataContext.events.Find(id);
                if (Events == null)
                {
                    return NotFound();
                }
                else
                {

                    Events.eventName = eventsForm.eventName;
                    Events.startTime = new TimeSpan(eventsForm.startHour, eventsForm.startMinutes, 0);
                    Events.endTime = new TimeSpan(eventsForm.endHour, eventsForm.endMinutes, 0);
                    Events.date = eventsForm.date;
                    _dataContext.events.Update(Events);
                    _dataContext.SaveChanges();
                    return Ok(new
                    {
                        Success = true,
                        dataUpdate = Events,
                    });

                }
            }
            catch
            {
                return BadRequest();
            }
        }


    [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var events = _dataContext.events.Where(a => a.id == id).First();
                if (events != null)
                {
                    _dataContext.events.Remove(events);
                    _dataContext.SaveChanges();
                    return Ok(
                        new
                        {
                            Success = true,
                            dataDelete = events,
                        }
                        );
                }
                else
                {
                    return NotFound();
                }
            }
            catch
            {
                return NotFound();
            }


        }
    }
}

