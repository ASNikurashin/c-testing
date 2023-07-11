using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Domain.Entities;
using WebApplication2.Domain.Repositories.Abstract;

namespace WebApplication2.Domain.Repositories.EntityFramework
{
    public class EFShiftEnRepository : IShiftEnRepository
    {
        private readonly AppDbContext context;
        public EFShiftEnRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<ShiftEn> GetShiftEn()
        {
            return context.ShiftEns;
        }

        public ShiftEn GetShiftEnById(int id)
        {
            return context.ShiftEns.FirstOrDefault(x => x.Id == id);
        }

        public void SaveShiftEn(ShiftEn entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteShiftEns(int id)
        {
            context.ShiftEns.Remove(new ShiftEn() { Id = id });
            context.SaveChanges();
        }
    }
}
