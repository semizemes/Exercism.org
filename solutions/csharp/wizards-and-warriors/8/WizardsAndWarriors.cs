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
        bool _isVulnarable = target.Vulnerable();
        if (_isVulnarable)
        {
            return 10;
        }
        else
        {
            return 6;
        }
    }
}

class Wizard : Character
{

    private bool _isPrepared = false;
    public Wizard() : base("Wizard")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (_isPrepared)
        {
            return 12;
        }
        else
        {
            return 3;
        }
    }

    public void PrepareSpell()
    {
        _isPrepared = true;
    }

    public override bool Vulnerable()
    {
            return !_isPrepared;
    }
}
