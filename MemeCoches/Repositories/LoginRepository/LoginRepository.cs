using MemeCoches.Database.Params;
using MemeCoches.Database.Results;

namespace MemeCoches.Repositories.LoginRepository
{
	public class LoginRepository(IConfiguration configuration) : BaseRepository(configuration), ILoginRepository
	{
		public LoginResult Login(LoginParams loginParams)
		{
			try
			{
				
			} catch(Exception ex)
			{

			}


		}
	}
}
