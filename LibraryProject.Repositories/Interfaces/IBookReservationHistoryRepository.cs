using LibraryProject.Domain.Entities;
using LibraryProject.Repositories.Interfaces;
using System.Threading.Tasks;

namespace LibraryProject.Repositories.Interfaces
{
    public interface IBookReservationHistoryRepository : IRepositoryBase<BookReservationHistoryEntity>
    {
    }
}
