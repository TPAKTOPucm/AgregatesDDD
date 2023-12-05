using System.ComponentModel.DataAnnotations;

namespace AgregatesDDD.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public CardType CardType { get; set; }
        public PaymentType PaymentType { get; set; }
    }

    public enum CardType
    {
        Mir = 0,
        Visa = 1,
        MasterCard = 2
    }

    public enum PaymentType
    {
        Cash = 0,
        Card = 1,
        Online = 2,
        SBP = 3
    }
}
