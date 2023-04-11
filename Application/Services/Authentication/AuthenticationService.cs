namespace Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    public AuthenticationResult Register(string nome, string sobrenome, string email, string senha)
    {
        return new AuthenticationResult(Guid.NewGuid(), nome, sobrenome, email, senha, "token");
    }

    public AuthenticationResult Login(string email, string senha)
    {
        return new AuthenticationResult(Guid.NewGuid(), "nome", "sobrenome", email, senha, "token");

    }
}
