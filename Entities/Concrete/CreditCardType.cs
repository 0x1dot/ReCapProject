using Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    [Table("CreditCardType", Schema = "dbo")]
    public class CreditCardType : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string TypeName { get; set; }
    }
}