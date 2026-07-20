public static class Languages
{
    public static List<string> NewList()
    {
        return new List<string>();
    }

    public static List<string> GetExistingLanguages()
    {
        var expected = new List<string>();
        expected.Add("C#");
        expected.Add("Clojure");
        expected.Add("Elm");
        return expected;
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages.Add(language);
        return languages;
    }

    public static int CountLanguages(List<string> languages)
    {
        int listLength = languages.Count();
        return listLength;
    }

    public static bool HasLanguage(List<string> languages, string language)
    {
        bool isExist = languages.Contains(language);
        return isExist;
    }

    public static List<string> ReverseList(List<string> languages)
    {
        languages.Reverse();
        return languages;
    }

    public static bool IsExciting(List<string> languages)
    {
        if (languages.First() == "C#")
        {
            return true;
        } else if (languages[1] == "C#" && languages.Count() >= 2)
        {
            return true;
        } else
        {
            return false;
        }
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages)
    {
        bool isUnique = languages.Count == languages.Distinct().Count();
        return isUnique;
    }
}
