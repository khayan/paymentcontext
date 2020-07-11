using System;
using PaymentContext.Domain.Entities;

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
        BarCode = barCode;
        BoletoNumber = boletoNumber;
    }

    public string BarCode { get; set; }
        public string BoletoNumber { get; set; }        
    }