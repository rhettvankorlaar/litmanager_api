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
    }
}
