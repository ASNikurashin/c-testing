using System;
using System.Linq;
using WebApplication2.Domain.Entities;

namespace WebApplication2.Domain.Repositories.Abstract
{
    public interface IShiftEnRepository
    {
        IQueryable<ShiftEn> GetShiftEn();
        ShiftEn GetShiftEnById(int id);
        void SaveShiftEn(ShiftEn entity);
        void DeleteShiftEns(int id);
    }
}
