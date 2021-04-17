using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    [Table("CreditCard", Schema = "dbo")]
    public class CreditCard : IEntity
    {   
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int CardTypeId { get; set; }
        public string CardNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ExpirationMonth { get; set; }
        public int ExpirationYear { get; set; }
        public int Cvv { get; set; }
    }
}