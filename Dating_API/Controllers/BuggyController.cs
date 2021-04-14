using Dating_API.Data;
using Dating_API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Dating_API.Controllers
{
    public class BuggyController : BaseApiController
    {
        private readonly DataContext _dbContext;
        public BuggyController(DataContext dbContext)
        {
            _dbContext = dbContext;

        }

        [Authorize]
        [HttpGet("auth")]
        public ActionResult<string> GetUnauthError()
        {
            return "This is a secret text.";
        }

        [HttpGet("not-found")]
        public ActionResult<AppUser> GetNotFound()
        {
            var user = _dbContext.Users.Find(-1);
            if(user == null) return NotFound();
            return user;
        }
        [HttpGet("server-error")]
        public ActionResult<string> GetServerError()
        {
            var thisUser = _dbContext.Users.Find(-1);
            var thisUserString = thisUser.ToString();

            return thisUserString;

        }
        [HttpGet("bad-request")]
        public ActionResult<string> GetBadRequest()
        {
            return BadRequest("this is not a good request.");
        }
    }
}