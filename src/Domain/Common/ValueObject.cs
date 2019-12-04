using System;
using System.Linq;
using System.Reflection;

namespace CleanArchitecture.Domain.Common
{
    // Learn more: https://docs.microsoft.com/en-us/dotnet/standard/microservices-architecture/microservice-ddd-cqrs-patterns/implement-value-objects
    public abstract class ValueObject<TObject> : IEquatable<TObject> where TObject : class
    {
        public static bool operator ==(ValueObject<TObject> left, ValueObject<TObject> right)
        {
            if (left is null)
                return right is null;
            return left.Equals(right);
        }

        public static bool operator !=(ValueObject<TObject> left, ValueObject<TObject> right)
        {
            return !(left == right);
        }

        public override bool Equals(object candidate)
        {
            if (candidate is null) return false;
            return Equals(candidate as TObject);

        }

        public virtual bool Equals(TObject other)
        {
            if (other is null) return false;

            foreach (FieldInfo fieldInfo in GetType().GetFields(BindingFlags.Instance
                    | BindingFlags.Public | BindingFlags.NonPublic))
            {
                object obj1 = fieldInfo.GetValue(other);
                object obj2 = fieldInfo.GetValue(this);
                if (obj1 == null)
                {
                    if (obj2 != null)
                        return false;
                }
                else if (typeof(DateTime).IsAssignableFrom(fieldInfo.FieldType)
                        || typeof(DateTime?).IsAssignableFrom(fieldInfo.FieldType))
                {
                    if (!((DateTime)obj1).ToLongDateString().Equals(((DateTime)obj2).ToLongDateString()))
                        return false;
                }
                else if (!obj1.Equals(obj2))
                    return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            return GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                .Select(x => x != null ? x.GetHashCode() : 0)
                .Aggregate((x, y) => x ^ y);
        }
    }
}
