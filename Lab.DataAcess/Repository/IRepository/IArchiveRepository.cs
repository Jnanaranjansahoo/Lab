﻿using Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.DataAcess.Repository.IRepository
{
    public interface IArchiveRepository : IRepository<Archive>
    {
        void Update(Archive obj);
    }
}
