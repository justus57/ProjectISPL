using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Web.Script.Serialization;

namespace Project1
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            WebService.WriteLog("Service Started");
            

            Timer timer = new Timer();
            timer.Interval = Convert.ToDouble(WebService.GetConfigData("ServiceTimerInterval"));
           timer.Elapsed += new System.Timers.ElapsedEventHandler(this._timer_Tick);
            timer.Enabled = true;
            timer.Start();
            WebService.GetServiceConstants();
        }



        private void _timer_Tick(object sender, ElapsedEventArgs e)
        {
            WebService.WriteLog("Running..");

            try
            {
                // triggers GetEntryToTransfer form Nav

                string dataToSend = WebService.ObjNav.GetEntryToTransfer();//returns JSON

                ///Deserialize JSON using NewtinSoft
                DetailsToTransfer detailsToTransfer = JsonConvert.DeserializeObject<DetailsToTransfer>(dataToSend);
                string SourceAmount = detailsToTransfer.SourceAmount;

                string DestinationAccountNo = detailsToTransfer.DestinationAccountNo;
                string DestinationBankCode = detailsToTransfer.DestinationBankCode;
                string Purpose = detailsToTransfer.Purpose;
                string MessageID = detailsToTransfer.MessageID;
                string SourceAccountName = detailsToTransfer.SourceAccountName;
                string SourceAccountNo = detailsToTransfer.SourceAccountNo;
                string SourcePhoneNo = detailsToTransfer.SourcePhoneNo;
                string RequestID = detailsToTransfer.RequestID;

                X509Certificate2 cert = new X509Certificate2(File.ReadAllBytes(@"bank0089_transport.cert.pfx"), "");

                 JavaScriptSerializer js = new JavaScriptSerializer();

                var creditTransferRequest = new CreditTransferRequest
                {
                    SourceAmount = SourceAmount,
                    DestinationAccountNo = DestinationAccountNo,
                    DestinationBankCode = DestinationBankCode,
                    MessageID = MessageID,
                    SourceAccountName = SourceAccountName,
                    SourcePhoneNo = SourcePhoneNo,
                    SourceAccountNo = SourceAccountNo,
                    RequestID = RequestID,
                    Purpose = Purpose

                };
                string rs = null;
                string jsonData = js.Serialize(creditTransferRequest);


                X509CertificateCollection clientCerts = new X509CertificateCollection();
                clientCerts.Add(cert);

                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

                WebService.WriteLog("Calling Api..");

                var client = new RestClient("https://0089.stage.pesalink.co.ke:4431/sync/v1/credit-transfer");
                client.Timeout = -1;
                client.ClientCertificates = clientCerts;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("application/json", jsonData, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                rs = response.Content;
                WebService.WriteLog(RequestID);

            }
            catch (Exception es)
            {
                WebService.WriteLog(es.Message);
                WebService.WriteLog(es.InnerException.ToString());
            }
            try
            { //triggers GetEntryToSeekStatus from Nav
                WebService.WriteLog("Calling GetEntryToSeekStatus...");
                string incomingdata = WebService.ObjNav.GetEntryToSeekStatus();
                RequestDetails detailsTransfer = JsonConvert.DeserializeObject<RequestDetails>(incomingdata);
                string MessageID = detailsTransfer.MessageID;
                string SourceAmount = detailsTransfer.SourceAmount;
                string SourceAccountNo = detailsTransfer.SourceAccountNo;
                string SourceAccountName = detailsTransfer.SourceAccountName;
                string SourcePhoneNo = detailsTransfer.SourcePhoneNo;
                string DestinationAccountNo = detailsTransfer.DestinationAccountNo;
                string DestinationBankCode = detailsTransfer.DestinationBankCode;
                string Purpose = detailsTransfer.Purpose;

                X509Certificate2 cert = new X509Certificate2(File.ReadAllBytes(@"bank0089_transport.cert.pfx"), "");

                 JavaScriptSerializer js = new JavaScriptSerializer();

                var PaymentstatusrequestRequest = new PaymentstatusrequestRequest
                {

                    MessageID = MessageID,
                    SourceAmount = SourceAmount,
                    SourceAccountNo = SourceAccountNo,
                    SourceAccountName = SourceAccountName,
                    SourcePhoneNo = SourcePhoneNo,
                    DestinationAccountNo = DestinationAccountNo,
                    DestinationBankCode= DestinationBankCode,
                    Purpose = Purpose

                };



                string rss = null;
                string jsonData = js.Serialize(PaymentstatusrequestRequest);


                X509CertificateCollection clientCerts = new X509CertificateCollection();
                clientCerts.Add(cert);

                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

                WebService.WriteLog("Calling Api to getentry...");

                var client = new RestClient("https://0089.stage.pesalink.co.ke:4431/sync/v1/payment-status-request");
                client.Timeout = -1;
                client.ClientCertificates = clientCerts;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("application/json", jsonData, ParameterType.RequestBody);
                IRestResponse response1 = client.Execute(request);
                rss = response1.Content;

                WebService.WriteLog(MessageID);

            }
            catch (Exception es)
            {
                WebService.WriteLog(es.Message);
                WebService.WriteLog(es.InnerException.ToString());
            }
            try
            { //triggers GetEntryToSeekDepositStatus from Nav
                WebService.WriteLog("Calling GetEntryToSeekDepositStatus...");
                string incomingdata = WebService.ObjNav.GetEntryToSeekDepositStatus();
                Depositstatus detailsTransfer = JsonConvert.DeserializeObject<Depositstatus>(incomingdata);
                string MessageID = detailsTransfer.SourceReferenceNo;
                string SourceAmount = detailsTransfer.AmountToTransfer;
                string SourceAccountNo = detailsTransfer.SourceAccountNo;
                string SourceAccountName = detailsTransfer.SourceAccountName;
                string SourceBankCode = detailsTransfer.SourceBankCode;
                string SourcePhoneNo = detailsTransfer.SourcePhoneNo;
                string DestinationAccountNo = detailsTransfer.DestinationAccountNo;
                string DestinationBankCode = "0089";
                

                X509Certificate2 cert = new X509Certificate2(File.ReadAllBytes(@"bank0089_transport.cert.pfx"), "");

                JavaScriptSerializer js = new JavaScriptSerializer();

                var DepositPaymentStatusRequest = new DepositPaymentStatusRequest
                {

                    SourceReferenceNo = MessageID,
                    AmountToTransfer = SourceAmount,
                    SourceAccountNo = SourceAccountNo,
                    SourceAccountName = SourceAccountName,
                    SourcePhoneNo = SourcePhoneNo,
                    DestinationAccountNo = DestinationAccountNo,
                    SourceBankCode = SourceBankCode



                };



                string rss = null;
                string jsonData = js.Serialize(DepositPaymentStatusRequest);


                X509CertificateCollection clientCerts = new X509CertificateCollection();
                clientCerts.Add(cert);

                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

                WebService.WriteLog("Calling Api to getDepositystatus...");

                var client = new RestClient("https://0089.stage.pesalink.co.ke:4431/sync/v1/payment-status-request-Deposit");
                client.Timeout = -1;
                client.ClientCertificates = clientCerts;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("application/json", jsonData, ParameterType.RequestBody);
                IRestResponse response1 = client.Execute(request);
                rss = response1.Content;

                WebService.WriteLog(MessageID);

            }
            catch (Exception es)
            {
                WebService.WriteLog(es.Message);
                WebService.WriteLog(es.InnerException.ToString());
            }
            try
            {  // triggers PostPESALinkDeposits
                WebService.WriteLog("Calling PostPESALinkDeposits...");
                string incomingdata = WebService.ObjNav.PostPESALinkDeposits();
            }
            catch (Exception es)
            {
                WebService.WriteLog(es.Message);
                WebService.WriteLog(es.InnerException.ToString());
            }
            try
            {
                string EventtId = "PING";
                string Eventparameters = "PING";
                X509Certificate2 cert = new X509Certificate2(File.ReadAllBytes(@"bank0089_transport.cert.pfx"), "");

                JavaScriptSerializer js = new JavaScriptSerializer();

                var systemsNotification = new SystemsNotification
                {
                    EventID = EventtId,
                    EventParameters= Eventparameters

                };



                string rss = null;
                string jsonData = js.Serialize(systemsNotification);


                X509CertificateCollection clientCerts = new X509CertificateCollection();
                clientCerts.Add(cert);

                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

                WebService.WriteLog("Senting system notification");
                WebService.WriteLog(EventtId);

                var client = new RestClient("https://0089.stage.pesalink.co.ke:4431/sync/v1/systems-notification");
                client.Timeout = -1;
                client.ClientCertificates = clientCerts;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("application/json", jsonData, ParameterType.RequestBody);
                IRestResponse response1 = client.Execute(request);
                rss = response1.Content;


            }
            catch (Exception es)
            {
                WebService.WriteLog(es.Message);
                WebService.WriteLog(es.InnerException.ToString());
            }
        }
        private string GenerateOrderLineTransactionNumber(string requestId)
        {
            if (!string.IsNullOrWhiteSpace(requestId))
            {
                Random random = new Random(requestId.GetHashCode());

                int recordId = random.Next();

                Random rnd = new Random();

                int next = rnd.Next(99);

                return $"{recordId}{next}".PadRight(12, '0'); ;
            }
            return requestId;
        }

        protected override void OnStop()
        {
            WebService.WriteLog("Service Stopped");
        }
    }
}
