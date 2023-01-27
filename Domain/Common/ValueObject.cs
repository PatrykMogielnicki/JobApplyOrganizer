﻿namespace Domain.Common
{
    public abstract class ValueObject
    {
        protected static bool EqualOperator(ValueObject left, ValueObject right)
        {
            if(left == null ^ right == null)
            {
                return false;
            }
            return left?.Equals(right!) != false;
        }

        protected static bool NotEqualOperator(ValueObject left, ValueObject right)
        {
            return !(EqualOperator(left, right));
        }

        protected abstract IEnumerable<object> GetEqualitycomponents();

        public override bool Equals(object? obj)
        {
            if(obj == null|| obj.GetType() != GetType())
            {
                return false;
            }
            
            var other = (ValueObject)obj;
            return GetEqualitycomponents().SequenceEqual(other.GetEqualitycomponents());
        }

        public override int GetHashCode()
        {
            return GetEqualitycomponents().Select(x => x != null ? x.GetHashCode() : 0).Aggregate((x, y) => x ^ y);
        }
    }
}
