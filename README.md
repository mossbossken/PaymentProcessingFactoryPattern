# Software Factory design pattern

## Please note I didn't create objects for all PaymentEnum types.

I could further refactor this to use reflection to load the factory classes so I don't have to add them every time we have a new payment type.

To test, add a console project, set it to startup, and then include the following code:

```
static void Main(string[] args)
        {
            ProcessPayment(PaymentTypes.AuthorizeNet);
            ProcessPayment(PaymentTypes.PayPal);

            Console.ReadLine();
        }

        static void ProcessPayment(PaymentTypes paymentType)
        {
            PaymentProcessingResults processingStatus; //will return the status of payment processing execution

            //**** NOTE: This data should NOT be hard coded here and be passed in, but it's an example and focused on factory pattern thus it's hard coded.
            CardTransactionData theCardData = new CardTransactionData(); //card transaction data to execute with processor vendor type
            theCardData.CardNumber = "1111000022229999";
            theCardData.MonthExpiration = "01";
            theCardData.YearExpiration = "21";
            theCardData.SecurityCode = "101";
            theCardData.TransactionAmount = 100.50m;
            theCardData.ProcessorType = paymentType;

            Console.WriteLine("Starting Processing...");

            //spin up the right factory class and get reference
            var processorFactory = new ProcessPayment().ExecuteProcessor(paymentType, theCardData);

            //execute processing attempt and return results
            processingStatus = processorFactory.ProcessPayment();

            Console.WriteLine($"The processing status is: {processingStatus}.");
            Console.WriteLine("===Finished Processing===");
            Console.WriteLine("");
            Console.WriteLine("");

           
        }
```
