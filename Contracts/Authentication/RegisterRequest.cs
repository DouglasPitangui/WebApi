namespace Contracts.Authentication;

public record RegisterRequest
(
	string Nome,
	string Sobrenome,
	string Email,
	string Senha
);
