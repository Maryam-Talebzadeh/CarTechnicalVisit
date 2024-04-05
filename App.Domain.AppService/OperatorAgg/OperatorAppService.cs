using App.Domain.Core;
using App.Domain.Core.OperatorAgg.AppServices;
using App.Domain.Core.OperatorAgg.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppService.OperatorAgg
{
    public class OperatorAppService : IOperatorAppService
    {

        private readonly IOperatorAppService _operatorAppService;

        public OperatorAppService(IOperatorAppService operatorAppService)
        {
            _operatorAppService = operatorAppService;
        }

        public OperationResult Login(int personalId, string password)
        {
            return _operatorAppService.Login(personalId, password);
        }
    }
}
