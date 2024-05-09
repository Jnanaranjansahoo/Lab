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
        public DbSet<Appointment> Appointments { get; set; }
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


              
            //modelBuilder.Entity<Appointment>().HasData(
            //   new Appointment { Id = 1,
            //                 CuName = "Chiku", 
            //                 CMobile = 1,
            //                 CLandMark = "Baragachha",
            //                 CPos = "Amba",
            //                 CDist = "tulasi",
            //                 CPin = 566,
            //                 ApplicaationUserId = "62"

            //   },
            //   new Appointment { Id = 2,
            //                 CuName = "Chdiku", 
            //                 CMobile = 12,
            //                 CLandMark = "Baragdsdachha",
            //                 CPos = "Amdba",
            //                 CDist = "tuldcasi",
            //                 CPin = 566,
            //                 ApplicaationUserId = "32"

            //   },
            //   new Appointment { Id = 3,
            //                 CuName = "Chdfiku", 
            //                 CMobile = 132,
            //                 CLandMark = "Baragaachha",
            //                 CPos = "Adxcmba",
            //                 CDist = "tusxdlasi",
            //                 CPin = 56236,
            //                 ApplicaationUserId = "43"

            //   });



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
