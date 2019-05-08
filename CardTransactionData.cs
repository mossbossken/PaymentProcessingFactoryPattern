namespace PaymentProcessingFactoryPattern
{
    public class CardTransactionData
    {
        public PaymentTypes ProcessorType { get; set; }
        public string CardNumber { get; set; }
        public string MonthExpiration { get; set; }
        public string YearExpiration { get; set; }
        public decimal TransactionAmount { get; set; }
        public string SecurityCode { get; set; }

    }
}
