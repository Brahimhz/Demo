using System.Threading.Tasks;

namespace Acme.BookStore.Books
{
    public class CustomBookAppService : BookStoreAppService, ICustomBookAppService
    {
        private readonly ICustomBookRepository _cBooksRepository;

        public CustomBookAppService(ICustomBookRepository cBooksRepository)
        {
            _cBooksRepository = cBooksRepository;

        }

        public async Task<BookDto> GetBookByNameAsync(string name)
        {
            return ObjectMapper.Map<Book, BookDto>(await _cBooksRepository.GetBookByName(name));
        }

    }
}
