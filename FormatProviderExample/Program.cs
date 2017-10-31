using System;

namespace FormatProviderExample
{
    public enum DaysOfWeek
    {
        Monday = 1,
        Tuesday = 2
    };

    class Program
    {
        static void Main(string[] args)
        {
            long acctNumber;
            double balance;
            DaysOfWeek wday;
            string output;

            acctNumber = 104254567890;
            balance = 16.34;
            wday = DaysOfWeek.Monday;

            output = String.Format(new AcctNumberFormat(),
                                   "On {2}, the balance of account {0:H} was {1:C2}.",
                                   acctNumber, balance, wday);
            Console.WriteLine(output);

            wday = DaysOfWeek.Tuesday;
            output = String.Format(new AcctNumberFormat(),
                                   "On {2}, the balance of account {0:I} was {1:C2}.",
                                   acctNumber, balance, wday);
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
