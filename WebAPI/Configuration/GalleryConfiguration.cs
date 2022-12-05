using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAPI.Models;

namespace WebAPI.Configuration
{
    public class GalleryConfiguration : IEntityTypeConfiguration<Gallery>
    {
        private readonly IConfiguration _configuration;
        public GalleryConfiguration(IConfiguration configuration) {
            _configuration = configuration;
        }
        public void Configure(EntityTypeBuilder<Gallery> builder)
        {
            builder.ToTable("Gallery").HasKey(e => e.id);
            builder.Property(e => e.id)
            .HasColumnName(@"Id")
            .UseIdentityColumn();
            builder.Property(e => e.imageSrc)
            .HasColumnName(@"ImageSrc");
           
            var locahost = _configuration.GetValue<string>("Http:url");
            builder.HasData(
                new Gallery()
                {
                    id = 1,
                    imageSrc = locahost + "ImageGallery/" + "image_gallery.png"
                },
                new Gallery(){
                    id= 2,
                    imageSrc = locahost + "ImageGallery/" + "image_gallery_1.png"
                },
                new Gallery() {
                    id = 3,
                    imageSrc = locahost + "ImageGallery/" + "video.png"
                },
                 new Gallery()
                 {
                     id = 4,
                     imageSrc = locahost + "ImageGallery/" + "video_1.png"
                 }
                ) ;
        }
    }
}
