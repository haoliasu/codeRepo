using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFandEFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client serviceClient = new ServiceReference1.Service1Client();
            string result=serviceClient.GetData(1389);
            Console.WriteLine(result);
        }
    }
}
