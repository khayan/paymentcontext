using System;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;

public class CreditCardPayment : Payment
    {
    public CreditCardPayment(
        string cardHolderName,
        string cardNumber,
        string lastTransactionNumber,
        DateTime paidDate,
        DateTime expireDate,
        decimal total,
        decimal totalPaid,
        string payer,
        Email email,
        Document document,
        Address address) : base (
            paidDate,
            expireDate,
            total,
            totalPaid,
            payer,
            email,
            document,
            address)
    {
        CardHolderName = cardHolderName;
        CardNumber = cardNumber;
        LastTransactionNumber = lastTransactionNumber;
    }

    public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public string LastTransactionNumber { get; set; }
    }