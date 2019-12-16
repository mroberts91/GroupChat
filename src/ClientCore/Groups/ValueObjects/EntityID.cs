using GroupChat.ClientCore.Common.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroupChat.ClientCore.Groups.ValueObjects
{
    public class EntityID : ValueObject<EntityID>
    {
        private readonly string _value;
        public EntityID(string value)
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

        public static bool TryParse(string candidate, out EntityID entityId)
        {
            entityId = null;
            if (string.IsNullOrWhiteSpace(candidate))
                return false;

            entityId = new EntityID(candidate.Trim());
            return true;
        }

        public static implicit operator string(EntityID entityId)
        {
            return entityId._value;
        }

        public override string ToString()
        {
            return _value.ToString();
        }
    }
}
