using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Books
{
    public interface ICustomBookRepository : IRepository<Book, Guid>
    {
        Task<Book> GetBookByName(string name);
    }
}
