using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    [TestFixture]
    public class BankAccountNUnitTests
    {
        private BankAccount bankAccount;
        [SetUp]
        public void Steup()
        {
            bankAccount = new(new LogBook());
        }
        [Test]  
        public void BankDeposit_Add100_ReturnTrue()
        {
            var result = bankAccount.Deposit(100);
            Assert.IsTrue(result);
            Assert.That(bankAccount.GetBalance, Is.EqualTo(100));
        }

    }
}
