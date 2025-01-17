﻿using AutoMapper;
using litmanager_api.Contracts.V1.Requests.User;
using litmanager_api.Contracts.V1.Responses.User;
using litmanager_api.Domain;
using litmanager_api.Mail;

namespace litmanager_api.Mapping
{
    public class UserMapping : Profile
    {
        public UserMapping()
        {
            CreateMap<CreateRequest, User>();
            CreateMap<UpdateRequest, User>();

            CreateMap<User, GetResponse>();
            CreateMap<User, Receiver>();


        }
    }
}
