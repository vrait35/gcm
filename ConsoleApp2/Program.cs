using Microsoft.ServiceFabric.Services.Remoting;
using ServiceReference1;
using System;
using System.Net;
using System.ServiceModel;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var url = "http://HPSMAPP2.ikomekastana.kz:9000/SM/7/ws";
            var req = new CreateGcmServiceDeskSARequest
            {
                attachmentData = true,
                attachmentDataSpecified = true,
                attachmentInfo = true,
                attachmentInfoSpecified = true,
                ignoreEmptyElements = false,
                updateconstraint = 1,
                model = new GcmServiceDeskSAModelType
                {
                    instance = new GcmServiceDeskSAInstanceType
                    {
                        Status = new StringType
                        {
                            type = "asd",
                            Value = "dsf",
                            mandatory = true
                        },
                        attachments = new AttachmentType[]
                    {
                           new AttachmentType
                           {
                               action="post",
                               attachmentType="application/pdf",
                               contentType="application/pdf",
                               name="anuar",
                               type="file"
                           }
                    },
                        query = "query",
                        Phone = new StringType
                        {
                            Value = "+77478426289",
                            type = "samsung"
                        },
                    },
                    keys = new GcmServiceDeskSAKeysType
                    {
                        incidentid = new StringType { type = "sd", Value = "122f" },
                        query = "query",
                        updatecounter = 111,
                        updatecounterSpecified = true
                    },
                    messages = new MessageType[] { new MessageType { type = "type1", Value = "val22" } },
                    query = "qqquery"
                }
            };
            var binding = new BasicHttpBinding();
            binding.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
            //binding.CloseTimeout = TimeSpan.FromSeconds(30);
            binding.MaxBufferPoolSize = 1000000000;
            binding.MaxReceivedMessageSize = 1000000000;
            binding.SendTimeout = TimeSpan.FromMinutes(3);
            binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
            var _client = new GcmServiceDeskSAClient(binding, new EndpointAddress(url));
            _client.ClientCredentials.UserName.UserName = "AsmartAstana";
            _client.ClientCredentials.UserName.Password = "gucCaY2$";
            var res = await _client.CreateGcmServiceDeskSAAsync(req);
        }
    }
}
