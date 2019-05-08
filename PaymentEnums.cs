namespace PaymentProcessingFactoryPattern
{
    public enum PaymentTypes
    {
        AuthorizeNet,
        PayPal,
        Stripe,
        Braintree,
        UsaEpay
    }

    public enum PaymentProcessingResults
    {
        NoStatus,
        Success,
        Declined,
        DataIncorrect
    }
}
