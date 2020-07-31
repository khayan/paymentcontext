using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class DocumentTests
    {
        // Método: Red, Green, Refactor
        
        [TestMethod]
        public void ShouldReturnErrorWhenCNPJIsInvalid()
        {
            var doc = new Document("123", EDocumentType.CNPJ);
            
            //Assert.Fail(); //Red
            Assert.IsTrue(doc.Invalid); // Green
        }

        [TestMethod]
        public void ShouldReturnSuccessWhenCNPJIsValid()
        {
            var doc = new Document("07839602000186", EDocumentType.CNPJ);
            
            //Assert.Fail(); //Red
            Assert.IsTrue(doc.Valid); // Green
        }

        [TestMethod]
        public void ShouldReturnErrorWhenCPFIsInvalid()
        {
            var doc = new Document("123", EDocumentType.CPF);
            
            //Assert.Fail(); //Red
            Assert.IsTrue(doc.Invalid); // Green
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("67409138033")]
        [DataRow("04486445090")]
        [DataRow("24226266021")]
        public void ShouldReturnSuccessWhenCPFIsValid(string cpf)
        {
            var doc = new Document(cpf, EDocumentType.CPF);
            
            //Assert.Fail(); //Red
            Assert.IsTrue(doc.Valid); // Green
        }
    }
}