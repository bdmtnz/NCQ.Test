using System;
using System.Collections.Generic;
using System.Linq;

namespace NCQ.Test.Domain.Common.Base
{
    public abstract class ValueObject : IEquatable<ValueObject>
    {
        public abstract IEnumerable<object> GetEqualityComponents();

        public override bool Equals(object obj)
        {
            if (obj is null || obj.GetType() != GetType())
            {
                return false;
            }

            ValueObject valueObject = (ValueObject)obj;

            return GetEqualityComponents()
                .SequenceEqual(valueObject.GetEqualityComponents());
        }

        public static bool operator ==(ValueObject left, ValueObject right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ValueObject left, ValueObject right)
        {
            return !Equals(left, right);
        }

        public override int GetHashCode()
        {
            return GetEqualityComponents()
                .Select(x => x.GetHashCode())
                .Aggregate((x, y) => x ^ y);
        }

        public bool Equals(ValueObject other)
        {
            return Equals((object)other);
        }
    }
}
