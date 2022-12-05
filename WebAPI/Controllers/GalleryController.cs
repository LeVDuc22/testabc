using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Data;
using Microsoft.Extensions.Logging;
using System.Text.Json;
namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GalleryController : Controller
    {
            private readonly IConfiguration _configuration;
            public readonly DataContext _dataContext;
            public static IWebHostEnvironment _webHostEnvironment;
            public GalleryController(IWebHostEnvironment webHostEnvironment, DataContext dataContext,
                IConfiguration configuration)
            {
                _webHostEnvironment = webHostEnvironment;
                _dataContext = dataContext;
                _configuration = configuration;

            }
            [HttpPost("post")]

            public IActionResult Post([FromForm] GalleryForm galleryForm)
            {
            try
            {
                if (galleryForm.image.Length > 0)
                {
                    string path = _webHostEnvironment.WebRootPath + "\\ImageGallery\\";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    using (FileStream fileStream = System.IO.File.Create(path + galleryForm.image.FileName))
                    {
                        galleryForm.image.CopyTo(fileStream);

                        fileStream.Flush();
                    }
                    var Gallery = new Gallery()
                    {

                        imageSrc = _configuration.GetValue<string>("Http:url") + "ImageGallery/" + galleryForm.image.FileName


                    };

                    _dataContext.Add(Gallery);
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

                    });
            }
            catch {
                return BadRequest();
            }

               

            }
            [HttpGet("get_all")]
            public IEnumerable<Gallery> GetAll([FromQuery] PagingParameter @param)
            {
            try
            {
                var galleries = _dataContext.galleries.OrderBy(e=>e.id);
                var paginationMetadata = new PaginationMetadata(galleries.Count(), param.Page, param.ItemsPerPage);
                Response.Headers.Add("Pagination", JsonSerializer.Serialize(paginationMetadata));
                var items = galleries.Skip((param.Page - 1) * param.ItemsPerPage)
                            .Take(param.ItemsPerPage);
                return items;
            }
            catch {
                return null;
            }
               

            }
            [HttpGet("get/{id}")]
            public Gallery Get(int id)
            {
                try
                {
                    var gallery = _dataContext.galleries
                      .Where(a => a.id == id).First();
                    if (gallery == null)
                    {
                        return null;
                    }
                    return gallery;
                }
                catch
                {

                    return null;
                }
            }



            [HttpPut("put/{id}")]
            public IActionResult Put(int id, [FromForm] GalleryForm galleryForm)
            {
            try
            {
                var Gallery = _dataContext.galleries.Find(id);
                if (Gallery == null)
                {
                    return NotFound();
                }
                else
                {
                    string[] strS = Gallery.imageSrc.Split('/');
                    var path = _webHostEnvironment.WebRootPath + "\\ImageGallery\\" + strS[strS.Length - 1];
                    if (!System.IO.File.Exists(path))
                    {
                        return NotFound();
                    }
                    System.IO.File.Delete(path);
                    Gallery.imageSrc = _configuration.GetValue<string>("Http:url") + "ImageGallery/" + galleryForm.image.FileName;
                    using (FileStream fileStream = System.IO.File.Create(_webHostEnvironment.WebRootPath + "\\ImageGallery\\" + galleryForm.image.FileName))
                    {
                        galleryForm.image.CopyTo(fileStream);
                        fileStream.Flush();
                    }


                    _dataContext.galleries.Update(Gallery);
                    _dataContext.SaveChanges();
                    return Ok(new
                    {
                        Success = true,
                        dataPut = Gallery,
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
                    var gallery = _dataContext.galleries.Where(a => a.id == id).First();
                    if (gallery != null)
                    {
                        string[] strS = gallery.imageSrc.Split('/');
                        var path = _webHostEnvironment.WebRootPath + "\\ImageGallery\\" + strS[strS.Length - 1];
                        if (!System.IO.File.Exists(path))
                        {
                            return NotFound();
                        }
                        System.IO.File.Delete(path);
                        _dataContext.Remove(gallery);
                        _dataContext.SaveChanges();
                        return Ok(
                            new
                            {
                                Success = true,
                                dataDelete = gallery
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
