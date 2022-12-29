using FluentValidation;

namespace PRFT.Challenge.Application.Clients.Commands.CreateClient;

public class CreateClientCommandValidator : AbstractValidator<CreateClientCommand>
{
	public CreateClientCommandValidator()
	{
		RuleFor(x => x.ClientType).NotEmpty();
        RuleFor(x => x.FullName).NotEmpty();
        RuleFor(x => x.DocumentId).NotEmpty();		
		RuleFor(x => x.ContactInfo).NotEmpty();
	}
}
