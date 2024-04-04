using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.AccountAgg.Entities
{
    public class User
    {
        public User(string fullName, long nationalCode, string phoneNumber, string address)
        {
            FullName = fullName;
            NationalCode = nationalCode;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public int Id { get; private set; }
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
