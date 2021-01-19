using Microsoft.AspNetCore.Mvc;
using SampleAPI.Models;

namespace SampleAPI.Controllers
{
    [ApiController]
    [Route("api/users/manage")]
    public class ManageUserController : ControllerBase
    {
        public ManageUserController()
        {
        }

        [Route("add")]
        public bool AddUser([FromBody] User user)
        {
            return true;
        }

        [Route("{userId}/update")]
        public bool UpdateUser(int userId, [FromBody] User user)
        {
            return true;
        }

        [Route("{userId}/delete")]
        public bool DeleteUser(int userId)
        {
            return true;
        }
    }
}
