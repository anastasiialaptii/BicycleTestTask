using DAL.BicycleDbContext;
using DAL.Entities;
using DAL.Interfaces;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class BicycleUnitOfWork : IUnitOfWork
    {
        private readonly BicycleContext _dbContext;

        private BicycleRepository productRepository;

        public BicycleUnitOfWork(BicycleContext context)
        {
            _dbContext = context;
        }

        public IRepository<Bicycle> Bicycles
        {
            get
            {
                if (productRepository == null)
                    productRepository = new BicycleRepository(_dbContext);
                return productRepository;
            }
        }

        public async Task Save()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
