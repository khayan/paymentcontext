using Flunt.Validations;
using PaymentContext.Domain.Enums;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Document : ValueObject
    {
        public Document(string number, EDocumentType type)
        {
            Number = number;
            Type = type;

            AddNotifications(new Contract()
                .Requires()
                .IsTrue(Validate(), "Document.Number", "Documento Inválido")
            );
        }

        private bool Validate()
        {
            if (Type == EDocumentType.CNPJ && Number.Length == 14)
            {
                return true;
            }

            if (Type == EDocumentType.CPF && Number.Length == 11)
            {
                return true;
            }

            // Implementar método de validação de CNPJ e CPF via cálculo
            // Ver regra de negócio no site da receita federal

            return false;
        }

        public string Number { get; private set; }
        public EDocumentType Type { get; private set; }
    }
}