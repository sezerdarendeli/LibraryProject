using LibraryProject.Data;
using LibraryProject.Domain.Entities;
using LibraryProject.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LibraryProject.Repositories.Contracts
{
    public class BookReservationHistoryRepository : RepositoryBase<BookReservationHistoryEntity>, IBookReservationHistoryRepository
    {
        private readonly ApplicationContextDb _dbContext;
        public BookReservationHistoryRepository(ApplicationContextDb dbContext)
        : base(dbContext)
        {
            _dbContext = dbContext;

        }

    

    }
}
