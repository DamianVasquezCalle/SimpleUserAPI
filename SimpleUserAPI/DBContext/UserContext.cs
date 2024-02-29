using Microsoft.EntityFrameworkCore;
using SimpleUserAPI.DBContext.DbSets;

namespace SimpleUserAPI.DBContext
{
	public class UserContext: DbContext
	{
		public UserContext(DbContextOptions<UserContext> options): base(options) { }


		public DbSet<User> Users { get; set; }
	}
}
