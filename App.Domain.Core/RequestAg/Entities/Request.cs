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
        }

        public DateTime CreationDate { get; set; }
        public int UserId { get; set; }
        public int CarId { get; set; }
    }
}
