// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.Data;

#nullable disable

namespace WebAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebAPI.Models.Announcement", b =>
                {
                    b.Property<int>("announcementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("announcementId"), 1L, 1);

                    b.Property<string>("content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Content");

                    b.Property<string>("date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Date");

                    b.Property<string>("department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Department");

                    b.Property<string>("imageSrc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ImageSrc");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Title");

                    b.HasKey("announcementId");

                    b.ToTable("Announcement", (string)null);

                    b.HasData(
                        new
                        {
                            announcementId = 1,
                            content = "New Wellness Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo d ea rebum. gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet... consetetur sadip m ipsum dolor sit amet, consetetur sadim ipsum dolorsadi...",
                            date = "05/Jan/2021",
                            department = "Human Resource",
                            imageSrc = "https://localhost:44309/ImageAnnoucement/image_gallery-1.png",
                            title = "New Learning System Is Live"
                        },
                        new
                        {
                            announcementId = 2,
                            content = "New Wellness Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo d ea rebum. gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet... consetetur sadip m ipsum dolor sit amet, consetetur sadim ipsum dolorsadi...",
                            date = "05/Jan/2021",
                            department = "Human Resource",
                            imageSrc = "https://localhost:44309/ImageAnnoucement/image_gallery.png",
                            title = "New Learning System Is Live"
                        },
                        new
                        {
                            announcementId = 3,
                            content = "Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo",
                            date = "05/Jan/2021",
                            department = "Human Resource",
                            imageSrc = "https://localhost:44309/ImageAnnoucement/Mask Group -1.png",
                            title = "IT Maintenance"
                        },
                        new
                        {
                            announcementId = 4,
                            content = "Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo",
                            date = "05/Jan/2021",
                            department = "Human Resource",
                            imageSrc = "https://localhost:44309/ImageAnnoucement/Mask Group -2.png",
                            title = "IT Maintenance"
                        },
                        new
                        {
                            announcementId = 5,
                            content = "Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo",
                            date = "05/Jan/2021",
                            department = "Human Resource",
                            imageSrc = "https://localhost:44309/ImageAnnoucement/Mask Group -3.png",
                            title = "IT Maintenance"
                        },
                        new
                        {
                            announcementId = 6,
                            content = "Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo",
                            date = "05/Jan/2021",
                            department = "Human Resource",
                            imageSrc = "https://localhost:44309/ImageAnnoucement/video-3.png",
                            title = "IT Maintenance"
                        });
                });

            modelBuilder.Entity("WebAPI.Models.Events", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Date");

                    b.Property<string>("endTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(48)")
                        .HasColumnName("End Time");

                    b.Property<string>("eventName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Event Name");

                    b.Property<string>("startTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(48)")
                        .HasColumnName("Start Time");

                    b.HasKey("id");

                    b.ToTable("Event", (string)null);

                    b.HasData(
                        new
                        {
                            id = 1,
                            date = "01 Jun",
                            endTime = "09:30:00",
                            eventName = "Register Portal",
                            startTime = "09:00:00"
                        },
                        new
                        {
                            id = 2,
                            date = "01 Jun",
                            endTime = "09:30:00",
                            eventName = "IT Maintenance",
                            startTime = "09:00:00"
                        },
                        new
                        {
                            id = 3,
                            date = "01 Jun",
                            endTime = "09:30:00",
                            eventName = "IT Maintenance",
                            startTime = "09:00:00"
                        },
                        new
                        {
                            id = 4,
                            date = "01 Jun",
                            endTime = "09:30:00",
                            eventName = "IT Maintenance",
                            startTime = "09:00:00"
                        });
                });

            modelBuilder.Entity("WebAPI.Models.Gallery", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("imageSrc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ImageSrc");

                    b.HasKey("id");

                    b.ToTable("Gallery", (string)null);

                    b.HasData(
                        new
                        {
                            id = 1,
                            imageSrc = "https://localhost:44309/ImageGallery/image_gallery.png"
                        },
                        new
                        {
                            id = 2,
                            imageSrc = "https://localhost:44309/ImageGallery/image_gallery_1.png"
                        },
                        new
                        {
                            id = 3,
                            imageSrc = "https://localhost:44309/ImageGallery/video.png"
                        },
                        new
                        {
                            id = 4,
                            imageSrc = "https://localhost:44309/ImageGallery/video_1.png"
                        });
                });

            modelBuilder.Entity("WebAPI.Models.HowDoI", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("anser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Anser");

                    b.Property<string>("question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Question");

                    b.HasKey("Id");

                    b.ToTable("HowDo", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            anser = "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut aliqubore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut ip ex.",
                            question = "Lorem ipsum dolor sit amet"
                        },
                        new
                        {
                            Id = 2,
                            anser = "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut aliqubore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut ip ex.",
                            question = "Lorem ipsum dolor sit amet"
                        },
                        new
                        {
                            Id = 3,
                            anser = "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut aliqubore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut ip ex.",
                            question = "Lorem ipsum dolor sit amet"
                        },
                        new
                        {
                            Id = 4,
                            anser = "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut aliqubore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut ip ex.",
                            question = "Lorem ipsum dolor sit amet"
                        });
                });

            modelBuilder.Entity("WebAPI.Models.News", b =>
                {
                    b.Property<int>("newId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("newId"), 1L, 1);

                    b.Property<string>("content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Content");

                    b.Property<string>("date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Date");

                    b.Property<string>("imageSrc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ImageSrc");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Title");

                    b.HasKey("newId");

                    b.ToTable("News", (string)null);

                    b.HasData(
                        new
                        {
                            newId = 1,
                            content = "New Wellness Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo d ea rebum. gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet... consetetur sadip m ipsum dolor sit amet, consetetur sadim ipsum dolorsadi...",
                            date = "02/Jan/2021",
                            imageSrc = "https://localhost:44309/ImageNews/markgroup_2.png",
                            title = "Tomorrow Healthy Check"
                        },
                        new
                        {
                            newId = 2,
                            content = "Loren ipsum dotor sit arnet, consetetur sadipscing elitrividunt ut labore et dolore aaliquya erat,set diam voluptuaa vero eos et accusam et justo duo",
                            date = "02/Jan/2021",
                            imageSrc = "https://localhost:44309/ImageNews/Mask Group 1.png",
                            title = "Air-conditioning is broken"
                        },
                        new
                        {
                            newId = 3,
                            content = "Loren ipsum dotor sit arnet, consetetur sadipscing elitrividunt ut labore et dolore aaliquya erat,set diam voluptuaa vero eos et accusam et justo duo",
                            date = "02/Jan/2021",
                            imageSrc = "https://localhost:44309/ImageNews/Mask Group 2.png",
                            title = "Keep Running"
                        },
                        new
                        {
                            newId = 4,
                            content = "Loren ipsum dotor sit arnet, consetetur sadipscing elitrividunt ut labore et dolore aaliquya erat,set diam voluptuaa vero eos et accusam et justo duo.",
                            date = "02/Jan/2021",
                            imageSrc = "https://localhost:44309/ImageNews/Mask Group -3.png",
                            title = "Temperature above 37.3℃ need to report"
                        },
                        new
                        {
                            newId = 5,
                            content = "New Wellness Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo d ea rebum. gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet... consetetur sadip m ipsum dolor sit amet, consetetur sadim ipsum dolorsadi...",
                            date = "02/Jan/2021",
                            imageSrc = "https://localhost:44309/ImageNews/image_gallery.png",
                            title = "Tomorrow Healthy Check"
                        },
                        new
                        {
                            newId = 6,
                            content = "Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo",
                            date = "02/Jan/2021",
                            imageSrc = "https://localhost:44309/ImageNews/image_gallery-1.png",
                            title = "Air-conditioning is broken"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
