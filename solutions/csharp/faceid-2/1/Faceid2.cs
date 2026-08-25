public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }
    // TODO: implement equality and GetHashCode() methods
    public override bool Equals(object obj)
    {
        if (obj is not FacialFeatures other)
        {
            return false;
        }
        return this.EyeColor == other.EyeColor && this.PhiltrumWidth == other.PhiltrumWidth;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(EyeColor, PhiltrumWidth);
    }
}

public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }
    // TODO: implement equality and GetHashCode() methods
    public override bool Equals(object? obj)
    {
        if (obj is not Identity other)
        {
            return false;
        }

        return this.Email == other.Email && this.FacialFeatures.Equals(other.FacialFeatures);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Email, FacialFeatures);
    }

}

public class Authenticator
{
    public HashSet<Identity> identities = new();
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)
    {
        return FacialFeatures.Equals(faceA, faceB);
    }

    public bool IsAdmin(Identity identity)
    {
        var admin = new Identity("admin@exerc.ism", new FacialFeatures("green", 0.9m));
        return Identity.Equals(admin, identity);
    }

    public bool Register(Identity? identity)
    {
        return identities.Add(identity);
    }

    public bool IsRegistered(Identity identity)
    {
        return identities.Contains(identity);
    }

    public static bool AreSameObject(Identity identityA, Identity identityB)
    {
        return Identity.ReferenceEquals(identityA, identityB);
    }
}
