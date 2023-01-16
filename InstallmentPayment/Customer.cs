using System;
using System.Collections.Generic;
using System.Text;

namespace InstallmentPayment
{
    internal class Customer
    {
        public static string Name { get; set; }
        public string Address { get; set; }
        public static double AmountToPay { get; set; }
        public static double FirstDeposit { get; set; }
        public static double AmountRemaining { get; set; }

        public Customer(string name, double amountToPay)
        {
            Name = name;
            AmountToPay = amountToPay;
            FirstDeposit = amountToPay / 10;
            AmountRemaining = amountToPay - FirstDeposit;
        }

        public static void DailyPlan()
        {
            double dailyAmt = 0;

            dailyAmt = (AmountRemaining / 7);

            Console.WriteLine($"{Name}'s Payment information\n\nTotal amount to pay: N{AmountToPay}\nCollect first deposit: N{FirstDeposit}\n\n" +
                $"Remaining payment: {AmountRemaining}\nDaily payment: {dailyAmt}\nDuration (7 days)");
        }

        public static void WeeklyPlan()
        {
            double weeklyAmt;
            weeklyAmt = AmountRemaining / 4;

            Console.WriteLine($"{Name}'s Payment information\n\nTotal amount to pay: N{AmountToPay}\nCollect first deposit: N{FirstDeposit}\n\n" +
                $"Remaining payment: {AmountRemaining}\nWeekly payment: {weeklyAmt}\nDuration (4 weeks)");
        }
    }
}
