namespace PaymentProcessingFactoryPattern
{
    public abstract class ProcessPaymentFactory
    {
        public abstract IProcessPayment Create(CardTransactionData transactionData);
    }
}
