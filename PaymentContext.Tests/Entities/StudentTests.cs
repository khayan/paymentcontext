using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void AddSubscription()
        {
            var name = new Name("Khayan", "Malantrucco");
            foreach (var not in name.Notifications)
            {
                // not.Property;
                // not.Message;
            }
        }
    }
}