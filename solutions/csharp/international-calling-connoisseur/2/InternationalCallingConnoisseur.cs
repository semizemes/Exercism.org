public static class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary()
    {
        return new Dictionary<int, string> { };
    }

    public static Dictionary<int, string> GetExistingDictionary()
    {
        Dictionary<int, string> phoneList = new Dictionary<int, string>
        {
            {1, "United States of America" },
            {55, "Brazil" },
            {91, "India" }
        };

        return phoneList;
    }

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {
        return new Dictionary<int, string> { { countryCode, countryName } };
    }

    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        existingDictionary.Add(countryCode, countryName);
        return existingDictionary;
    }

    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        if (existingDictionary.ContainsKey(countryCode))
        {
            return existingDictionary[countryCode];
        }
        else
        {
            return string.Empty;
        }
    }

    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
    {
        return existingDictionary.ContainsKey(countryCode);
    }

    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if (existingDictionary.TryGetValue(countryCode, out string val))
        {
            
        existingDictionary[countryCode] = countryName;
        }
        return existingDictionary;
    }

    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        existingDictionary.Remove(countryCode);
        return existingDictionary;
    }

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {
        int length = 0;
        string longestCountryName = "";

        foreach (var item in existingDictionary)
        {
            if (item.Value.Length > length)
            {
                length = item.Value.Length;
                longestCountryName = item.Value;
            }
        }
        return longestCountryName;
    }
}