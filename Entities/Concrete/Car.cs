using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int GearId { get; set; }
        public int FuelId { get; set; }
        public string CarName { get; set; }
        public string ModelYear { get; set; }
        public int DailyPrice { get; set; }
    }
}
