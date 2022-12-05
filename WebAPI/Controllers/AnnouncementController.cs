using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Text.Json;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AnnouncementController : ControllerBase
    {
        
        public readonly DataContext _dataContext;
        public static IWebHostEnvironment _webHostEnvironment;
        private readonly IConfiguration _configuration;
        public AnnouncementController(IWebHostEnvironment webHostEnvironment, DataContext dataContext, IConfiguration configuration)
        {
            _webHostEnvironment = webHostEnvironment;
            _dataContext = dataContext;
            _configuration = configuration;
        }
        [HttpPost("post")]

        public IActionResult Post([FromForm] AnnouncementForm annForm) {
            try
            {

                if (annForm.image.Length > 0)
                {
                    string path = _webHostEnvironment.WebRootPath + "\\ImageAnnoucement\\";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    using (FileStream fileStream = System.IO.File.Create(path + annForm.image.FileName))
                    {
                        annForm.image.CopyTo(fileStream);

                        fileStream.Flush();
                    }
                    var announcement = new Announcement()
                    {
                        content = annForm.content,
                        title = annForm.title,
                        imageSrc = _configuration.GetValue<string>("Http:url") + "ImageAnnoucement/" + annForm.image.FileName,
                        date = annForm.date,
                        department = annForm.department,
                    };
                    _dataContext.announcements.Add(announcement);
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
        public IEnumerable<Announcement> GetAll([FromQuery] PagingParameter @param) {
            try
            {

                var Anns = _dataContext.announcements.OrderBy(e => e.announcementId);                     
                var paginationMetadata = new PaginationMetadata(Anns.Count(), param.Page, param.ItemsPerPage);
                Response.Headers.Add("Pagination", JsonSerializer.Serialize(paginationMetadata));
                var items = Anns.Skip((param.Page - 1) * param.ItemsPerPage)
                            .Take(param.ItemsPerPage);
                return items;
            }
            catch {
                return null;
            }
           
         
        }
        [HttpGet("get/{id}")]
        public Announcement Get(int id)
        {
            try
            {
                var ann = _dataContext.announcements
                  .Where(a => a.announcementId == id).First();
                if (ann == null)
                {
                    return null;
                }
                return ann;
            }
            catch {

                return null;
            }
              
            
        }
          
        
   
        [HttpPut("put/{id}")]
        public IActionResult Put(int id, [FromForm] AnnouncementForm annForm) {
            try {
                
                    var announcement = _dataContext.announcements.Find(id);
                if (announcement == null)
                    {
                        return BadRequest();
                    }
                    else
                    {
                    string[] strS = announcement.imageSrc.Split('/');
                    var path = _webHostEnvironment.WebRootPath + "\\ImageAnnoucement\\" + strS[strS.Length - 1];
                    if (!System.IO.File.Exists(path))
                        {
                            return NotFound();
                        }
                        System.IO.File.Delete(path);
                        announcement.imageSrc = _configuration.GetValue<string>("Http:url") + "ImageAnnoucement/" + annForm.image.FileName;
                        using (FileStream fileStream = 
                        System.IO.File.Create(_webHostEnvironment.WebRootPath + "\\ImageAnnoucement\\" + annForm.image.FileName))
                        {
                            annForm.image.CopyTo(fileStream);
                            fileStream.Flush();
                        }
                        announcement.title = annForm.title;
                        announcement.content = annForm.content;
                        announcement.date = annForm.date;
                        announcement.department= annForm.department;
                        _dataContext.announcements.Update(announcement);
                        _dataContext.SaveChanges();
                        return Ok(new
                        {
                            Success = true,
                            dataPut=announcement,
                        });
                    
                }
                   
            }
            catch{
                return BadRequest();
            }
          

        }
        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id) {
            try
            {
                var Announcement = _dataContext.announcements.Where(a => a.announcementId == id).First();
                if (Announcement != null)
                {
                    string[] strS = Announcement.imageSrc.Split('/');
                    var path = _webHostEnvironment.WebRootPath + "\\ImageAnnoucement\\" + strS[strS.Length - 1];
                    if (!System.IO.File.Exists(path))
                    {
                        return NotFound();
                    }
                    System.IO.File.Delete(path);
                    _dataContext.announcements.Remove(Announcement);
                    _dataContext.SaveChanges();
                    return Ok(
                        new
                        {
                            Success = true,
                            dataDelete = Announcement
                        }
                        );
                }
                else
                {
                    return NotFound();
                }
            }
            catch {
                return NotFound();
            }
            

        }
    }
}
