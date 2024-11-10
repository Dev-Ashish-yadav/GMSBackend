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
                RuleFor(s => s.GU_MOBILE).NotEmpty().WithMessage("Mobile No is required");
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
