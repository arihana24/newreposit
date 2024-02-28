    switch (StringComparer.InvariantCultureIgnoreCase.Compare(PreRelease, other.PreRelease))
        {
            case 1:
                return 1;

            case -1:
                return -1;

            default:
            {
                return (string.IsNullOrEmpty(Meta) != string.IsNullOrEmpty(other.Meta))
                    ? string.IsNullOrEmpty(Meta) ? 1 : -1
                    : StringComparer.InvariantCultureIgnoreCase.Compare(Meta, other.Meta);
            }
        }

  public override bool Equals(object obj)
    {
        return (obj is SemVersion semVersion)
               && Equals(semVersion);
    }   public override int GetHashCode()
    {
        unchecked
        {
            var hashCode = Major;
            hashCode = (hashCode * 397) ^ Minor;
            hashCode = (hashCode * 397) ^ Patch;
            hashCode = (hashCode * 397) ^
                       (PreRelease != null ? StringComparer.OrdinalIgnoreCase.GetHashCode(PreRelease) : 0);
            hashCode = (hashCode * 397) ^ (Meta != null ? StringComparer.OrdinalIgnoreCase.GetHashCode(Meta) : 0);
            return hashCode;
        }
    }
