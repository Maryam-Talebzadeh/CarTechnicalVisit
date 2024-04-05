using App.Domain.Core.RequestAg.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.RequestAg.Services
{
    public interface IRequestService
    {
        void Add(RequestDTO command);
        List<RequestDTO> GetAll();
        void Accept(int id);
        void Reject(int id);
    }
}
