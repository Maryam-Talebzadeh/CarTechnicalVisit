using App.Domain.Core.General.Data;
using App.Domain.Core.General.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.DataAccess.Repos.EFCore.General
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly DbContext _context;

        public BaseRepository(DbContext context)
        {
            _context = _context;
        }

        public int Create(T entity)
        {
            _context.Set<T>().Add(entity);
            return entity.Id;
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
    }
}
