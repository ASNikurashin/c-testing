using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Domain.Entities;
using WebApplication2.Domain.Repositories.Abstract;

namespace WebApplication2.Domain.Repositories.EntityFramework
{
    public class EFHeatRepository : IHeatRepository
    {
        private readonly AppDbContext context;
        public EFHeatRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Heat_work> GetHeats()
        {
            return context.Heat_Works;
        }

        public Heat_work GetHeatsById(int Id)
        {
            return context.Heat_Works.FirstOrDefault(x => x.Id == Id);
        }

        public void SaveHeat(Heat_work entity)
        {
            if (entity.Id== default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteHeat(int id)
        {
            context.Heat_Works.Remove(new Heat_work() { Id = id });
            context.SaveChanges();
        }


    }
}
