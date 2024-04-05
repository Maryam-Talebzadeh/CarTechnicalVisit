using App.Domain.Core.RequestAg.Data;
using App.Domain.Core.RequestAg.DTOs;
using App.Domain.Core.RequestAg.Services;

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

        private OperationResult DailyRequestPermission()
        {
            var today = (DateTime.Now).Month;

            if(Utilities.IsEven(today))
            {

            }
        }
    }
}
