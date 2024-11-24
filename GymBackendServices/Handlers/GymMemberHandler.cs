using Domain.Entities;
using Domain.Interface;
using Domain.Models;
using MediatR;

namespace GymBackendServices.Handlers
{
    //add record
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

    //update GymMembers
    public class GymMemberUpdate
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
                    var result =await _repository.UpdateMembers(request);
                    if (result > 0)
                    {
                        response.Data = "SuccessFully updated record.";
                    }
                    else
                    {
                        response.Data = "Something went wrong.";
                    }

                }
                catch (Exception ex)
                {
                    response.Error=ex.ToString();
                }
                return response;
            }
        }
    }
    //delete record
    public class GymMemberDelete
    {
        public class Query :IRequest<CommonResponse> 
        {
            public int id { get; set; }
        }
        public class Handler : IRequestHandler<Query, CommonResponse>
        {
            private readonly IGymMemberRepository _repository;
            public Handler(IGymMemberRepository repository)
            {
                _repository = repository;
            }

            public async Task<CommonResponse> Handle(Query request, CancellationToken cancellationToken)
            {
                CommonResponse response = new CommonResponse();
                try
                {
                    var result = await _repository.DeleteMembers(request.id);
                    if (result > 0)
                    {
                        response.Data = "SuccessFully delete record.";
                    }
                    else
                    {
                        response.Data = "Something went wrong.";
                    }

                }
                catch (Exception ex)
                {
                    response.Error = ex.ToString();
                }
                return response;
            }
        }
    }
    //get all member list
    public class GymMemberGetAll
    {
        public class Query : IRequest<CommonResponse> { }
        public class Handler : IRequestHandler<Query, CommonResponse>
        {
            private readonly IGymMemberRepository _repository;
            public Handler(IGymMemberRepository repository)
            {
                _repository = repository;
            }

            public async Task<CommonResponse> Handle(Query request, CancellationToken cancellationToken)
            {
                CommonResponse response = new CommonResponse();
                try
                {
                    var result = await _repository.GetAllMembersAsync();
                    if (result.Any())
                    {
                        response.Data = result;
                    }
                    else
                    {
                        response.Data = "Something went wrong.";
                    }

                }
                catch (Exception ex)
                {
                    response.Error = ex.ToString();
                }
                return response;
            }
        }
    }
    //get based on id
    public class GymMemberBasedOnID
    {
        public class Query :IRequest<CommonResponse> 
        {
            public int Id { get; set; }
        }
        public class Handler : IRequestHandler<Query, CommonResponse>
        {
            private readonly IGymMemberRepository _repository;
            public Handler(IGymMemberRepository repository)
            {
                _repository = repository;
            }

            public async Task<CommonResponse> Handle(Query request, CancellationToken cancellationToken)
            {
                CommonResponse response = new CommonResponse();
                try
                {
                    var result = await _repository.GetMemberBasedOnIdAsync(request.Id);
                    if (result !=null)
                    {
                        response.Data = result;
                    }
                    else
                    {
                        response.Data = "Something went wrong.";
                    }

                }
                catch (Exception ex)
                {
                    response.Error = ex.ToString();
                }
                return response;
            }
        }
    }
}
