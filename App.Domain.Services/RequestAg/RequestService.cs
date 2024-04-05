using App.Domain.Core;
using App.Domain.Core.AccountAgg.Data;
using App.Domain.Core.AccountAgg.Entities;
using App.Domain.Core.RequestAg.Data;
using App.Domain.Core.RequestAg.DTOs;
using App.Domain.Core.RequestAg.Entities;
using App.Domain.Core.RequestAg.Services;
using App.Domain.Services.Memory;

namespace App.Domain.Services.RequestAg
{
    public class RequestService : IRequestService
    {
        private readonly IRequestRepository _requestRepository;
        private readonly IUserRepository _userRepository;
        private readonly ICarRepository _carRepository;

        public RequestService(IRequestRepository requestRepository, IUserRepository userRepository, ICarRepository carRepository)
        {
            _requestRepository = requestRepository;
            _userRepository = userRepository;
            _carRepository = carRepository;
        }

        public void Accept(int id)
        {
           var request = _requestRepository.GetBy(id);
            request.AcceptRequest();
        }

        public OperationResult Add(CreateRequestDTO command)
        {
            var operationResult = new OperationResult();

            if(!ManufacturerPermission(command.ManufacturerId))
                {
                operationResult.Failed("این سیستم در روزهای زوج به ماشی نهای شرکت ایران خودرو و در روزهای فرد به ماشین های شرکت سایپا نوبت می دهد. لطفا روز دیگر امتحان کنید.");
                return operationResult;
            }

            if(!DailyRequestPermission())
            {
                operationResult.Failed("سقف درخواست ها برای امروز تمام شده. لطفا روز دیگر امتحان فرمایید.");
            }


            var user = new User(command.OwnerFullName, command.OwnerNationalCode,command.OwnerPhoneNumber, command.OwnerAddress);
            int userId = _userRepository.Create(user);
            _userRepository.Save();

            var car = new Car(command.NumberPlate, command.ProductionYear, command.ModelId, command.ManufacturerId);
            int carId = _carRepository.Create(car);
            _userRepository.Save();

            var request = new Request(userId, carId);
            _requestRepository.Create(request);

            return operationResult.Succedded();
        }

        public List<RequestDTO> GetAll()
        {
            var cars = _carRepository.GetAll();
            var users = _userRepository.GetAll();

            return _requestRepository.GetAll().Select(x => new RequestDTO()
            {
                Id = x.Id,
                ManufacturerId = cars.SingleOrDefault(c => c.Id == x.CarId).ManufacturerId,
                ModelId = cars.SingleOrDefault(c => c.Id == x.CarId).ModelId,
                NumberPlate = cars.SingleOrDefault(c => c.Id == x.CarId).NumberPlate,
                ProductionYear = cars.SingleOrDefault(c => c.Id == x.CarId).ProductionYear,
                OwnerFullName = users.SingleOrDefault(u => u.Id == x.UserId).FullName,
                OwnerAddress = users.SingleOrDefault(u => u.Id == x.UserId).Address,
                OwnerNationalCode = users.SingleOrDefault(u => u.Id == x.UserId).NationalCode,
                OwnerPhoneNumber = users.SingleOrDefault(u => u.Id == x.UserId).PhoneNumber
            }).ToList();
        }

        public void Reject(int id)
        {
            var request = _requestRepository.GetBy(id);
            request.RejectRequest();
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
