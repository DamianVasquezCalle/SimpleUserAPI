using SimpleUserAPI.DBContext.DbSets;

namespace SimpleUserAPI.DBContext
{
	public class DbInitializer
	{
		public static void Initialize(UserContext userContext)
		{
			if (userContext.Users.Any()) {
				return;
			}

			var users = new List<User>()
			{
				new User{ Name="Admin Damian", Lastname="Vasquez", Email="admin.damian.vasquez.calle@gmail.com", Password="damian2202" }
			};

			userContext.Users.AddRange(users);

			userContext.SaveChanges();

		}
	}
}
