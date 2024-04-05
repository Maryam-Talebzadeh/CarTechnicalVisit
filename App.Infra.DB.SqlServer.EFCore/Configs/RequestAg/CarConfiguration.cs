using App.Domain.Core.RequestAg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.DB.SqlServer.EFCore.Configs.RequestAg
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            #region Relations

            builder.HasOne(c => c.Model).WithMany(m => m.Cars).HasForeignKey(c => c.ModelId);
            builder.HasOne(c => c.Manufacturer).WithMany(m => m.Cars).HasForeignKey(c => c.ManufacturerId);

            #endregion
        }
    }
}
