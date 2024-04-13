using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSolidRefactoringStarterSolution.OCP.Solution
{
    public static class FeeCalculatorSystem
    {
        public static void Flow()
        {
            IPaymentType visa = new Visa();
            IPaymentType masterCard = new Mastercard();
            Console.WriteLine(visa.GetTransactionFee(2500));
            Console.WriteLine(masterCard.GetTransactionFee(2500));
        }
    }

    public interface IPaymentType
    {
        decimal GetTransactionFee(decimal amount);
    }

    public class Visa : IPaymentType
    {
        public decimal GetTransactionFee(decimal amount)
        {
            return amount * 0.4m;
        }
    }

    public class Mastercard : IPaymentType
    {
        public decimal GetTransactionFee(decimal amount)
        {
            return amount * 0.5m;
        }
    }
}
