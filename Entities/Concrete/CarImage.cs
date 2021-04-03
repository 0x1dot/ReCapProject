using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class CarImage : IEntity
    {   
        [Key]
        public int CarImageId { get; set; }
        public int CarId { get; set; }
        public string ImagePath { get; set; }
        public DateTime? Date { get; set; }
    }
}
