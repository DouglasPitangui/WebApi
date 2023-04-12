using Microsoft.AspNetCore.Mvc;
using Contracts.Authentication;
using Application.Services.Authentication;

namespace Api.Controllers
{
    [ApiController]
	[Route("auth")]
	public class AuthenticationController : ControllerBase
	{
		private readonly IAuthenticationService _authenticationService;
		public AuthenticationController(IAuthenticationService authenticationService)
		{
			_authenticationService = authenticationService;
		}

		[HttpPost("register")]
		public IActionResult Register(RegisterRequest request)
		{
			var authResult = _authenticationService.Register(request.Nome, request.Sobrenome, request.Email, request.Senha);
			var response = new AuthenticationResponse(authResult.Id, authResult.Nome, authResult.Sobrenome, authResult.Email, authResult.Token);
			return Ok(response);
		}

		[HttpPost("login")]
		public IActionResult Login(LoginRequest request)
		{
			var authResult = _authenticationService.Login(request.Email, request.Senha);
			var response = new AuthenticationResponse(authResult.Id, authResult.Nome, authResult.Sobrenome, authResult.Email, authResult.Token);
			return Ok(response);
		}
	}
}
