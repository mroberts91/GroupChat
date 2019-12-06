using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Text;
using MessageServices;
using System.Threading.Tasks;
using GroupChat.ClientCore.Interfaces;

namespace GroupChat.ClientCore.Services
{
    public class UsersService : UserService.UserServiceClient, IUsersService
    {
        public UsersService(GrpcChannel channel) : base(channel)
        {
        }

        public async Task<Result> Register(string username, string email, string password)
        {
            var request = new CreateRequest()
            {
                Email = email,
                Username = username,
                Password = password
            };

            try
            {
                return await CreateUserAsync(request);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                var error = new Error() { Message = ex.Message };
                var result = new Result() { Success = false };
                result.Errors.Add(error);
                return result;
            }
        }

        public async Task<Result> RegisterExternalUser(string username, string email)
        {
            var request = new CreateExternalRequest()
            {
                Email = email,
                Username = username
            };

            try
            {
                return await CreateExternalUserAsync(request);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                var error = new Error() { Message = ex.Message };
                var result = new Result() { Success = false };
                result.Errors.Add(error);
                return result;
            }
        }
    }
}
