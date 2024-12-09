using Project_1281647.Models;
using Project_1281647.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1281647.Factories
{
    internal class RepositoryFactoryImpl : IRepositoryFactory
    {
        public IGenericRepository<T> GetRepo<T>() where T : EntityBase, new()
        {
            return new GenericRepositoryImpl<T>();
        }
    }
}
