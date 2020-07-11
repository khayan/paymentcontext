using System;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;

public class PayPalPayment : Payment
    {
    public PayPalPayment(
        string transactionCode,
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
        TransactionCode = transactionCode;
    }

    public string TransactionCode { get; set; }
    }