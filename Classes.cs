using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Classes
    {
    }
    public class DetailsToTransfer
    {
        public string Status { get; set; }
        public string RequestID { get; set; }
        public string MessageID { get; set; }
        public string Description { get; set; }
        public string Purpose { get; set; }
        public string SourceAccountNo { get; set; }
        public string SourceAccountName { get; set; }
        public string SourcePhoneNo { get; set; }
        public string SourceAmount { get; set; }
        public string FeeAmount { get; set; }
        public string DestinationAccountNo { get; set; }
        public string DestinationBankCode { get; set; }
        public string DestinationMSISDN { get; set; }

    }


    public class CreditTransferRequest
    {
        public string Status { get; set; }
        public string RequestID { get; set; }
        public string MessageID { get; set; }
        public string Description { get; set; }
        public string Purpose { get; set; }
        public string SourceAccountNo { get; set; }
        public string SourceAccountName { get; set; }
        public string SourcePhoneNo { get; set; }
        public string SourceAmount { get; set; }
        public string FeeAmount { get; set; }
        public string DestinationAccountNo { get; set; }
        public string DestinationBankCode { get; set; }
        public string DestinationMSISDN { get; set; }
    }

    public class PaymentstatusrequestRequest
    {
        public string Status { get; set; }
        public string RequestID { get; set; }
        public string MessageID { get; set; }
        public string Description { get; set; }
        public string Purpose { get; set; }
        public string SourceAccountNo { get; set; }
        public string SourceAccountName { get; set; }
        public string SourcePhoneNo { get; set; }
        public string SourceAmount { get; set; }
        public string FeeAmount { get; set; }
        public string DestinationAccountNo { get; set; }
        public string DestinationBankCode { get; set; }
        public string DestinationMSISDN { get; set; }
    }

    public class RequestDetails
    {
        public string Status { get; set; }
        public string RequestID { get; set; }
        public string MessageID { get; set; }
        public string Description { get; set; }
        public string Purpose { get; set; }
        public string SourceAccountNo { get; set; }
        public string SourceAccountName { get; set; }
        public string SourcePhoneNo { get; set; }
        public string SourceAmount { get; set; }
        public string FeeAmount { get; set; }
        public string DestinationAccountNo { get; set; }
        public string DestinationBankCode { get; set; }
        public string DestinationMSISDN { get; set; }
    }

    public class Depositstatus
    {
        public string Status { get; set; }
        public string EntryNo { get; set; }
        public string SourceReferenceNo { get; set; }
        public string SourceBankCode { get; set; }
        public string SourceAccountNo { get; set; }
        public string SourceAccountName { get; set; }
        public string SourcePhoneNo { get; set; }
        public string AmountToTransfer { get; set; }
        public string DestinationAccountNo { get; set; }
    }
    public class DepositPaymentStatusRequest
    {
        public string Status { get; set; }
        public string EntryNo { get; set; }
        public string SourceReferenceNo { get; set; }
        public string SourceBankCode { get; set; }
        public string SourceAccountNo { get; set; }
        public string SourceAccountName { get; set; }
        public string SourcePhoneNo { get; set; }
        public string AmountToTransfer { get; set; }
        public string DestinationAccountNo { get; set; }
    }

    public class SystemsNotification
    {
        public string EventParameters{ get; set; }
        public string EventID { get; set; }
    }


}
