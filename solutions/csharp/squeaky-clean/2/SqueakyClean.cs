public static class Identifier
{
    public static string Clean(string identifier)
    {
        string underscored = identifier.Replace(' ', '_');

        int[] CTRLIndexArr = underscored
            .Select((ch, index) => new { ch, index })
            .Where(x => char.IsControl(x.ch))
            .Select(x => x.index)
            .ToArray();

        foreach (var item in CTRLIndexArr)
        {
            underscored = underscored.Replace(underscored[item].ToString(), "CTRL");
        }

        int index = underscored.IndexOf('-');
        underscored.Trim('-');
        char bigOne = char.ToUpper(underscored[index]);
        underscored = underscored.Replace(underscored[index], bigOne);

        return underscored;
    }
}
