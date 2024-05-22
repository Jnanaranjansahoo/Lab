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
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Officer>().HasData(
                new Officer
                {
                    Id = 1,
                    Name = "Fortune ",
                    Mobile = 123456789,
                    Dist = "SWD9999001",
                    Pos = "Pankapal",
                    Pin = 90,
                    LandMark = "Near bara gachha"

                },
                new Officer
                {
                    Id = 2,
                    Name = "Time",
                    Mobile = 123456789,
                    Dist = "SWD9999001",
                    Pos = "Pankapal",
                    Pin = 90,
                    LandMark = "Near bara gachha"

                }
                );

            modelBuilder.Entity<Appointment>().HasData(
               new Appointment { Id = 1,
                             CuName = "Chiku", 
                             CMobile = 1,
                             CDist = "Baragachha",
                             CPos = "Amba",
                             CPin = 564,
                             CLandMark = "566"

               },
               new Appointment { Id = 2,
                             CuName = "Chdiku", 
                             CMobile = 12,
                             CDist = "Baragdsdachha",
                             CPos = "Amdba",
                             CPin = 42,
                             CLandMark = "566"

               },
               new Appointment { Id = 3,
                             CuName = "Chdfiku", 
                             CMobile = 132,
                             CDist = "Baragaachha",
                             CPos = "Adxcmba",
                             CPin = 45,
                             CLandMark = "56236"

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
