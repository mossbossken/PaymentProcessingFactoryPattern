using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcessingFactoryPattern.Processors
{
    public class ProcessorAuthorizeNet : IProcessPayment
    {
        private readonly CardTransactionData _cardTransactionData;

        public ProcessorAuthorizeNet(CardTransactionData CardTransactionData)
        {
            _cardTransactionData = CardTransactionData;
        }

        public PaymentProcessingResults ProcessPayment()
        {
            PaymentProcessingResults transactionResult;

            //Process Transaction
            Console.WriteLine("Processing Authorize.Net Payment Type");

            transactionResult = PaymentProcessingResults.Success;

            return transactionResult;
        }
    }
}
