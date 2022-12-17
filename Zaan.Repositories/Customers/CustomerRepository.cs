using Microsoft.EntityFrameworkCore;
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

        public async Task<Customer> Delete(Customer model)
        {
               var data = db.Customers.Remove(model);
                await db.SaveChangesAsync();
                return model;
        }

        public async Task<List<Customer>> GetAll()
        {
            return  db.Customers.Where(x=>x.IsActive).ToList();
        }

        public async Task<Customer> GetById(int Id)
        {
            return  db.Customers.Where(x=>x.Id == Id && x.IsActive).FirstOrDefault();
        }

        public void Update(Customer model)
        {
            if (model != null)
            {
                var customer = GetById(model.Id);
                db.Entry(customer).State =EntityState.Modified;
                 db.SaveChanges();

            }
        }  
        
        public void Add(Customer model)
        {
            if (model != null)
            {
                db.Customers.Add(model);
                 db.SaveChanges();
            }
        }

        public Task test()
        {
            throw new NotImplementedException();
        }

    }
}
