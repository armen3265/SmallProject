using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Host
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title="HOST";
            ServiceHost host = new ServiceHost(typeof(WcfServiceLibrary.Service));

            host.Open();
            Console.WriteLine("Host Runned!");


            Console.ReadLine();
        }
    }
}
