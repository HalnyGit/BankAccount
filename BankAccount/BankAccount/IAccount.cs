using static BankAccount.AccountBase;
namespace BankAccount
{
    public interface IAccount
    {
        string AccountID { get; }

        void AddCashflow(float cashflow);
        void AddCashflow(string cashflow);

        void AddCashflow(double grade);

        void AddCashflow(decimal grade);

        event CashflowAddedDelegate CashflowAdded;

        Statistics GetStatistics();

    }
}
