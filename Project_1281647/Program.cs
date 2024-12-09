using Project_C__Final.Tests;
using Project_1281647.Factories;
using Project_1281647.Models;
using Project_1281647.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1281647
{
    internal class Program
    {
        static void Main()
        {
            var factory = new RepositoryFactoryImpl();
            DITest1 di1 = new DITest1(factory);
            di1.Run();
            Console.WriteLine();
           
            DITest2 di2 = new DITest2();
            di2.Run(factory);

            DITest3 di3 = new DITest3(factory.GetRepo<Mobile>());
            di3.Run();

            DITest4 di4 = new DITest4(factory.GetRepo<Company>());
            di4.Run();

            DITest5 di5 = new DITest5();
            di5.RunMobileRepoTest(factory.GetRepo<Mobile>());
            di5.RunCompanyRepoTest(factory.GetRepo<Company>());
            Console.ReadLine();
        }
    }
}
