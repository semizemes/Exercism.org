static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        var idText =id.HasValue ? $"[{id}] - " : "";
        var printDepartment = $" - {department?.ToUpper() ?? "OWNER"}";

        string wholeText = $"{idText}{name}{printDepartment}";
        return wholeText;
    }
}
