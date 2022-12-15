using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zaan.Models;
using Zaan.Models.Model;

namespace Zaan.Repositories.Customers
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ZaanContext db;
        public CustomerRepository(ZaanContext _db)
        {
         this.db=_db;
        }

        public async Task Add(Customer model)
        {
            db.Customers.AddAsync(model);
            db.SaveChangesAsync();
        }

        public async Task<bool> Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Customer>> GetAll()
        {
            return db.Customers.Where(x=>x.IsActive).ToList();
        }

        public async Task<Customer> GetById(int Id)
        {
            return db.Customers.Where(x=>x.Id == Id && x.IsActive).FirstOrDefault();
        }

        public async Task Update(Customer model)
        {
            throw new NotImplementedException();
        }
    }
}
