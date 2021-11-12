using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Project1
{
   public class Utilities
    {
        static X509Certificate2 cert = new X509Certificate2(File.ReadAllBytes(@"bank0089_transport.cert.pfx"), "");
        public string InitiateCreditTransfer(string SourceAmount, string DestinationAccountNo, string DestinationBankCode, string MessageID, string SourceAccountName, string SourceAccountNo, string Purpose)
        {

            JavaScriptSerializer js = new JavaScriptSerializer();

            var creditTransferRequest = new CreditTransferRequest
            {
                SourceAmount = SourceAmount,
                DestinationAccountNo = DestinationAccountNo,
                DestinationBankCode = DestinationBankCode,
                MessageID = MessageID,
                SourceAccountName = SourceAccountName,
                SourceAccountNo = SourceAccountNo,
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
            //    WebService.WriteLog(response.Content);
            //}
            //catch (Exception es)
            //{
            //    WebService.WriteLog(es.ToString());
            //    WebService.WriteLog(es.InnerException.ToString());


            //}
            return rs;
        }

    }
}
