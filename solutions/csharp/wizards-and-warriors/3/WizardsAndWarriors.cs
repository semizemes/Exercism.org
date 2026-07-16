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
        return false;
    }

    public override string ToString()
    {
        return $"Character is a {characterName}";
    }
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        throw new NotImplementedException("Please implement the Warrior.DamagePoints() method");
    }
}

class Wizard : Character
{
    public Wizard() : base("Wizard")
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
