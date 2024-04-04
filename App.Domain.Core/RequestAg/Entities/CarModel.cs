using App.Domain.Core.General.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.RequestAg.Entities
{
    public class CarModel : BaseEntity
    {
        public CarModel(string title)
        {
            Title = title;
        }

        public string Title { get; private set; }
        public List<Car> Cars { get; set; }

        void Edit(string title)
        {
            Title = title;
        }
    }
}
