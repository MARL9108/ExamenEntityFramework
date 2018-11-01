﻿using PizzeriaEntityFrameWork.Models;
using PizzeriaEntityFrameWork.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace PizzeriaEntityFrameWork.Infrastructure
{
    class PizzaRespository: DbContext,IPizzaRepository
    {
        private IPizzeriaContext _context;
        public PizzaRespository(IPizzeriaContext context)
        {
            this._context = context;
        }
        public void Add(Pizza entity)
        {
            _context.Pizza.Add(entity);
        }
        public void Delete(Pizza entity)
        {
            _context.Pizza.Remove(entity);
        }
        public void Update(Pizza entity)
        {
            var result = _context.Pizza.SingleOrDefault(x=>x.PizzaId==entity.PizzaId);
            
        }
    }
}
