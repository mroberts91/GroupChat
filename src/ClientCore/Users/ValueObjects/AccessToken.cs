using System;
using System.Collections.Generic;
using System.Text;

namespace GroupChat.ClientCore.Users.ValueObjects
{
    public class AccessToken : ValueObject<AccessToken>
    {
        private readonly string _value;
        public AccessToken(string value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            if (!IsValid(value))
                throw new ArgumentException("Invalid value.", nameof(value));

            _value = value;
        }
        public static bool IsValid(string candidate)
        {
            if (string.IsNullOrEmpty(candidate))
                return false;

            return true;
        }

        public static bool TryParse(string candidate, out AccessToken accessToken)
        {
            accessToken = null;
            if (string.IsNullOrWhiteSpace(candidate))
                return false;

            accessToken = new AccessToken(candidate.Trim());
            return true;
        }

        public static implicit operator string(AccessToken accessToken)
        {
            return accessToken._value;
        }

        public override string ToString()
        {
            return _value.ToString();
        }
    }
}
