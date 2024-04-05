using App.Infra.DataAccess.Repos.EFCore.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.AccountAgg.Data;
using App.Domain.Core.AccountAgg.Entities;
using App.Infra.DB.SqlServer.EFCore.Contexts;

namespace App.Infra.DataAccess.Repos.EFCore.AccountAgg
{
    public class UserRepository : BaseRepository<User>, IUserRepository 
    {
        public UserRepository(CarTechnicalVisitContext context) : base(context)
        {
            
        }
    }
}
