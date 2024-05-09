using Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.DataAcess.Repository.IRepository
{
    public interface IClientRepository : IRepository<Client>
    {
        void Update(Client obj);
    }
}
