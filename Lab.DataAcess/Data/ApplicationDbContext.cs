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
        public DbSet<Company> Companies { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Officer>().HasData(
                new Officer { Id = 1, Name = "Male", Cost = 1 },
                new Officer { Id = 2, Name = "FeMale", Cost = 2 }
                );

            modelBuilder.Entity<Company>().HasData(
               new Company { Id = 1,
                             Name = "Chiku", 
                             Pnumb = 1,
                             Address = "Baragachha",
                             City = "Amba",
                             Dist = "tulasi",
                             Pincode = 566

               },
               new Company { Id = 2,
                             Name = "Chdiku", 
                             Pnumb = 12,
                             Address = "Baragdsdachha",
                             City = "Amdba",
                             Dist = "tuldcasi",
                             Pincode = 566

               },
               new Company { Id = 3,
                             Name = "Chdfiku", 
                             Pnumb = 132,
                             Address = "Baragaachha",
                             City = "Adxcmba",
                             Dist = "tusxdlasi",
                             Pincode = 56236

               });
              


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
