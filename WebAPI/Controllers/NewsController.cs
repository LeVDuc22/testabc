using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Data;
using System.Text.Json;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : Controller
    {
        public readonly DataContext _dataContext;
        public static IWebHostEnvironment _webHostEnvironment;
        private readonly IConfiguration _configuration;
        public NewsController(IWebHostEnvironment webHostEnvironment, DataContext dataContext, IConfiguration configuration)
        {
            _webHostEnvironment = webHostEnvironment;
            _dataContext = dataContext;
            _configuration = configuration;
        }
        [HttpPost("post")]

        public IActionResult Post([FromForm] NewsForm newsForm)
        {
            try
            {
                if (newsForm.image.Length > 0)
                {
                    string path = _webHostEnvironment.WebRootPath + "\\ImageNews\\";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    using (FileStream fileStream = System.IO.File.Create(path + newsForm.image.FileName))
                    {
                        newsForm.image.CopyTo(fileStream);

                        fileStream.Flush();
                    }
                    var News = new News()
                    {
                        content = newsForm.content,
                        title = newsForm.title,
                        imageSrc = _configuration.GetValue<string>("Http:url") + "ImageNews/" + newsForm.image.FileName,
                        date = newsForm.date,

                    };

                    _dataContext.news.Add(News);
                    _dataContext.SaveChanges();
                }
                else
                {
                    return BadRequest();
                }
                return Ok(

                    new
                    {
                        Success = true,
                        data = newsForm
                    });
            }
            catch {
                return BadRequest();
            }

          

        }
        [HttpGet("get_all")]
        public IEnumerable<News> GetAll([FromQuery] PagingParameter @param)
        {
            try {

                var News = _dataContext.news.OrderBy(e => e.newId);
                var paginationMetadata = new PaginationMetadata(News.Count(), param.Page, param.ItemsPerPage);
                Response.Headers.Add("Pagination", JsonSerializer.Serialize(paginationMetadata));
                var items = News.Skip((param.Page - 1) * param.ItemsPerPage)
                            .Take(param.ItemsPerPage);
                return items;
            }
            catch
            {
                return null;
            }


        }
        [HttpGet("get/{id}")]
        public News Get(int id)
        {
            try
            {
                var news = _dataContext.news
                  .Where(a => a.newId == id).First();
                if (news == null)
                {
                    return null;
                }
                return news;
            }
            catch
            {

                return null;
            }
        }



        [HttpPut("put/{id}")]
        public IActionResult Put(int id, [FromForm] NewsForm newsForm)
        {
            try
            {

                var News = _dataContext.news.Find(id);
                if (News == null)
                {
                    return NotFound();
                }
                else
                {
                    string[] strS = News.imageSrc.Split('/');
                    var path = _webHostEnvironment.WebRootPath + "\\ImageNews\\" + strS[strS.Length - 1];
                    if (!System.IO.File.Exists(path))
                    {
                        return NotFound();
                    }
                    System.IO.File.Delete(path);
                    News.imageSrc = _configuration.GetValue<string>("Http:url") + "ImageNews/" + newsForm.image.FileName;
                    using (FileStream fileStream = System.IO.File.Create(_webHostEnvironment.WebRootPath + "\\ImageNews\\" + newsForm.image.FileName))
                    {
                        newsForm.image.CopyTo(fileStream);
                        fileStream.Flush();
                    }
                    News.title = newsForm.title;
                    News.content = newsForm.content;
                    News.date = newsForm.date;
                    _dataContext.news.Update(News);
                    _dataContext.SaveChanges();
                    return Ok(new
                    {
                        Success = true,

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
                var News = _dataContext.news.Where(a => a.newId == id).First();
                if (News != null)
                {
                    string[] strS = News.imageSrc.Split('/');
                    var path = _webHostEnvironment.WebRootPath + "\\ImageNews\\" + strS[strS.Length - 1];
                    if (!System.IO.File.Exists(path))
                    {
                        return NotFound();
                    }
                    System.IO.File.Delete(path);
                    _dataContext.news.Remove(News);
                    _dataContext.SaveChanges();
                    return Ok(
                        new
                        {
                            Success = true,
                            data = News
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

