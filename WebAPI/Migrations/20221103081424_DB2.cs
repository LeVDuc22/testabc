using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    public partial class DB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Announcement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageSrc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventName = table.Column<string>(name: "Event Name", type: "nvarchar(max)", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartTime = table.Column<string>(name: "Start Time", type: "nvarchar(48)", nullable: false),
                    EndTime = table.Column<string>(name: "End Time", type: "nvarchar(48)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gallery",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageSrc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gallery", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HowDo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Anser = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HowDo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageSrc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Announcement",
                columns: new[] { "Id", "Content", "Date", "Department", "ImageSrc", "Title" },
                values: new object[,]
                {
                    { 1, "New Wellness Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo d ea rebum. gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet... consetetur sadip m ipsum dolor sit amet, consetetur sadim ipsum dolorsadi...", "05/Jan/2021", "Human Resource", "https://localhost:44309/ImageAnnoucement/image_gallery-1.png", "New Learning System Is Live" },
                    { 2, "New Wellness Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo d ea rebum. gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet... consetetur sadip m ipsum dolor sit amet, consetetur sadim ipsum dolorsadi...", "05/Jan/2021", "Human Resource", "https://localhost:44309/ImageAnnoucement/image_gallery.png", "New Learning System Is Live" },
                    { 3, "Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo", "05/Jan/2021", "Human Resource", "https://localhost:44309/ImageAnnoucement/Mask Group -1.png", "IT Maintenance" },
                    { 4, "Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo", "05/Jan/2021", "Human Resource", "https://localhost:44309/ImageAnnoucement/Mask Group -2.png", "IT Maintenance" },
                    { 5, "Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo", "05/Jan/2021", "Human Resource", "https://localhost:44309/ImageAnnoucement/Mask Group -3.png", "IT Maintenance" },
                    { 6, "Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo", "05/Jan/2021", "Human Resource", "https://localhost:44309/ImageAnnoucement/video-3.png", "IT Maintenance" }
                });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "Date", "End Time", "Event Name", "Start Time" },
                values: new object[,]
                {
                    { 1, "01 Jun", "09:30:00", "Register Portal", "09:00:00" },
                    { 2, "01 Jun", "09:30:00", "IT Maintenance", "09:00:00" },
                    { 3, "01 Jun", "09:30:00", "IT Maintenance", "09:00:00" },
                    { 4, "01 Jun", "09:30:00", "IT Maintenance", "09:00:00" }
                });

            migrationBuilder.InsertData(
                table: "Gallery",
                columns: new[] { "Id", "ImageSrc" },
                values: new object[,]
                {
                    { 1, "https://localhost:44309/ImageGallery/image_gallery.png" },
                    { 2, "https://localhost:44309/ImageGallery/image_gallery_1.png" },
                    { 3, "https://localhost:44309/ImageGallery/video.png" },
                    { 4, "https://localhost:44309/ImageGallery/video_1.png" }
                });

            migrationBuilder.InsertData(
                table: "HowDo",
                columns: new[] { "Id", "Anser", "Question" },
                values: new object[,]
                {
                    { 1, "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut aliqubore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut ip ex.", "Lorem ipsum dolor sit amet" },
                    { 2, "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut aliqubore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut ip ex.", "Lorem ipsum dolor sit amet" },
                    { 3, "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut aliqubore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut ip ex.", "Lorem ipsum dolor sit amet" },
                    { 4, "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut aliqubore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut ip ex.", "Lorem ipsum dolor sit amet" }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "Content", "Date", "ImageSrc", "Title" },
                values: new object[,]
                {
                    { 1, "New Wellness Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo d ea rebum. gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet... consetetur sadip m ipsum dolor sit amet, consetetur sadim ipsum dolorsadi...", "02/Jan/2021", "https://localhost:44309/ImageNews/markgroup_2.png", "Tomorrow Healthy Check" },
                    { 2, "Loren ipsum dotor sit arnet, consetetur sadipscing elitrividunt ut labore et dolore aaliquya erat,set diam voluptuaa vero eos et accusam et justo duo", "02/Jan/2021", "https://localhost:44309/ImageNews/Mask Group 1.png", "Air-conditioning is broken" },
                    { 3, "Loren ipsum dotor sit arnet, consetetur sadipscing elitrividunt ut labore et dolore aaliquya erat,set diam voluptuaa vero eos et accusam et justo duo", "02/Jan/2021", "https://localhost:44309/ImageNews/Mask Group 2.png", "Keep Running" },
                    { 4, "Loren ipsum dotor sit arnet, consetetur sadipscing elitrividunt ut labore et dolore aaliquya erat,set diam voluptuaa vero eos et accusam et justo duo.", "02/Jan/2021", "https://localhost:44309/ImageNews/Mask Group -3.png", "Temperature above 37.3℃ need to report" },
                    { 5, "New Wellness Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo d ea rebum. gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet... consetetur sadip m ipsum dolor sit amet, consetetur sadim ipsum dolorsadi...", "02/Jan/2021", "https://localhost:44309/ImageNews/image_gallery.png", "Tomorrow Healthy Check" },
                    { 6, "Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo", "02/Jan/2021", "https://localhost:44309/ImageNews/image_gallery-1.png", "Air-conditioning is broken" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Announcement");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "Gallery");

            migrationBuilder.DropTable(
                name: "HowDo");

            migrationBuilder.DropTable(
                name: "News");
        }
    }
}
