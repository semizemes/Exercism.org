abstract class Character
{
    string characterName;
    protected Character(string characterType)
    {
        characterName = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        throw new NotImplementedException("Please implement the Character.Vulnerable() method");
    }

    public override string ToString()
    {
        return $"Character is a {characterName}";
    }
}

class Warrior : Character
{
    public Warrior() : base("TODO")
    {
    }

    public override int DamagePoints(Character target)
    {
        throw new NotImplementedException("Please implement the Warrior.DamagePoints() method");
    }
}

class Wizard : Character
{
    public Wizard() : base("TODO")
    {
    }

    public override int DamagePoints(Character target)
    {
        throw new NotImplementedException("Please implement the Wizard.DamagePoints() method");
    }

    public void PrepareSpell()
    {
        throw new NotImplementedException("Please implement the Wizard.PrepareSpell() method");
    }
}
