using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace litmanager_api.Contracts.V1
{
    public static class ApiRoutes
    {
        public const string Root = "api";
        public const string Version = "v1";
        public const string Base = Root + "/" + Version;

        public static class Identity
        {
            public const string Login = Base + "/identity/login";
            public const string Refresh = Base + "/identity/refresh";
        }

        public static class User
        {
            public const string GetAll = Base + "/users";
            public const string Get = Base + "/user/{userId}";
            public const string Create = Base + "/user";
            public const string Update = Base + "/user/{userId}";
            public const string Delete = Base + "/user/{userId}";

            public const string PatchEmail = Base + "/user/change/email/{userId}";
            public const string PatchFirstName = Base + "/user/change/firstname/{userId}";
            public const string PatchLastName = Base + "/user/change/lastname/{userId}";
            public const string PatchUserType = Base + "/user/change/usertype/{userId}";
            public const string PatchPassword = Base + "/user/change/password/{userId}";
            public const string PatchIsEnabled = Base + "/user/change/isenabled/{userId}";
            public const string PatchIsAdmin = Base + "/user/change/isadmin/{userId}";
        }

        public static class Registration
        {
            public const string GetAll = Base + "/registrations";
            public const string Get = Base + "/registration/{registrationId}";
            public const string Create = Base + "/registration";
            public const string Update = Base + "/registration/{registrationId}";
            public const string Approve = Base + "/registration/approve/{registrationId}";
            public const string Deny = Base + "/registration/deny/{registrationId}";
        }

        public static class UserType
        {
            public const string GetAll = Base + "/usertypes";
            public const string Get = Base + "/usertype/{userTypeId}";
            public const string Create = Base + "/usertype";
            public const string Update = Base + "/usertype/{userTypeId}";
            public const string Delete = Base + "/usertype/{userTypeId}";
        }
    }
}
