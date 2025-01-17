﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.DataAcess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IOfficerRepository Officer { get; }
        IClientRepository Client { get; }
        ICompanyRepository Company { get; }
        void Save();
    }
}
