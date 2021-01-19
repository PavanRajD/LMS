using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SampleAPI.Controllers
{
    [ApiController]
    [Route("api/library/users/{userId}")]
    public class LibraryUserController : ControllerBase
    {
        public LibraryUserController()
        {
        }

        [Route("borrow/{bookId}")]
        public bool PostBorrowBook(int userId, int bookId)
        {
            return true;
        }

        [Route("return/{bookId}")]
        public bool PutReturnBook(int userId, int bookId)
        {
            return true;
        }

        [Route("logs")]
        public IEnumerable<string> GetUserLogs(int userId)
        {
            return new List<string>();
        }
    }
}
