using LibraryProject.Data;
using LibraryProject.Domain.Entities;
using LibraryProject.Repositories.Interfaces;

namespace LibraryProject.Repositories.Contracts
{
    public class BookRepository : RepositoryBase<BooksEntity>, IBookRepository
    {
        private readonly ApplicationContextDb _dbContext;
        public BookRepository(ApplicationContextDb dbContext)
        : base(dbContext)
        {
            _dbContext = dbContext;

        }

   
    }
}
