global using NUnit.Framework;

namespace BankAccount.Tests
{
    public class Tests
    {
        [Test]
        public void CheckAccountID()
        {
            var account = new Account("IBAN493067");

            Assert.That("IBAN493067", Is.EqualTo(account.AccountID));
        }
    }
}