using App.Domain.Core.General.Entities;
using App.Domain.Core.RequestAg.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.AccountAgg.Entities
{
    public class User : BaseEntity
    {
        public User(string fullName, long nationalCode, string phoneNumber, string address)
        {
            FullName = fullName;
            NationalCode = nationalCode;
            PhoneNumber = phoneNumber;
            Address = address;
            Cars = new List<Car>();
            Requests = new List<Request>();
        }

        public string FullName { get; private set; }
        public long NationalCode { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Address { get; private set; }
        public List<Car> Cars { get; set; }
        public List<Request> Requests { get; set; }

        void Edit(string fullName, long nationalCode, string phoneNumber, string address)
        {
            FullName = fullName;
            NationalCode = nationalCode;
            PhoneNumber = phoneNumber;
            Address = address;
        }

    }
}
