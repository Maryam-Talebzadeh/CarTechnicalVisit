using App.Domain.Core.AccountAgg.Entities;
using App.Domain.Core.RequestAg.Entities;
using App.Infra.DB.SqlServer.EFCore.Configs.RequestAg;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.DB.SqlServer.EFCore.Contexts
{
    public class CarTechnicalVisitContext : DbContext
    {
        public CarTechnicalVisitContext(DbContextOptions<CarTechnicalVisitContext> options) : base(options)
        {
            
        }

        #region AccountAgg

        public DbSet<User> Users { get; set; }

        #endregion

        #region RequestAgg

        public DbSet<Request> Requests { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarModel> carModels { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(CarConfiguration).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
