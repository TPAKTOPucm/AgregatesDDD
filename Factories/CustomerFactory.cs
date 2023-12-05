using AgregatesDDD.DTOs;
using AgregatesDDD.Models;

namespace AgregatesDDD.Factories
{
    public class CustomerFactory
    {
        private static int id = 0;
        public static Customer CreateCustomer(int id, string firstName, string lastName, CardType cardType, PaymentType paymentType) => new()
        {
            Id = id,
            FirstName = firstName,
            LastName = lastName,
            CardType = cardType,
            PaymentType = paymentType
        };
        public static Customer CreateCustomer(string firstName, string lastName, CardType cardType, PaymentType paymentType) => CreateCustomer(id++, firstName, lastName, cardType, paymentType);
        public static Customer CreateCustomer(CustomerDTO dto) => CreateCustomer(dto.FirstName, dto.LastName, dto.CardType, dto.PaymentType);
        public static Customer CreateCustomer(int id, CustomerDTO dto) => CreateCustomer(id, dto.FirstName, dto.LastName, dto.CardType, dto.PaymentType);
    }
}
