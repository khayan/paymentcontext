using System;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;

public class BoletoPayment : Payment
    {
    public BoletoPayment(
        string barCode,
        string boletoNumber,
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
        BarCode = barCode;
        BoletoNumber = boletoNumber;
    }

    public string BarCode { get; set; }
        public string BoletoNumber { get; set; }        
    }