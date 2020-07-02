using DAL.BicycleDbContext;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class BicycleRepository : IRepository<Bicycle>
    {
        private BicycleContext _dbContext;
        public BicycleRepository(BicycleContext context)
        {
            _dbContext = context;
        }

        public void Create(Bicycle item)
        {
            if (item != null)
            {
                _dbContext.Bicycles.Add(item);
            }
            else throw new ArgumentNullException();
        }

        public void Delete(Bicycle item)
        {
            throw new NotImplementedException();
        }

        public Task<Bicycle> FindItemAsync(Func<Bicycle, bool> item)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Bicycle>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Bicycle> GetIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public void Update(Bicycle item)
        {
            throw new NotImplementedException();
        }
    }
}
