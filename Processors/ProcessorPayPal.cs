using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcessingFactoryPattern.Processors
{
    public class ProcessorPayPal : IProcessPayment
    {
        private readonly CardTransactionData _cardTransactionData;

        public ProcessorPayPal(CardTransactionData CardTransactionData)
        {
            _cardTransactionData = CardTransactionData;
        }

        public PaymentProcessingResults ProcessPayment()
        {
            PaymentProcessingResults transactionResult;

            //Process Transaction for PayPal
            Console.WriteLine("Processing PayPal Payment Type");

            transactionResult = PaymentProcessingResults.Success;

            return transactionResult;
        }
    }
}
