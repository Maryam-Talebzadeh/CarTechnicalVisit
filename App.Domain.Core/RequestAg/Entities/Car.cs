using App.Domain.Core.General.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.RequestAg.Entities
{
    public class Car : BaseEntity
    {
        public Car(int numberPlate, Int16 productionYear, int modelId)
        {
            NumberPlate = numberPlate;
            ProductionYear = productionYear;
            ModelId = modelId;
        }

        public int NumberPlate { get;private set; }
        public Int16 ProductionYear { get; private set; }
        public int ModelId { get; private set; }

        void Edit(int numberPlate, Int16 productionYear, int modelId)
        {
            NumberPlate = numberPlate;
            ProductionYear = productionYear;
            ModelId = modelId;
        }
    }
}
