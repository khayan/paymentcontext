using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        private readonly Student _student;
        private readonly Subscription _subscription;
        private readonly Name _name;
        private readonly Document _document;
        private readonly Email _email;
        private readonly Address _address;

        public StudentTests()
        {
            _name = new Name("Peter", "Parker");
            _document = new Document("88623825020", EDocumentType.CPF);
            _email = new Email("spiderman@marvel.com");
            _address = new Address("Ingram Street", "20", "Queens", "New York", "NY", "US", "11365");
            _student = new Student(_name, _document, _email);
            _subscription = new Subscription(null);
        }

        [TestMethod]
        public void ShouldReturnErrorWhenHadActiveSubsciption()
        {
            var payment = new PayPalPayment(
                "123456789",
                DateTime.Now,
                DateTime.Now.AddDays(5),
                10,
                10,
                "S.H.I.E.L.D.",
                _email,
                _document,
                _address
            );
            
            _subscription.AddPayment(payment);
            _student.AddSubscription(_subscription);
            _student.AddSubscription(_subscription); // Forçando o erro!
            
            Assert.IsTrue(_student.Invalid); //Red
        }

        [TestMethod]
        public void ShouldReturnErrorWhenSubsciptionHasNoPayment()
        {
            _student.AddSubscription(_subscription);
            
            Assert.IsTrue(_student.Invalid); //Red
        }

        [TestMethod]
        public void ShouldReturnSuccessWhenAddSubsciption()
        {
            var payment = new PayPalPayment(
                "123456789",
                DateTime.Now,
                DateTime.Now.AddDays(5),
                10,
                10,
                "S.H.I.E.L.D.",
                _email,
                _document,
                _address
            );
            
            _subscription.AddPayment(payment);
            _student.AddSubscription(_subscription);
            
            Assert.IsTrue(_student.Valid); //Green
        }
    }
}