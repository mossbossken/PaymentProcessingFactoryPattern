using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcessingFactoryPattern
{
    public interface IProcessPayment
    {
        PaymentProcessingResults ProcessPayment(); 
    }
}
