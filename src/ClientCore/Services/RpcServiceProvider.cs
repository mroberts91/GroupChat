using GroupChat.ClientCore.Interfaces;
using Grpc.Net.Client;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroupChat.ClientCore.Services
{
    public class RpcServiceProvider: IRpcServiceProvider
    {
        private readonly IConfiguration _config;
        public RpcServiceProvider(IConfiguration configuration)
        {
            _config = configuration;
        }

        public IUsersService UserService => new UsersService(CreateServiceChannel());

        private GrpcChannel CreateServiceChannel()
        {
            var address = _config["Hubs:Url"];
            return GrpcChannel.ForAddress("https://localhost:5001");
        }
    }

}
