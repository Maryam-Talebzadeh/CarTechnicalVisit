using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.OperatorAgg.Data
{
    public interface IOperatorRepository
    {
        bool Login(int personalId, string password);
    }
}
