﻿using System;

namespace Ether.Contracts.Dto
{
    [Serializable]
    public abstract class BaseDto : IEquatable<BaseDto>
    {
        public virtual Guid Id { get; set; }

        public virtual bool Equals(BaseDto other)
        {
            if (other == null)
            {
                return false;
            }

            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            var other = obj as BaseDto;
            if (other == null)
            {
                return false;
            }

            return Equals(other);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
