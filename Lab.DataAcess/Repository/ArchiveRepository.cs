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
    public class ArchiveRepository : Repository<Archive>, IArchiveRepository
    {
        private ApplicationDbContext _db;
        public ArchiveRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
       
        public void Update(Archive obj)
        {
            _db.Archives.Update(obj);
        }
    }
}
