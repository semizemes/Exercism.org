static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        if (knightIsAwake)
        {
            return false;
        } else
        {
            return true;
        }
            //throw new NotImplementedException("Please implement the (static) QuestLogic.CanFastAttack() method");
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        //throw new NotImplementedException("Please implement the (static) QuestLogic.CanSpy() method");
        if (knightIsAwake || archerIsAwake || prisonerIsAwake )
        {
            return true;
        } else
        {
            return false;
        }
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        //throw new NotImplementedException("Please implement the (static) QuestLogic.CanSignalPrisoner() method");
        if (archerIsAwake == false && prisonerIsAwake)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        //throw new NotImplementedException("Please implement the (static) QuestLogic.CanFreePrisoner() method");
        if (knightIsAwake == false && archerIsAwake == false && prisonerIsAwake == true && petDogIsPresent == false)
        {
            return false;
        } else if (archerIsAwake == false && petDogIsPresent == true)
        {
            return true;
        }
        else
        {
            return true;
        }
    }
}
