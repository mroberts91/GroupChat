using GroupChat.ClientCore.Interfaces;
using Grpc.Core;
using Grpc.Net.Client;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GroupChat.ClientCore.Services
{
    public class RpcServiceProvider: IRpcServiceProvider
    {
        private readonly IConfiguration _config;
        private readonly ICurrentUserService _currentUserService;
        public RpcServiceProvider(IConfiguration configuration, ICurrentUserService currentUserService)
        {
            _config = configuration;
            _currentUserService = currentUserService;
        }

        public async Task<IUsersService> GetUserServiceAsync ()
        {
            return new UsersService(await CreateServiceChannel());
        }
        

        private async Task<GrpcChannel> CreateServiceChannel()
        {
            var address = _config["Api:Chat"];
            var user = await _currentUserService.CurrentUser();
            var credentials = CallCredentials.FromInterceptor((context, metadata) =>
            {
                if (!string.IsNullOrEmpty(user.AccessToken))
                {
                    metadata.Add("Authorization", $"Bearer {user.AccessToken}");
                }
                return Task.CompletedTask;
            });
            var channel = GrpcChannel.ForAddress(address, new GrpcChannelOptions
            {
                Credentials = ChannelCredentials.Create(new SslCredentials(), credentials)
            });
            return channel;
        }
    }

}
