using Domain.Entities;
using Domain.Interface;
using Domain.Models;
using MediatR;

namespace GymBackendServices.Handlers
{
    public class GymMemberHandler
    {
        public class Query : GymMember, IRequest<CommonResponse> { }
        public class Handler : IRequestHandler<Query, CommonResponse>
        {
            private readonly IGymMemberRepository _repository;
            public Handler(IGymMemberRepository repository)
            {
                _repository = repository;
            }

            public async Task<CommonResponse> Handle(Query request, CancellationToken cancellationToken)
            {
                CommonResponse response =new CommonResponse();
                try
                {
                    var result =await _repository.AddGymMember(request);
                    if(result)
                    {
                        response.Data = "Successfully add record.";
                    }
                    else
                    {
                        response.Data = "Something went wrong.";
                    }
                }
                catch(Exception ex)
                {
                    response.Error = ex.ToString();
                }
               return response;
            }
        }
    }
}
