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
    public class RequestRepository : BaseRepository<Request> ,IRequestRepository
    {
        private readonly CarTechnicalVisitContext _context;
        public RequestRepository(CarTechnicalVisitContext context) : base(context)
        {
            _context = context;
        }
    }
}
