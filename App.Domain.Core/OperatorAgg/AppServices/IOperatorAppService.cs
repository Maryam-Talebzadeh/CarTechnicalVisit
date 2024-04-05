using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.OperatorAgg.AppServices
{
    public interface IOperatorAppService
    {
        OperationResult Login(int personalId, string password);
    }
}
