using JsonService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Service Client = new Service();
            Console.WriteLine(Client.SayHi("Fatih ADAŞ"));
            Console.ReadLine();
            
        }
    }
}
