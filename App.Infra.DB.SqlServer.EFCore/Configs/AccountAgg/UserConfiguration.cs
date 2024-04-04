using App.Domain.Core.AccountAgg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.DB.SqlServer.EFCore.Configs.AccountAgg
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(u => u.FullName).HasMaxLength(100).IsRequired();
            builder.Property(u => u.NationalCode).IsRequired();
            builder.Property(u => u.Address).HasMaxLength(500).IsRequired();

        }
    }
}
