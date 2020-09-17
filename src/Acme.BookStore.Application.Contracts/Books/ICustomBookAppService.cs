using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Books
{
    public interface ICustomBookAppService : IApplicationService
    {
        Task<BookDto> GetBookByNameAsync(string name);
    }
}
