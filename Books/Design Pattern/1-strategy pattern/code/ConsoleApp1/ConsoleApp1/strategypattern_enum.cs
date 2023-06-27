using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{


public enum PaymentType
    {
        CreditCard,
        PayPal,
        BankTransfer
    }

  

    public class CreditCardPaymentStrategy : IPaymentStrategy
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment for {amount}");
        }
    }

    public class PayPalPaymentStrategy : IPaymentStrategy
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment for {amount}");
        }
    }

    public class BankTransferPaymentStrategy : IPaymentStrategy
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing bank transfer payment for {amount}");
        }
    }

    public class PaymentProcessor_enum
    {
        private IPaymentStrategy _paymentStrategy;

        public void SetPaymentStrategy(PaymentType paymentType)
        {
            switch (paymentType)
            {
                case PaymentType.CreditCard:
                    _paymentStrategy = new CreditCardPaymentStrategy();
                    break;
                case PaymentType.PayPal:
                    _paymentStrategy = new PayPalPaymentStrategy();
                    break;
                case PaymentType.BankTransfer:
                    _paymentStrategy = new BankTransferPaymentStrategy();
                    break;
                default:
                    throw new ArgumentException("Invalid payment type");
            }
        }

        public void ProcessPayment(decimal amount)
        {
            _paymentStrategy.ProcessPayment(amount);
        }
    }

   


}
