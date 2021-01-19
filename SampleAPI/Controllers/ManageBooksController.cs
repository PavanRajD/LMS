using Microsoft.AspNetCore.Mvc;
using SampleAPI.Models;

namespace SampleAPI.Controllers
{
    [ApiController]
    [Route("api/books/manage")]
    public class ManageBooksController : ControllerBase
    {
        public ManageBooksController()
        {
        }

        [Route("add")]
        public bool AddBook([FromBody] book book)
        {
            return true;
        }

        [Route("{bookId}/update")]
        public bool UpdateBook(int bookId, [FromBody] book book)
        {
            return true;
        }

        [Route("{bookId}/delete")]
        public bool DeleteBook(int bookId)
        {
            return true;
        }
    }
}
