using Project_1281647.Factories;
using Project_1281647.Models;
using Project_1281647.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1281647.Tests
{
    public class DITest1
    {
        readonly IRepositoryFactory factory;
        public DITest1(IRepositoryFactory factory)
        {
            this.factory = factory;
        }
        public void Run() 
        {
            Console.WriteLine("Mobile Phones");
            Console.WriteLine("======Insert======");
            IGenericRepository<Mobile> repo = this.factory.GetRepo<Mobile>();
            repo.Add(new Mobile { Id = 1,Category= "Smart Phone", Launch="24 May-2024",Price=55000 });
            repo.AddRange(new Mobile[]
            {
                new Mobile{Id=2,Category="Feature Phone",Launch="15 June-2018",Price=3500},
                new Mobile{Id=3,Category="Smart Phone",Launch="25 December-2023",Price=27000}
            });
            repo.Get()
            .ToList()
            .ForEach(b => Console.WriteLine($"Id: {b.Id},Category: {b.Category},Launch: {b.Launch},Price: {b.Price}"));
            Console.WriteLine();
            //Update
            Console.WriteLine("======Update======");
            var Mobile=repo.Get(2);
            Mobile.Price = 4000;
            repo.Update(Mobile);
            repo.Get()
            .ToList()
            .ForEach(b => Console.WriteLine($"Id: {b.Id},Category: {b.Category},Launch: {b.Launch},Price: {b.Price}"));
            Console.WriteLine();
            //Delete
            Console.WriteLine("=======Delete=======");
            repo.Delete(2);
            repo.Get()
            .ToList()
            .ForEach(b => Console.WriteLine($"Id: {b.Id},Category: {b.Category},Launch: {b.Launch},Price: {b.Price}"));
            Console.WriteLine();
            Console.WriteLine("Companies");
            Console.WriteLine("======Insert======");
            IGenericRepository<Company> repoc = factory.GetRepo<Company>();
            repoc.Add(new Company { Id = 1, CompanyName = "Realme", Contact = "015XXXXXXXX", Email = "realme@gmail.com" });
            repoc.AddRange(new Company[]
            {
                new Company { Id=2,CompanyName="Xiami",Contact="01658XXXXX",Email="xiami@gmail.com"},
                new Company { Id=3,CompanyName="Vivo",Contact="017586XXXXX",Email="vivo@gamil.com"}
            });
            repoc.Get()
                .ToList()
                .ForEach(c => Console.WriteLine($"Id: {c.Id},Company Name: {c.CompanyName},Contact: {c.Contact},Email: {c.Email}"));
            Console.WriteLine();
            //Update
            Console.WriteLine("========Update=======");
            var Company = repoc.Get(2);
            Company.Email = "mi1254@gmail.com";
            repoc.Update(Company);
            repoc.Get()
                .ToList()
                .ForEach(c => Console.WriteLine($"Id: {c.Id},Company Name: {c.CompanyName},Contact: {c.Contact},Email: {c.Email}"));
            Console.WriteLine();
            //Delete
            Console.WriteLine("========Delete=======");
            repoc.Delete(3);
            repoc.Get()
                .ToList()
                .ForEach(c => Console.WriteLine($"Id: {c.Id},Company Name: {c.CompanyName},Contact: {c.Contact},Email: {c.Email}"));
        }
        
    }
}
