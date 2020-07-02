using DAL.Entities;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Bicycle> Bicycles { get; }

        Task Save();
    }
}
