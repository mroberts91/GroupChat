using GroupChat.ClientCore.Users.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroupChat.ClientCore.Users
{
    public class AuthenticatedUser
    {
        private readonly Name _name;
        private readonly Email _email;
        private readonly AccessToken _accessToken;
        public AuthenticatedUser(string name, string email, string token)
        {
            Name.TryParse(name, out _name);
            Email.TryParse(email, out _email);
            AccessToken.TryParse(token, out _accessToken);
        }

        public Name Name => _name;
        public Email Email => _email;
        public AccessToken AccessToken => _accessToken;
    }
}
