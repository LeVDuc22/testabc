using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAPI.Models;

namespace WebAPI.Configuration
{
    public class HowDoConfiguration:IEntityTypeConfiguration<HowDoI>
    {
      
    public void Configure(EntityTypeBuilder<HowDoI> builder)
        {
            builder.ToTable("HowDo").HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("Id").UseIdentityColumn();
            builder.Property(e => e.question).HasColumnName("Question");
            builder.Property(e => e.anser).HasColumnName("Anser");
            builder.HasData(
                new HowDoI()
                {
                    Id =1,
                    question= "Lorem ipsum dolor sit amet",
                    anser= "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut aliqubore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut ip ex.",
                },
                new HowDoI()
                {
                    Id =2,
                    question= "Lorem ipsum dolor sit amet",
                    anser= "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut aliqubore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut ip ex.",
                },
                new HowDoI()
                {
                     Id = 3,
                     question = "Lorem ipsum dolor sit amet",
                     anser = "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut aliqubore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut ip ex.",
                },
                new HowDoI()
                {
                     Id = 4,
                     question = "Lorem ipsum dolor sit amet",
                     anser = "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut aliqubore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut ip ex.",
                }
                );
        }
    }
}
