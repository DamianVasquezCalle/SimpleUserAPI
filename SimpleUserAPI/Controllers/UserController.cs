using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleUserAPI.DBContext;
using SimpleUserAPI.DBContext.DbSets;

namespace SimpleUserAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		UserContext _context;
		public UserController(UserContext context) { 
			_context = context;
		}

		[HttpGet]
		public ICollection<User> GetAll() {
			return _context.Users.ToList();
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(int id)
		{
			var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
			if (user == null)
			{
				return NotFound();
			}
			return Ok(user);
		}

		[HttpPost]
		public void CreateUser([FromBody] User newUser)
		{
			_context.Add(newUser);
			_context.SaveChanges();
		}

	}
}
