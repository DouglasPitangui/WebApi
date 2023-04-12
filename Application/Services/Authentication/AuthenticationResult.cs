namespace Application.Services.Authentication;

public record AuthenticationResult
(
    Guid Id,
    string Nome,
    string Sobrenome,
    string Email,
    string Senha,
    string Token
);
