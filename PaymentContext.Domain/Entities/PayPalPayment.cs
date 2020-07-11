using System;
using PaymentContext.Domain.Entities;

public class PayPalPayment : Payment
    {
    public PayPalPayment(
        string transactionCode,
        DateTime paidDate,
        DateTime expireDate,
        decimal total,
        decimal totalPaid,
        string payer,
        string email,
        string document,
        string address) : base (
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