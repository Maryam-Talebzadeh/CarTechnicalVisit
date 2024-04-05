using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.OperatorAgg.Entities
{
    public class Operator
    {
        public Operator(string fullName )
        {
            FullName = fullName;
        }

        public int Id { get;private set; }
        public string FullName { get; private set; }
        public int PersonalId { get; set; }
        public string Password { get; set; }
    }
}
