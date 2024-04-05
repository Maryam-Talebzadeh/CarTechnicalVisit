using App.Domain.Core.AccountAgg.Data;
using App.Domain.Core.AccountAgg.Entities;
using App.Domain.Core.RequestAg.Data;
using App.Domain.Core.RequestAg.Entities;
using App.Infra.DataAccess.Repos.EFCore.General;
using App.Infra.DB.SqlServer.EFCore.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.DataAccess.Repos.EFCore.RequestAg
{
    public class CarRepository : BaseRepository<Car>, ICarRepository
    {
        public CarRepository(CarTechnicalVisitContext context) : base(context)
        {
            
        }
    }
}
