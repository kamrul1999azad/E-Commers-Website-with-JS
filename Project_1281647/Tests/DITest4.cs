using Project_1281647.Models;
using Project_1281647.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_C__Final.Tests
{
    public class DITest4
    {
        readonly IGenericRepository<Company> repo;
        public DITest4(IGenericRepository<Company> repo)
        {
            this.repo = repo;
        }
        public void Run()
        {
            Console.WriteLine("Companies");
            Console.WriteLine("======Insert======");
            
            repo.Add(new Company { Id = 1, CompanyName = "Realme", Contact = "015XXXXXXXX", Email = "realme@gmail.com" });
            repo.AddRange(new Company[]
            {
                new Company { Id=2,CompanyName="Xiami",Contact="01658XXXXX",Email="xiami@gmail.com"},
                new Company { Id=3,CompanyName="Vivo",Contact="017586XXXXX",Email="vivo@gamil.com"}
            });
            repo.Get()
                .ToList()
                .ForEach(c => Console.WriteLine($"Id: {c.Id},Company Name: {c.CompanyName},Contact: {c.Contact},Email: {c.Email}"));
            Console.WriteLine();
            //Update
            Console.WriteLine("========Update=======");
            var Company = repo.Get(2);
            Company.Email = "mi1254@gmail.com";
            repo.Update(Company);
            repo.Get()
                .ToList()
                .ForEach(c => Console.WriteLine($"Id: {c.Id},Company Name: {c.CompanyName},Contact: {c.Contact},Email: {c.Email}"));
            Console.WriteLine();
            //Delete
            Console.WriteLine("========Delete=======");
            repo.Delete(3);
            repo.Get()
                .ToList()
                .ForEach(c => Console.WriteLine($"Id: {c.Id},Company Name: {c.CompanyName},Contact: {c.Contact},Email: {c.Email}"));
        }
    }
}
