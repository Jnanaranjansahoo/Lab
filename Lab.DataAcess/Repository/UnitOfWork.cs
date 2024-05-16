using Lab.DataAcess.Data;
using Lab.DataAcess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.DataAcess.Repository
{
    public class UnitOfWork : IUnitOfWork 
    {
        private ApplicationDbContext _db;
        public IOfficerRepository Officer { get; private set; }
        
        public IClientRepository Client { get; private set; }
        public IArchiveRepository Archive { get; private set; }
        public IAppointmentRepository Appointment { get; private set; }
        public IApplicationUserRepository ApplicationUser { get; private set; }
        public UnitOfWork(ApplicationDbContext db) 
        {
            _db = db;
            Officer = new OfficerRepository(_db);
            Client = new ClientRepository(_db);
            Archive = new ArchiveRepository(_db);
            Appointment = new AppointmentRepository(_db);
            ApplicationUser = new ApplicationUserRepository(_db);
           
        }
        

        public void Save()
        {
            _db.SaveChanges();

        }
              
    }
}
