using System;
using System.Collections.Generic;
using System.Linq;
using Core.Domain.Entities;
using Core.Domain.Interfaces;

namespace Infrastructure.Implementation
{
    public class BacklogRepository : IBacklogRepository
    {
        private readonly ApplicationDbContext context;
        public BacklogRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Backlogs> GetAll()
        {
            return context.Backlogs.ToList();
        }

        public Backlogs GetBy(int id)
        {
            return context.Backlogs.Where(x=>x.Id == id).FirstOrDefault();
        }

        public Backlogs Insert(Backlogs model)
        {
            model.ActionOn = DateTime.UtcNow;
            context.Backlogs.Add(model);

            context.SaveChanges();
            
            return model;
        }

        public Backlogs Update(Backlogs model)
        {
            context.Update(model);
            context.SaveChanges();
            return model;
        }
        
        public void Delete(int id)
        {
            var backlog = context.Backlogs.FirstOrDefault(x=>x.Id == id);
            context.Backlogs.Remove(backlog);
            context.SaveChanges();
        }
    }
}