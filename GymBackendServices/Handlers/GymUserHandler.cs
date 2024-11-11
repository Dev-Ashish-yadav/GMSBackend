using Domain.Entities;
using Domain.Interface;
using Domain.Models;
using FluentValidation;
using MediatR;

namespace GymBackendServices.Handlers
{
    public class GymUserHandler
    {
        public class Query :Gym_Users_master, IRequest<CommonResponse> { }
      public class QueryValidator : AbstractValidator<Query>
{
    public QueryValidator()
    {
        RuleFor(s => s.GU_DOB).NotEmpty().WithMessage("DOB is required");
        RuleFor(u => u.GU_MOBILE).NotEmpty().WithMessage("Mobile No is required.")
        .Matches(@"^\d{10}$").WithMessage("Mobile No must be 10 digits.");

        RuleFor(u => u.GU_FIRST_NAME).NotEmpty().WithMessage("First Name is required.")
        .Length(2, 50).WithMessage("First Name must be between 2 and 50 characters.");

        RuleFor(u => u.GU_LAST_NAME).NotEmpty().WithMessage("Last Name is required.")
            .Length(2, 50).WithMessage("Last Name must be between 2 and 50 characters.");

        RuleFor(u => u.GU_EMAIL).NotEmpty().WithMessage("Email is required.")
            .EmailAddress().WithMessage("Invalid email format.");

        RuleFor(u => u.GU_AADHAR).Matches(@"^\d{12}$").WithMessage("Aadhar number must be exactly 12 digits.")
        .When(u => !string.IsNullOrEmpty(u.GU_AADHAR));

        RuleFor(u => u.GU_PAN).Matches(@"^[A-Z]{5}[0-9]{4}[A-Z]{1}$").WithMessage("Invalid PAN number format.")
       .When(u => !string.IsNullOrEmpty(u.GU_PAN));

        RuleFor(u => u.GU_DOB).NotEmpty().WithMessage("DOB is required.")
       .LessThan(DateTime.Now).WithMessage("DOB must be a valid date in the past.");

        RuleFor(u => u.GU_GENDER).NotEmpty().WithMessage("Gender is required.")
       .Must(BeValidGender).WithMessage("Gender must be 'Male', 'Female', or 'Other'.");
    }
    private bool BeValidGender(string gender)
    {
        return gender == "Male" || gender == "Female" || gender == "Other";
    }
}
        public class Handler : IRequestHandler<Query, CommonResponse>
        {
            private readonly IGym_User_MasterRepository _gym_User_;
            public Handler(IGym_User_MasterRepository gym_User_)
            {
                _gym_User_ = gym_User_;
            }
            public async Task<CommonResponse> Handle(Query request, CancellationToken cancellationToken)
            {
                CommonResponse response = new CommonResponse();
                try
                {
                    var validator = new QueryValidator();
                    var result = validator.Validate(request);
                    if (!result.IsValid)
                    {
                        response = new CommonResponse
                        {
                            Code = -1,
                            Error = string.Join(", ", result.Errors.SelectMany(e => e.ErrorMessage))
                        };
                        return response;
                    }
                    var addUser = await _gym_User_.AddMembers(request);


                }
                catch (Exception ex)
                {
                }
                return response;
            }
        }
    }
}
