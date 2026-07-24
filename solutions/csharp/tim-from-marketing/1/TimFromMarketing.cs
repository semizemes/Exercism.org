static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string idText = $"{id}";
        if (id != null)
        {
            idText = $"[{id}] - ";
        }
        else
        {
            idText = "";
        }

        if (department == null)
        {
            department = "Owner";
        }

        string wholeText = $"{idText}{name} - {department.ToUpper()}";
        return wholeText;
    }
}
