using AutoMapper;
using litmanager_api.Contracts.V1.Requests.UserType;
using litmanager_api.Contracts.V1.Responses.UserType;
using litmanager_api.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace litmanager_api.Mapping
{
    public class UserTypeMapping : Profile
    {
        public UserTypeMapping()
        {
            CreateMap<UserType, GetResponse>();

            CreateMap<CreateRequest, UserType>();
            CreateMap<UpdateRequest, UserType>();
        }
    }
}
