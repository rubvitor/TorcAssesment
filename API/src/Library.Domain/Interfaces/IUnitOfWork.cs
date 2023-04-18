using System.Threading.Tasks;

namespace Library.Domain.Interfaces;

public interface IUnitOfWork
{
    Task<bool> Commit();
}
