using Acme.BookStore.Books;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp;

namespace Acme.BookStore.Controllers
{
    [RemoteService]
    [Route("api/customBook")]
    public class CustomBookController : BookStoreController
    {
        private readonly ICustomBookAppService _appService;

        public CustomBookController(ICustomBookAppService appService)
        {
            _appService = appService;
        }

        [HttpGet("{name}")]
        public async Task<BookDto> GetBookByName(string name)
        {
            return await _appService.GetBookByNameAsync(name);
        }
    }
}
