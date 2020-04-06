using AutoMapper;
using litmanager_api.Contracts.V1.Requests.Registration;
using litmanager_api.Contracts.V1.Responses.Registration;
using litmanager_api.Domain;

namespace litmanager_api.Mapping
{
    public class EntityToResponse : Profile
    {
        public EntityToResponse()
        {
            CreateMap<Registration, GetResponse>();
            CreateMap<Registration, User>();
        }
    }
}
