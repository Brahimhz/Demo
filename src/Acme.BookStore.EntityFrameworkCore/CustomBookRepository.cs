using Acme.BookStore.Books;
using Acme.BookStore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Acme.BookStore
{
    public class CustomBookRepository : EfCoreRepository<BookStoreDbContext, Book, Guid>, ICustomBookRepository
    {


        public CustomBookRepository(IDbContextProvider<BookStoreDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        public async Task<Book> GetBookByName(string name)
        {
            return await DbSet.SingleOrDefaultAsync(b => b.Name == name);
        }


    }
}
