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
    public class ClientRepository : Repository<Client>, IClientRepository
    {
        private ApplicationDbContext _db;
        public ClientRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Client obj)
        {
            var objFromDb = _db.Clients.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.CName = obj.CName;
                objFromDb.Mobile = obj.Mobile;
                objFromDb.Dist = obj.Dist;
                objFromDb.Pos = obj.Pos;
                objFromDb.Pin = obj.Pin;
                objFromDb.OfficerId = obj.OfficerId;
                objFromDb.LandMark = obj.LandMark;
                if (obj.ImageUrl != null)
                {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }
            }
        }
    }
}
