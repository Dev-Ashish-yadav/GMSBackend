using Domain.Interface;
using Domain.Models;
using MediatR;

namespace GymBackendServices.Handlers
{
    public class GymAdminHandler
    {
        public class Query : IRequest<CommonResponse>
        {
            public string UserName { get; set; }
            public string Password { get; set; }
        }
        public class Handler : IRequestHandler<Query, CommonResponse>
        {
            private readonly IGymAdminMasterRepository _repository;
            public Handler(IGymAdminMasterRepository repository)
            {
                _repository = repository;
            }

            public async Task<CommonResponse> Handle(Query request, CancellationToken cancellationToken)
            {
                CommonResponse response =new CommonResponse();
                try
                {
                    var result = await _repository.GetGymAdminMaster(request.UserName, request.Password);

                    response.Data = result != null
                        ? "Username and password match."
                        : "Invalid username or password.";
                }
                catch (Exception ex)
                {
                    response.Error =ex.ToString();
                }
                return response;
            }
        }
    }
}
