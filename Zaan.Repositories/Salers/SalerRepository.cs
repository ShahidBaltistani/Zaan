using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zaan.Models;
using Zaan.Models.Model;

namespace Zaan.Repositories.Salers
{
    public class SalerRepository : ISalerRepository
    {
        private readonly ZaanContext db;
        public SalerRepository(ZaanContext _db)
        {
         this.db=_db;
        }

        public async Task<Saler> Delete(Saler model)
        {
               var data = db.Saler.Remove(model);
                await db.SaveChangesAsync();
                return model;
        }

        public async Task<List<Saler>> GetAll()
        {
            return  db.Saler.Where(x=>x.IsActive).ToList();
        }

        public async Task<Saler> GetById(int Id)
        {
            return  db.Saler.Where(x=>x.Id == Id && x.IsActive).FirstOrDefault();
        }

        public void Update(Saler model)
        {
            if (model != null)
            {
                var saler = GetById(model.Id);
                db.Entry(saler).State =EntityState.Modified;
                 db.SaveChanges();

            }
        }  
        
        public void Add(Saler model)
        {
            if (model != null)
            {
                db.Saler.Add(model);
                 db.SaveChanges();
            }
        }

    }
}
