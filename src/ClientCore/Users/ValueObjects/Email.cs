using GroupChat.ClientCore.Common.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace GroupChat.ClientCore.Users.ValueObjects
{
    public class Email : ValueObject<Email>
    {
        private readonly string _value;
        public Email(string value)
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

        public static bool TryParse(string candidate, out Email email)
        {
            email = null;
            if (string.IsNullOrWhiteSpace(candidate))
                return false;

            email = new Email(candidate.Trim());
            return true;
        }

        public static implicit operator string(Email email)
        {
            return email._value;
        }

        public override string ToString()
        {
            return _value.ToString();
        }

    }
}
