﻿using Project_1281647.Models;
using Project_1281647.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_C__Final.Tests
{
    public class DITest3
    {
        readonly IGenericRepository<Mobile> repo;
        public DITest3(IGenericRepository<Mobile> repo) { this.repo = repo; }
        public void Run()
        {
            Console.WriteLine("Mobile Phones");
            Console.WriteLine("======Insert======");
           
            repo.Add(new Mobile { Id = 1, Category = "Smart Phone", Launch = "24 May-2024", Price = 55000 });
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
            var Mobile = repo.Get(2);
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
        }
    }
}
