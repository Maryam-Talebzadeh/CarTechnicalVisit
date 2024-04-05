using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.OperatorAgg.Services
{
    public interface IOperatorService
    {
        OperationResult Login(int personalId, string password);
    }
}
