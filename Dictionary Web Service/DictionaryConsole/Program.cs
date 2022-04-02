using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Dictionary_Web_Service;

namespace DictionaryConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t2 = typeof(Dictionary_Web_Service.DictionaryService);
            Type t1 = typeof(Dictionary_Web_Service.AdminService);
            Uri http1 = new Uri("http://localhost:8734/Design_Time_Addresses/Dictionary_Web_Service/Admin1/");
            Uri http2 = new Uri("http://localhost:8734/Design_Time_Addresses/Dictionary_Web_Service/Dictionary1/");

            ServiceHost host1 = new ServiceHost(t1, http1);
            ServiceHost host2 = new ServiceHost(t2, http2);
            

            host1.Open();
            host2.Open();

            Console.WriteLine("publish");
            Console.ReadLine();
            host1.Close();
            host2.Close();
        }
    }
}
