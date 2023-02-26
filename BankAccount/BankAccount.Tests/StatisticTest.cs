namespace BankAccount.Tests
{
    public class StatisticTest
    {

        [Test]
        public void CheckCashIn()
        {
            var random = new Random();
            int number = random.Next(1000, 9999);
            string acctNumber = number.ToString();
            var account = new Account(acctNumber);

            account.AddCashflow(50f);
            account.AddCashflow("-25");
            account.AddCashflow(100f);

            var stat = account.GetStatistics();

            Assert.That(stat.SumCashIn, Is.EqualTo(150));
        }

        [Test]
        public void CheckCashOut()
        {
            var random = new Random();
            int number = random.Next(1000, 9999);
            string acctNumber = number.ToString();
            var account = new Account(acctNumber);

            account.AddCashflow(50f);
            account.AddCashflow("-25");
            account.AddCashflow(100f);

            var stat = account.GetStatistics();

            Assert.That(stat.SumCashOut, Is.EqualTo(-25));
        }

        [Test]
        public void CheckSaldo()
        {
            var random = new Random();
            int number = random.Next(1000, 9999);
            string acctNumber = number.ToString();
            var account = new Account(acctNumber);

            account.AddCashflow(50.2f);
            account.AddCashflow("-25,2");
            account.AddCashflow(100f);

            var stat = account.GetStatistics();

            Assert.That(stat.Saldo, Is.EqualTo(125));
        }
    }
}
