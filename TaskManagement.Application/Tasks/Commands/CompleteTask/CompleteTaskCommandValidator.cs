using FluentValidation;

namespace TaskManagement.Application.Tasks.Commands.CompleteTask
{
    public class CompleteTaskCommandValidator : AbstractValidator<CompleteTaskCommand>
    {
        public CompleteTaskCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Id is required");

            RuleFor(x => x.UserId)
                .NotEmpty().WithMessage("UserId is required");
        }
    }
} 