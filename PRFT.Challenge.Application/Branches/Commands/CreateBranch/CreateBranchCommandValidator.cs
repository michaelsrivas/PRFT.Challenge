using FluentValidation;

namespace PRFT.Challenge.Application.Branches.Commands.CreateBranch;

public class CreateBranchCommandValidator : AbstractValidator<CreateBranchCommand>
{
	public CreateBranchCommandValidator()
	{
        RuleFor(x => x.Code).NotEmpty();
        RuleFor(x => x.Name).NotEmpty();
        RuleFor(x => x.VendorCode).NotEmpty();
        RuleFor(x => x.CreditLimit).NotEmpty();
        RuleFor(x => x.ContactInfo).NotEmpty();
    }
}
