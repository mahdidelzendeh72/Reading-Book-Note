using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


public interface IPaymentStrategy
    {
        void ProcessPayment(decimal amount);
    }

    public class CreditCardPayment : IPaymentStrategy
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment for {amount}");
        }
    }

    public class PayPalPayment : IPaymentStrategy
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment for {amount}");
        }
    }

    public class BankTransferPayment : IPaymentStrategy
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing bank transfer payment for {amount}");
        }
    }

    public class PaymentProcessor
    {
        private readonly IPaymentStrategy _paymentStrategy;

        public PaymentProcessor(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void ProcessPayment(decimal amount)
        {
            _paymentStrategy.ProcessPayment(amount);
        }
    }


}
