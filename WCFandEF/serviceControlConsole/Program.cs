using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace serviceControlConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using(ServiceHost host=new ServiceHost(typeof(WCFandEF.Service1)))
            {
                //ServiceEndpoint serpoint=host.AddServiceEndpoint(typeof(WCFandEF.IService1),new BasicHttpBinding(),)
                host.Open();
                 Console.WriteLine("Started");
                 Console.ReadLine();


            }
            
        }
    }
}
