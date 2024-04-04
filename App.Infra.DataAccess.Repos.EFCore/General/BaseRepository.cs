using App.Domain.Core.General.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.DataAccess.Repos.EFCore.General
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context;

        public BaseRepository(DbContext context)
        {
            _context = _context;
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
    }
}
