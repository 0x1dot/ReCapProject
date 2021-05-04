using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class UserFindeksPoint : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int FindeksPoint { get; set; }
    }
}
