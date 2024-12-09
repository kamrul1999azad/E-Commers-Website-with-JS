using Project_1281647.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1281647.Repositories
{
    public interface IGenericRepository<T> where T :EntityBase,new()
    {
        IEnumerable<T> Get();
        T Get(int id);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Update(T entity);
        void Delete(int id);
    }
}
