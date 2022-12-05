using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HowDoController : Controller
    {
        public readonly DataContext _dataContext;
        public HowDoController(DataContext dataContext)
        {

            _dataContext = dataContext;
        }
        [HttpPost("post")]

        public IActionResult Post([FromForm] HowDoForm howDoForm)
        {

            try
            {
                var howDo = new HowDoI()
                {
                    anser = howDoForm.anser,
                    question = howDoForm.question,
                };

                _dataContext.howDo.Add(howDo);
                _dataContext.SaveChanges();


                return Ok(

                    new
                    {
                        Success = true,
                        dataPost = howDo,
                    });
            }
            catch {
                return BadRequest();
            }

           

        }
        [HttpGet("get_all")]
        public IEnumerable<HowDoI> GetAll([FromQuery] PagingParameter @param)
        {

            var howDoIs = _dataContext.howDo;
            var paginationMetadata = new PaginationMetadata(howDoIs.Count(), param.Page, param.ItemsPerPage);
            Response.Headers.Add("Pagination", JsonSerializer.Serialize(paginationMetadata));
            var items = howDoIs.Skip((param.Page - 1) * param.ItemsPerPage)
                        .Take(param.ItemsPerPage);
            return items;

        }
        [HttpGet("get/{id}")]
        public HowDoI Get(int id)
        {
            try
            {
                var howDo = _dataContext.howDo
                  .Where(a => a.Id == id).First();
                if (howDo == null)
                {
                    return null;
                }
                return howDo;
            }
            catch
            {

                return null;
            }
        }



        [HttpPut("put/{id}")]
        public IActionResult Put(int id, [FromForm] HowDoForm howDoForm)
        {
            try
            {
                var howDo = _dataContext.howDo.Find(id);
                if (howDo == null)
                {
                    return NotFound();
                }
                else
                {
                    howDo.question = howDoForm.question;
                    howDo.anser = howDoForm.anser;

                    _dataContext.howDo.Update(howDo);
                    _dataContext.SaveChanges();
                    return Ok(new
                    {
                        Success = true,
                        dataUpdate = howDo,
                    });

                }
            }
            catch {
                return BadRequest();
            }

         

        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var howDo = _dataContext.howDo.Where(a => a.Id == id).First();
                if (howDo != null)
                {
                    _dataContext.howDo.Remove(howDo);
                    _dataContext.SaveChanges();
                    return Ok(
                        new
                        {
                            Success = true,
                            dataDelete = howDo,
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
