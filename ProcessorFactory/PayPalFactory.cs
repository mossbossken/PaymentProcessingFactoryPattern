using PaymentProcessingFactoryPattern.Processors;

namespace PaymentProcessingFactoryPattern.ProcessorFactory
{
    public class  PayPalFactory : ProcessPaymentFactory
    {
        public override IProcessPayment Create(CardTransactionData transactionData) => new ProcessorPayPal(transactionData);
    }
}
