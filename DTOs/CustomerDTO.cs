using AgregatesDDD.Models;
using System.ComponentModel.DataAnnotations;

namespace AgregatesDDD.DTOs
{
    public class CustomerDTO
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public CardType CardType { get; set; }
        public PaymentType PaymentType { get; set; }
    }
}
