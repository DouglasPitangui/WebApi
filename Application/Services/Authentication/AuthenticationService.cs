using Application.Common.Interfaces.Authentication;

namespace Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public AuthenticationResult Register(string nome, string sobrenome, string email, string senha)
    {
        // Check if user already exists

        // Create user (generate unique ID)
        Guid userId = Guid.NewGuid();

        // Create JWT token
        var token = _jwtTokenGenerator.GenerateToken(userId, nome, sobrenome);

        return new AuthenticationResult(userId, nome, sobrenome, email, senha, token);
    }

    public AuthenticationResult Login(string email, string senha)
    {
        return new AuthenticationResult(Guid.NewGuid(), "nome", "sobrenome", email, senha, "token");

    }
}
