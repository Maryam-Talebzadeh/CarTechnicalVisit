using App.Domain.Core.OperatorAgg.Data;
using App.Infra.DB.SqlServer.EFCore.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.DataAccess.Repos.EFCore.OperatorAgg
{
    public class OperatorRepository : IOperatorRepository
    {
        private readonly CarTechnicalVisitContext _context;

        public OperatorRepository(CarTechnicalVisitContext context)
        {
            _context = context;
        }
        public bool Login(int personalId, string password)
        {
            return _context.Operators.Any(o => o.PersonalId == personalId &&  o.Password == password);
        }
    }
}
