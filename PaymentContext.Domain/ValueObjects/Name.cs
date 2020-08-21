using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            // Fail Fast Validations | Implementado em Commands
            // AddNotifications(new Contract()
            //     .Requires()
            //     .HasMinLengthIfNotNullOrEmpty(FirstName, 3, "Name.FirstName", "Nome precisa ter pelo menos 3 caracteres.")
            //     .HasMinLengthIfNotNullOrEmpty(LastName, 3, "Name.LastName", "Sobrenome precisa ter pelo menos 3 caracteres.")
            // );
            
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}