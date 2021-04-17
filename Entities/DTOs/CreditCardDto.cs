using Core.Entities;

namespace Entities.DTOs
{
    public class CreditCardDto : IDto
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int CardTypeId { get; set; }
        public string CardTypeName { get; set; }
        public string CardNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ExpirationMonth { get; set; }
        public int ExpirationYear { get; set; }
        public int Cvv { get; set; }
    }
}
