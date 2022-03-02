using LibraryProject.Domain.Entities;
using LibraryProject.Repositories.Interfaces;
using System.Threading.Tasks;

namespace LibraryProject.Repositories.Interfaces
{
    public interface IBookReservationRepository : IRepositoryBase<BookReservationEntity>
    {
        Task<BookReservationEntity> GetByBookId(int id);
    }
}
