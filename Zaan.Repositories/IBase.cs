using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaan.Repositories
{
    public interface IBase<T> 
    { 
         Task  Add(T model);
        Task Update(T model);
        Task<T> GetById(int Id);
        Task<bool> Delete(int Id);
        Task<List<T>> GetAll();
    }
}
