using PaymentProcessingFactoryPattern.Processors;

namespace PaymentProcessingFactoryPattern.ProcessorFactory
{
    public class AuthorizeNetFactory : ProcessPaymentFactory
    {
        public override IProcessPayment Create(CardTransactionData transactionData) => new ProcessorAuthorizeNet(transactionData);               
        
    }
}
