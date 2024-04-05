using App.Domain.Core.RequestAg.Data;
using App.Domain.Core.RequestAg.DTOs;
using App.Domain.Core.RequestAg.Services;
using App.Domain.Services.Memory;

namespace App.Domain.Services.RequestAg
{
    public class RequestService : IRequestService
    {
        private readonly IRequestRepository _requestRepository;

        public RequestService(IRequestRepository requestRepository)
        {
            _requestRepository = requestRepository;
        }

        public void Accept(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(RequestDTO command)
        {
            throw new NotImplementedException();
        }

        public List<RequestDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Reject(int id)
        {
            throw new NotImplementedException();
        }

        private bool DailyRequestPermission()
        {
            var today = (DateTime.Now).Month;

            if(Utilities.IsEven(today))
            {
                if (DailyRequests.Requests <= 10)
                    return true;

                return false;
            }

            if (DailyRequests.Requests <= 5)
                return true;

            return false;
        }

        private bool ManufacturerPermission(int ManufacturerId)
        {
            var today = (DateTime.Now).Month;

            if (ManufacturerId == 1)
            {
                if (Utilities.IsEven(today))
                    return false;
            }

            if (!Utilities.IsEven(today))
                return false;

            return true;
        }
    }
}
