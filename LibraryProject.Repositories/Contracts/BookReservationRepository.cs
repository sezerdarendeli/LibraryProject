using LibraryProject.Data;
using LibraryProject.Domain.Entities;
using LibraryProject.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LibraryProject.Repositories.Contracts
{
    public class BookReservationRepository : RepositoryBase<BookReservationEntity>, IBookReservationRepository
    {
        private readonly ApplicationContextDb _dbContext;
        public BookReservationRepository(ApplicationContextDb dbContext)
        : base(dbContext)
        {
            _dbContext = dbContext;

        }

        public async Task<BookReservationEntity> GetByBookId(int id)
        {
            return await _dbContext.Set<BookReservationEntity>()
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.BookId == id);
        }


    }
}
