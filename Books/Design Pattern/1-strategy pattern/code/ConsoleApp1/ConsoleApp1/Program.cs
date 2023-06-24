// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");
//------------  startegypattern_interface   ---------------------------------

//In this example, we define an IPaymentStrategy interface that defines the ProcessPayment method. We then create concrete implementations of this interface
//for each payment method(CreditCardPayment, PayPalPayment, and BankTransferPayment).Finally, we create a PaymentProcessor class that takes an IPaymentStrategy
//object as a parameter and uses it to process payments. This allows us to switch between different payment methods at runtime by simply passing in a different
//IPaymentStrategy object to the PaymentProcessor.
var creditCardPayment = new CreditCardPayment();
var paypalPayment = new PayPalPayment();
var bankTransferPayment = new BankTransferPayment();

var paymentProcessor = new PaymentProcessor(creditCardPayment);
paymentProcessor.ProcessPayment(100);  // Processing credit card payment for 100

paymentProcessor = new PaymentProcessor(paypalPayment);
paymentProcessor.ProcessPayment(200);  // Processing PayPal payment for 200

paymentProcessor = new PaymentProcessor(bankTransferPayment);
paymentProcessor.ProcessPayment(300);  // Processing bank transfer payment for 300
//------------------------------------------------------------------------------------------

//------------  strategypattern-delegate   ---------------------------------

//     In this example, we define a PaymentProcessor delegate that takes a decimal parameter and returns void. We then create static methods in
//     a PaymentStrategies class that implement the different payment methods.Finally, we assign the desired payment method to the paymentProcessor
//     delegate and call it with the appropriate amount.This allows us to switch between different payment methods at runtime by simply assigning
//     a different method to the paymentProcessor delegate.

PaymentProcessorDelegate paymentProcessor2 = PaymentStrategies.CreditCardPayment;
paymentProcessor2(100);  // Processing credit card payment for 100

paymentProcessor2 = PaymentStrategies.PayPalPayment;
paymentProcessor2(200);  // Processing PayPal payment for 200

paymentProcessor2 = PaymentStrategies.BankTransferPayment;
paymentProcessor2(300);  // Processing bank transfer payment for 300

//----------------------------------------------------------------
//------------  strategypattern_enum   ---------------------------------

//In this example, we define a PaymentType enum to represent the different payment types that we want to support.We then define an IPaymentStrategy interface
//that defines the ProcessPayment method that all payment strategies must implement.We then create three concrete payment
//strategy classes (CreditCardPaymentStrategy, PayPalPaymentStrategy, and BankTransferPaymentStrategy) that implement the IPaymentStrategy interface.
//In the PaymentProcessor class, we have a private field _paymentStrategy of type IPaymentStrategy.The SetPaymentStrategy method takes a PaymentType
//parameter and sets the value of _paymentStrategy to an instance of the appropriate payment strategy class based on the value of the PaymentType parameter.Finally,
//the ProcessPayment method calls the ProcessPayment method of the _paymentStrategy object with the appropriate amount.
//This allows us to switch between different payment types at runtime by simply calling the SetPaymentStrategy method with the desired PaymentType.
// Usage
PaymentProcessor_enum paymentProcessor3 = new PaymentProcessor_enum();

paymentProcessor3.SetPaymentStrategy(PaymentType.CreditCard);
paymentProcessor3.ProcessPayment(100);  // Processing credit card payment for 100

paymentProcessor3.SetPaymentStrategy(PaymentType.PayPal);
paymentProcessor3.ProcessPayment(200);  // Processing PayPal payment for 200

paymentProcessor3.SetPaymentStrategy(PaymentType.BankTransfer);
paymentProcessor3.ProcessPayment(300);  // Processing bank transfer payment for 300

