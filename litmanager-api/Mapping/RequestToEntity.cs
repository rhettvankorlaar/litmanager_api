using AutoMapper;
using litmanager_api.Contracts.V1.Requests.Registration;
using litmanager_api.Domain;

namespace litmanager_api.Mapping

{
    public class RequestToEntity : Profile
    {
        public RequestToEntity()
        {
            CreateMap<CreateRequest, Registration>();
            CreateMap<UpdateRequest, Registration>();
        }
    }
}
