﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Fuel:IEntity
    {
        public int FuelId { get; set; }
        public string FuelName { get; set; }
    }
}
