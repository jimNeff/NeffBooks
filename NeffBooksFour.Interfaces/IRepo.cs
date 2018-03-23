using NeffBooksFour.Data;
using System.Linq;
using System.Threading.Tasks;

namespace NeffBooksFour.Interfaces
{
    public interface IRepo<T>
    {
        IQueryable<BOOK> List();
        bool Create(T item);
        T GetById(int id);
        bool Delete(int id);
        bool SaveChanges(T item);
    }
}
