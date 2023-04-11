namespace Application.Services.Authentication;

public interface IAuthenticationService
{
    AuthenticationResult Register(string nome, string sobrenome, string email, string senha);
    AuthenticationResult Login(string email, string senha);
}
