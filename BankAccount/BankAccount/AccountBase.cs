namespace BankAccount
{
    public abstract class AccountBase
    {
        public AccountBase(string accountID)
        {
            this.AccountID = accountID;
        }


        public string AccountID { get; private set; }

        //public delegate void GradeAddedDelegate(object sender, EventArgs args);
        //public abstract event GradeAddedDelegate GradeAdded;

        public abstract void AddCashflow(float cashflow);

        public abstract void AddCashflow(string cashflow);

        public abstract void AddCashflow(double grade);

        public abstract void AddCashflow(decimal grade);

        public abstract Statistics GetStatistics();

    }
}
