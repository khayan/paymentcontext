using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Address : ValueObject
    {
        public Address(string street, string number, string neighborhood, string city, string state, string country, string zipCode)
        {
            Street = street;
            Number = number;
            Neighborhood = neighborhood;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLengthIfNotNullOrEmpty(Street, 10, "Address.Street", "Logradouro deve conter pelo menos 10 caracteres.")
                .HasMinLengthIfNotNullOrEmpty(Number, 1, "Address.Number", "Número deve conter pelo menos 1 caractere.")
                .HasMinLengthIfNotNullOrEmpty(Neighborhood, 5, "Address.Neighborhood", "Bairro deve conter pelo menos 5 caracteres.")
                .HasMinLengthIfNotNullOrEmpty(City, 5, "Address.City", "Cidade deve conter pelo menos 5 caracteres.")
                .HasExactLengthIfNotNullOrEmpty(State, 2, "Address.State", "Estado deve conter apenas 2 caracteres.")
                .HasMinLengthIfNotNullOrEmpty(Country, 5, "Address.Country", "País deve conter pelo menos 5 caracteres.")
                .HasExactLengthIfNotNullOrEmpty(ZipCode, 8, "Address.ZipCode", "CEP deve conter 8 caracteres.")
            );
        }

        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Neighborhood { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        public string ZipCode { get; private set; }
    }
}