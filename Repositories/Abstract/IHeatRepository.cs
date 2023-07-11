using System;
using System.Linq;
using WebApplication2.Domain.Entities;

namespace WebApplication2.Domain.Repositories.Abstract
{
    public interface IHeatRepository
    {
        IQueryable<Heat_work> GetHeats();
        Heat_work GetHeatsById(int id);
        void SaveHeat(Heat_work entity);
        void DeleteHeat(int id);
    }
}
