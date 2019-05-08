using PaymentProcessingFactoryPattern.ProcessorFactory;
using System.Collections;
using System.Collections.Generic;

namespace PaymentProcessingFactoryPattern
{
    public class ProcessPayment
    {
        private readonly Dictionary<PaymentTypes, ProcessPaymentFactory> _paymentFactories;

        public ProcessPayment()
        {
            _paymentFactories = new Dictionary<PaymentTypes, ProcessPaymentFactory>
            {
                {PaymentTypes.AuthorizeNet, new AuthorizeNetFactory() },
                {PaymentTypes.PayPal, new PayPalFactory() }
            };
        }

        public IProcessPayment ExecuteProcessor(PaymentTypes paymentTypes, CardTransactionData transactionData) => _paymentFactories[paymentTypes].Create(transactionData);

    }
}
