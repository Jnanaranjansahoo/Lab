using Lab.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lab.DataAcess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Officer> Officers { get; set; }
        public DbSet<Client> Clients { get; set; }
        
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Officer>().HasData(
                new Officer {
                    Id = 1,
                    Name = "Chiku",
                    Pnumb = 1,
                    Address = "Baragachha",
                    City = "Amba",
                    Dist = "tulasi",
                    Pincode = 566,
                    Aadhar = 4576,
                    Pancard="462gfsdg"
                },
                new Officer { Id = 2,
                    Name = "Chdiku",
                    Pnumb = 12,
                    Address = "Baragdsdachha",
                    City = "Amdba",
                    Dist = "tuldcasi",
                    Pincode = 566,
                    Aadhar = 45736,
                    Pancard = "46dt2gfsdg"
                }
                );

           


            modelBuilder.Entity<Client>().HasData(
                new Client
                {
                    Id = 1,
                    CName = "Fortune of Time",
                    Mobile = 123456789,
                    Dist = "SWD9999001",
                    Pos = "Pankapal",
                    Pin = 90,
                    LandMark = "Near bara gachha",
                    Total = 1399,
                    OfficerId = 1,
                    ImageUrl = ""
                },
                new Client
                {
                    Id = 2,
                    CName = "Fortune of Time",
                    Mobile = 123456789,
                    Dist = "SWD9999001",
                    Pos = "Pankapal",
                    Pin = 90,
                    LandMark = "Near bara gachha",
                    Total = 1399,
                    OfficerId = 2,
                    ImageUrl = ""
                },
                new Client
                {
                    Id = 3,
                    CName = "Fortune of Time",
                    Mobile = 123456789,
                    Dist = "SWD9999001",
                    Pos = "Pankapal",
                    Pin = 90,
                    LandMark = "Near bara gachha",
                    Total = 1399,
                    OfficerId = 1,
                    ImageUrl = ""

                },
                new Client
                {
                    Id = 4,
                    CName = "Fortune of Time",
                    Mobile = 123456789,
                    Dist = "SWD9999001",
                    Pos = "Pankapal",
                    Pin = 90,
                    LandMark = "Near bara gachha",
                    Total = 1399,
                    OfficerId = 2,
                    ImageUrl = ""
                },
                new Client
                {
                    Id = 5,
                    CName = "Fortune of Time",
                    Mobile = 123456789,
                    Dist = "SWD9999001",
                    Pos = "Pankapal",
                    Pin = 90,
                    LandMark = "Near bara gachha",
                    Total = 1399,
                    OfficerId = 1,
                    ImageUrl = ""
                },
                new Client
                {
                    Id = 6,
                    CName = "Fortune of Time",
                    Mobile = 123456789,
                    Dist = "SWD9999001",
                    Pos = "Pankapal",
                    Pin = 90,
                    LandMark = "Near bara gachha",
                    Total = 1399,
                    OfficerId = 2,
                    ImageUrl = ""
                }
                );
        }
    }
}
