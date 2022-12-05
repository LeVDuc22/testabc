using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Net;
using System.Reflection.Emit;
using WebAPI.Models;
namespace WebAPI.Configuration
{
    public class AnnoucementConfiguration : IEntityTypeConfiguration<Announcement>
    {
        private readonly IConfiguration _configuration;
        

        public AnnoucementConfiguration(IConfiguration configuration){
            _configuration = configuration;
        }
       
        public void Configure(EntityTypeBuilder<Announcement> builder1)
        {
            builder1.ToTable("Announcement")
            .HasKey(e => e.announcementId);

            builder1.Property(e => e.announcementId)
             .HasColumnName(@"Id")
             .UseIdentityColumn();
            builder1.Property(e => e.title)
            .HasColumnName(@"Title");
            builder1.Property(e => e.content)
            .HasColumnName("Content");
            builder1.Property(e => e.imageSrc)
            .HasColumnName("ImageSrc");
            builder1.Property(e => e.date)
            .HasColumnName("Date");
            builder1.Property(e => e.department)
           .HasColumnName("Department");
          
            builder1.HasData(
                new Announcement()
                {

                    announcementId = 1,
                    title = "New Learning System Is Live",
                    content = "New Wellness Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo d ea rebum. gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet... consetetur sadip m ipsum dolor sit amet, consetetur sadim ipsum dolorsadi...",
                    date = "05/Jan/2021",
                    imageSrc = _configuration.GetValue<string>("Http:url") + "ImageAnnoucement" + "/image_gallery-1.png",
                    department = "Human Resource"

                },
                 new Announcement()
                 {
                     announcementId = 2,
                     title = "New Learning System Is Live",
                     content = "New Wellness Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo d ea rebum. gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet... consetetur sadip m ipsum dolor sit amet, consetetur sadim ipsum dolorsadi...",
                     date = "05/Jan/2021",
                     imageSrc = _configuration.GetValue<string>("Http:url") + "ImageAnnoucement" + "/image_gallery.png",
                     department = "Human Resource"
                 },
                  new Announcement()
                  {
                      announcementId = 3,
                      title = "IT Maintenance",
                      content = "Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo",
                      date = "05/Jan/2021",
                      imageSrc = _configuration.GetValue<string>("Http:url") + "ImageAnnoucement" + "/Mask Group -1.png",
                      department = "Human Resource"
                  },
                  new Announcement()
                  {
                      announcementId = 4,
                      title = "IT Maintenance",
                      content = "Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo",
                      date = "05/Jan/2021",
                      imageSrc = _configuration.GetValue<string>("Http:url") + "ImageAnnoucement" + "/Mask Group -2.png",
                      department = "Human Resource"
                  },
                  new Announcement()
                  {
                      announcementId = 5,
                      title = "IT Maintenance",
                      content = "Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo",
                      date = "05/Jan/2021",
                      imageSrc = _configuration.GetValue<string>("Http:url") + "ImageAnnoucement" + "/Mask Group -3.png",
                      department = "Human Resource"
                  },
                  new Announcement()
                  {
                      announcementId = 6,
                      title = "IT Maintenance",
                      content = "Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo",
                      date = "05/Jan/2021",
                      imageSrc = _configuration.GetValue<string>("Http:url") + "ImageAnnoucement" + "/video-3.png",
                      department = "Human Resource"
                  }
                );
        }
    }
}
