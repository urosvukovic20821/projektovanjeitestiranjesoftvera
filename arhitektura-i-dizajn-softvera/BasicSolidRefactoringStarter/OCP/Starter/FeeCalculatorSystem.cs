using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSolidRefactoringStarterSolution.OCP.Starter
{
    public static class FeeCalculatorSystem
    {
        public static void Flow()
        {
            FeeCalculator fc = new FeeCalculator();
            Console.WriteLine(fc.GetTransactionFee(2500, PaymentType.Visa));
            Console.WriteLine(fc.GetTransactionFee(2500, PaymentType.Mastercard));
        }
    }

    public enum PaymentType
    {
        Visa,
        Mastercard
    }

    public class FeeCalculator
    {
        public decimal GetTransactionFee(decimal amount, PaymentType paymentType)
        {
            decimal transactionFee = 0;
            if (paymentType == PaymentType.Visa)
            {
                transactionFee = amount * 0.4m;
            }
            else if (paymentType == PaymentType.Mastercard)
            {
                transactionFee = amount * 0.5m;
            }
            return transactionFee;
        }
    }
}
