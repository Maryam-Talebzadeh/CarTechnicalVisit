using App.Domain.Core;
using App.Domain.Core.OperatorAgg.Data;
using App.Domain.Core.OperatorAgg.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.OperatorAgg
{
    public class OperatorService : IOperatorService
    {
        private readonly IOperatorRepository _operatorRepository;

        public OperatorService(IOperatorRepository operatorRepository)
        {
            _operatorRepository= operatorRepository;
        }

        public OperationResult Login(int personalId, string password)
        {
            var result = new OperationResult();

            if (_operatorRepository.Login(personalId, password))
                return result.Succedded("با موفقیت وارد شدید.");

            return result.Failed("اطلاعات ورودی درست نمیباشد");
        }
    }
}
