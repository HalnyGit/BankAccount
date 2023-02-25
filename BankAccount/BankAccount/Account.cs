using System.Diagnostics;
using System.IO;


namespace BankAccount
{

	public class Account : AccountBase
	{
        public Account(string accountID)
            : base(accountID)
		{
            if (!CheckFileExists(FileName))
			{
                using (FileStream fs = File.Create(FileName));
                Console.WriteLine($"Utworzono nowy rachunek nr: {this.AccountID}");
            }
		}

        private string FileName
        {
            get
            {
                return this.AccountID + ".txt";
            }              
         }

        private static bool CheckFileExists(string fileName)
		{
			return File.Exists(fileName);
		}

        public override void AddCashflow(float cashflow)
        {
            using (var writer = File.AppendText(FileName))
            {
                writer.WriteLine(cashflow);

                //if (GradeAdded != null)
                //{
                //    GradeAdded(this, new EventArgs());
                //}
            }
        }

        public override void AddCashflow(string cashflow)
        {
            if (float.TryParse(cashflow, out float result))
            {
                this.AddCashflow(result);
            }
            else
            {
                throw new Exception("Wprowadzona wartość musi być liczbą");
            }
        }

        public override void AddCashflow(double grade)
        {
            float result = (float)grade;
            this.AddCashflow(result);
        }

        public override void AddCashflow(decimal grade)
        {
            float result = (float)grade;
            this.AddCashflow(result);
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            using (var reader = File.OpenText(FileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var amount = float.Parse(line);
                        statistics.AddCashflow(amount);
                        line = reader.ReadLine();
                    }
                }
            return statistics;
        }



    }
}
