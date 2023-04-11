namespace Contracts.Authentication;

public record AuthenticationResponse
(
	Guid Id,
	string Nome,
	string Sobrenome,
	string Email,
	string Token
);
