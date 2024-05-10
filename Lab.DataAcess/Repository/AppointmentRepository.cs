using Lab.DataAcess.Data;
using Lab.DataAcess.Repository.IRepository;
using Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lab.DataAcess.Repository
{
    public class AppointmentRepository : Repository<Appointment>, IAppointmentRepository
    {
        private ApplicationDbContext _db;
        public AppointmentRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
       
        public void Update(Appointment obj)
        {
            _db.Appointments.Update(obj);
        }
    }
}
