using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public delegate void PaymentProcessorDelegate(decimal amount);

    public static class PaymentStrategies
    {
        public static void CreditCardPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment for {amount}");
        }

        public static void PayPalPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment for {amount}");
        }

        public static void BankTransferPayment(decimal amount)
        {
            Console.WriteLine($"Processing bank transfer payment for {amount}");
        }
    }

   

}
