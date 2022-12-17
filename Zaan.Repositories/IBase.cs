using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaan.Repositories
{
    public interface IBase<T> 
    {
        void Add(T model);
        void Update(T model);
        Task<T> GetById(int Id);
        Task<T> Delete(T model);
        Task<List<T>> GetAll();
    }
}
