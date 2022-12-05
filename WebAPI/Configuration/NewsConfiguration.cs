using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAPI.Models;

namespace WebAPI.Configuration
{
    public class NewsConfiguration : IEntityTypeConfiguration<News>
    {
        private readonly IConfiguration _configuration;
        public NewsConfiguration(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.ToTable("News")
            .HasKey(e => e.newId);
            builder.Property(e => e.newId)
             .HasColumnName(@"Id")
             .UseIdentityColumn();
            builder.Property(e => e.title)
            .HasColumnName(@"Title");
            builder.Property(e => e.content)
            .HasColumnName("Content");
            builder.Property(e => e.imageSrc)
            .HasColumnName("ImageSrc");
            builder.Property(e => e.date)
            .HasColumnName("Date");
            builder.HasData(
                new News()
                {
                    newId = 1,
                    title = "Tomorrow Healthy Check",
                    content = "New Wellness Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo d ea rebum. gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet... consetetur sadip m ipsum dolor sit amet, consetetur sadim ipsum dolorsadi...",
                    date = "02/Jan/2021",
                    imageSrc = _configuration.GetValue<string>("Http:url") + "ImageNews" + "/markgroup_2.png"
                },
                new News()
                {
                    newId =  2,
                    title = "Air-conditioning is broken",
                    content = "Loren ipsum dotor sit arnet, consetetur sadipscing elitrividunt ut labore et dolore aaliquya erat,set diam voluptuaa vero eos et accusam et justo duo",
                    date = "02/Jan/2021",
                     imageSrc = _configuration.GetValue<string>("Http:url") + "ImageNews" + "/Mask Group 1.png"
                },
                new News() {
                    newId = 3,
                    title= "Keep Running",
                    content= "Loren ipsum dotor sit arnet, consetetur sadipscing elitrividunt ut labore et dolore aaliquya erat,set diam voluptuaa vero eos et accusam et justo duo",
                    date = "02/Jan/2021",
                    imageSrc = _configuration.GetValue<string>("Http:url") + "ImageNews" + "/Mask Group 2.png"
                },
                new News() {
                     newId = 4,
                    title = "Temperature above 37.3℃ need to report",
                    content = "Loren ipsum dotor sit arnet, consetetur sadipscing elitrividunt ut labore et dolore aaliquya erat,set diam voluptuaa vero eos et accusam et justo duo.",
                    date = "02/Jan/2021",
                    imageSrc = _configuration.GetValue<string>("Http:url") + "ImageNews" + "/Mask Group -3.png"
                },
                new News() {
                    newId = 5,
                    title =  "Tomorrow Healthy Check",
                    content =  "New Wellness Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo d ea rebum. gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet... consetetur sadip m ipsum dolor sit amet, consetetur sadim ipsum dolorsadi...",
                    date = "02/Jan/2021",
                    imageSrc = _configuration.GetValue<string>("Http:url") + "ImageNews" + "/image_gallery.png"
                },
                new News() {
                    newId = 6,
                    title = "Air-conditioning is broken",
                    content = "Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo",
                    date= "02/Jan/2021",
                    imageSrc = _configuration.GetValue<string>("Http:url") + "ImageNews" + "/image_gallery-1.png"
                }
                );
        }
    }
}
