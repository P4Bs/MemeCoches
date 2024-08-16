using MemeCoches.Database.Params;
using MemeCoches.Models.Enums;
using MemeCoches.Repositories.LoginRepository;

namespace MemeCoches.Features.Login.Handlers
{
	public class LoginRequest
	{
		public required string Username { get; set; }
		public required string PasswordHash { get; set; }
	}

	public class LoginResponse
	{
		public required LoginResult LoginResult { get; set; }
	}

	public class LoginHandler(ILoginRepository loginRepository)
	{
		private ILoginRepository _loginRepository { get; set; } = loginRepository;

		public LoginResponse Handler(LoginRequest loginRequest)
		{
			var loginParams = MapParameters(loginRequest);

			// TODO: GET RETURN
			_loginRepository.Login(loginParams);

			return new()
			{
				LoginResult = LoginResult.Aceptado
			};
		}

		private static LoginParams MapParameters(LoginRequest request)
		{
			var loginParams = new LoginParams()
			{
				Username = request.Username,
				PasswordHash = request.PasswordHash
			};

			return loginParams;
		}
    }
}
