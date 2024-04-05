using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.RequestAg.DTOs
{
    public class RequestDTO
    {
        public string OwnerFullName { get;  set; }
        public long OwnerNationalCode { get;  set; }
        public string OwnerPhoneNumber { get; set; }
        public string OwnerAddress { get;  set; }
        public int NumberPlate { get; private set; }
        public Int16 ProductionYear { get; private set; }
        public int ModelId { get; private set; }
    }
}
