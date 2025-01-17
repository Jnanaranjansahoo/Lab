﻿using Lab.DataAcess.Data;
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
        public ICompanyRepository Company { get; private set; }
        public IClientRepository Client { get; private set; }
        public UnitOfWork(ApplicationDbContext db) 
        {
            _db = db;
            Officer = new OfficerRepository(_db);
            Client = new ClientRepository(_db);
            Company = new CompanyRepository(_db);
        }
        

        public void Save()
        {
            _db.SaveChanges();

        }
    }
}
