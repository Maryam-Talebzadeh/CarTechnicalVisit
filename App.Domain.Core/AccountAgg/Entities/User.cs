using App.Domain.Core.General.Entities;
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
        }

        public string FullName { get; private set; }
        public long NationalCode { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Address { get; private set; }

        void Edit(string fullName, long nationalCode, string phoneNumber, string address)
        {
            FullName = fullName;
            NationalCode = nationalCode;
            PhoneNumber = phoneNumber;
            Address = address;
        }

    }
}
