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
    public class RequestConfiguration : IEntityTypeConfiguration<Request>
    {
        public void Configure(EntityTypeBuilder<Request> builder)
        {

            #region Relations

            builder.HasOne(r => r.User).WithMany(u => u.Requests).HasForeignKey(r => r.UserId);
            builder.HasOne(r => r.Car).WithOne(c => c.Requset).HasForeignKey<Request>(r => r.CarId);
            builder.HasOne(r => r.Status).WithMany(s => s.Requests).HasForeignKey(r => r.StatusId);

            #endregion
        }
    }
}
