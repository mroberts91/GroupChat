using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroupChat.Application;
using Grpc.Core;
using MessageServices;
using Microsoft.AspNetCore.Authorization;

namespace Server.Services
{
    public class UsersService : UserService.UserServiceBase
    {
        private readonly IIdentityService _identityService;
        public UsersService()
        {
        }

        [Authorize]
        public override async Task<Result> CreateUser(CreateRequest request, ServerCallContext context)
        {
            //var result = await _identityService.CreateUserAsync(request.Username, request.Email, request.Password);
            var resultMessage = new Result()
            {
                Success = true
            };
            //resultMessage.Errors.AddRange(GetErrors(result.Result));
            return await Task.FromResult(resultMessage);
        }

        public override async Task<Result> CreateExternalUser(CreateExternalRequest request, ServerCallContext context)
        {
            var result = await _identityService.CreateExternalAuthUser(request.Username, request.Email);
            
            var resultMessage = new Result()
            {
                Success = true
            };
            resultMessage.Errors.Add(new Error(){ Message = result.token });
            return resultMessage;
        }

        private List<Error> GetErrors(GroupChat.Application.Common.Models.Result result)
        {
            var errs = new List<Error>();
            foreach (var err in result.Errors)
            {
                errs.Add(new Error() { Message = err });
            }
            return errs;
        }
    }
}
