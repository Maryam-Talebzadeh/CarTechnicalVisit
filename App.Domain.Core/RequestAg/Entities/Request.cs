using App.Domain.Core.AccountAgg.Entities;
using App.Domain.Core.General.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.RequestAg.Entities
{
    public class Request : BaseEntity
    {
        public Request(int userId, int carId)
        {
            CreationDate = DateTime.Now;
            UserId = userId;
            CarId = carId;
            StatusId = 1; 
        }

        public DateTime CreationDate { get;private set; }
        public int UserId { get; private set; }
        public int CarId { get; private set; }
        public User User { get; private set; }
        public Car Car { get; private set; }
        public int StatusId { get;private set; }
        public Status Status { get; set; }

        void AcceptRequest()
        {
            StatusId = 2; //2 : Id for accepet
        }

        void RejectRequest()
        {
            StatusId = 4;   //4 : Id for reject
        }
    }
}
