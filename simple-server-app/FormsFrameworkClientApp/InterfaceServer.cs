using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace FormsFrameworkClientApp
{
    [ServiceContract]                   // Warranties it is a web service
    internal interface InterfaceServer
    {
        [OperationContract]
        bool sendsToServer(string message);
        [OperationContract]
        string getServerString();
    }
}
