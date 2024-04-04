using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.General.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            IsDeleted = false;
        }

        public int Id { get;private set; }
        public bool IsDeleted { get;private set; }
    }
}
