using App.Domain.Core.General.Entities;
using App.Domain.Core.RequestAg.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.General.Data
{
    public interface IRepository<T> where T : BaseEntity
    {
        int Create(T entity);
        List<T> GetAll();
        T GetBy(int id);
        void Save();
    }
}
