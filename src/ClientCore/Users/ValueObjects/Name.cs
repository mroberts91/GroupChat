using System;
using System.Collections.Generic;
using System.Text;

namespace GroupChat.ClientCore.Users.ValueObjects
{
    public class Name : ValueObject<Name>
    {
        private readonly string _value;
        public Name(string value)
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

        public static bool TryParse(string candidate, out Name userName)
        {
            userName = null;
            if (string.IsNullOrWhiteSpace(candidate))
                return false;

            userName = new Name(candidate.Trim());
            return true;
        }

        public static implicit operator string(Name userName)
        {
            return userName._value;
        }

        public override string ToString()
        {
            return _value.ToString();
        }
        
    }
}
