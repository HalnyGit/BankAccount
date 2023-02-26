namespace BankAccount
{
    public class Statistics
    {
        private List<float> cashflows = new List<float>();

        public float Saldo { get; private set; }

        public float SumCashIn
        {
            get
            {
                float sumCashIn = 0;
                foreach (var flow in cashflows)
                {
                    if(flow >= 0) { sumCashIn += flow; }
                }
            return sumCashIn;
            }
        }

        public float SumCashOut
        {
            get
            {
                float sumCashOut = 0;
                foreach (var flow in cashflows)
                {
                    if (flow < 0) { sumCashOut += flow; }
                }
                return sumCashOut;
            }
        }

        public string Scorring
        {
            get
            {
                switch (this.Saldo)
                {
                    case var saldo when saldo >= 100000:
                        return "Premium";
                    case var saldo when saldo >= 0:
                        return "Standard";
                    default:
                        return "Debet!";
                }
            }
        }

        public Statistics()
        {
            this.Saldo = 0;
        }

        public void AddCashflow(float cashflow)
        {
            cashflows.Add(cashflow);
            this.Saldo = cashflows.Sum();
        }
    }
}
