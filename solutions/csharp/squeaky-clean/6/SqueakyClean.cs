using System.Text;
public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < identifier.Length; i++)
        {
            char ch = identifier[i];
            if (ch == ' ')
                result.Append('_');
            else if (char.IsControl(ch))
                result.Append("CTRL");
            else if (ch == '-' && i + 1 < identifier.Length) 
            {
                result.Append(char.ToUpper(identifier[i + 1]));
                i++;
            }else if (!char.IsLetter(ch))
                continue;
            else if (ch >= 'α' && ch <= 'ω')
                continue;
            else
                result.Append(ch);
        }

        return result.ToString();
    }
}
