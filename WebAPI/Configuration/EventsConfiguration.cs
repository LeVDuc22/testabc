using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace WebAPI.Configuration
{
    public class EventsConfiguration:IEntityTypeConfiguration<Events>
    {
        public EventsConfiguration()
        {

        }
        public void Configure(EntityTypeBuilder<Events> builder)
        {

            builder.ToTable("Event").HasKey(e => e.id);
            builder.Property(e => e.id).HasColumnName(@"Id")
               .UseIdentityColumn();
            builder.Property(e => e.eventName)
              .HasColumnName(@"Event Name");
            builder.Property(e => e.date)
            .HasColumnName("Date");
            builder.Property(e => e.startTime)
            .HasColumnName("Start Time")
            .HasConversion<string>();
            builder.Property(e => e.endTime)
            .HasColumnName("End Time")
             .HasConversion<string>();
            builder.HasData(
                new Events()
                {
                    id = 1,
                    eventName = "Register Portal",
                    date = "01 Jun",
                    startTime = new TimeSpan(9, 0, 0),
                    endTime = new TimeSpan(9, 30, 0)
                },
                 new Events()
                 {
                     id = 2,
                     eventName = "IT Maintenance",
                     date = "01 Jun",
                     startTime = new TimeSpan(9, 0, 0),
                     endTime = new TimeSpan(9, 30, 0)
                 },
                 new Events()
                 {
                     id = 3,
                     eventName = "IT Maintenance",
                     date = "01 Jun",
                     startTime = new TimeSpan(9, 0, 0),
                     endTime = new TimeSpan(9, 30, 0)
                 },
                new Events()
                {
                    id = 4,
                    eventName = "IT Maintenance",
                    date = "01 Jun",
                    startTime = new TimeSpan(9, 0, 0),
                    endTime = new TimeSpan(9, 30, 0)
                }
            );
        }
    }
}