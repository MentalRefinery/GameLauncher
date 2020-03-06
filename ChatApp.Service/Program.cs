using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLauncher.Contract;
using System.ServiceModel;

namespace ChatApp.Service
{

    class Program
    {
        static void Main(string[] args)
        {
            var uris = new Uri[1];
            string adress = "net.tcp://localhost:6565/MessageService";
            uris[0] = new Uri(adress);
            IMessageService service = new MessageService();
            ServiceHost host = new ServiceHost(service, uris);
        }
    }
}
