using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace FormsFrameworkClientApp
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    internal class ServerClass: InterfaceServer
    {
        ServiceHost webService;                                     // Represents the service
        public bool sendsToServer(string message)
        {
            Console.WriteLine(message);
            return true;
        }
        public string getServerString()
        {
            return "Message from server to client.";
        }

        public ServerClass(string url)
        {
            Uri uri = new Uri(url);
            Console.WriteLine("Initializing Web service...");
            webService = new ServiceHost(this,uri);
            // Finds server metadata.
            ServiceMetadataBehavior metadataBehavior = webService.Description.Behaviors.Find<ServiceMetadataBehavior>();
            if (metadataBehavior is null)
            {
                metadataBehavior = new ServiceMetadataBehavior();
            }
            metadataBehavior.HttpGetEnabled = true;
            metadataBehavior.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
            webService.Description.Behaviors.Add(metadataBehavior);
            webService.AddServiceEndpoint(ServiceMetadataBehavior.MexContractName, MetadataExchangeBindings.CreateMexHttpBinding(),"mex");
            ServiceEndpoint sendpoint = webService.AddServiceEndpoint(typeof(InterfaceServer), new BasicHttpBinding(), uri);
            webService.Open();
            Console.WriteLine("Server initialized in: "+url);
        }
    }
}
