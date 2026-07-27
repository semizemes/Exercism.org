public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {
        switch (shirtNum)
        {
            case 1:
                return "goalie";
                break;
            case 2:
                return "left back";
                break;
            case 3:
            case 4:
                return "center back";
                break;
            case 6:
            case 7:
            case 8:
                return "midfielder";
                break;
            case 9:
                return "left wing";
                break;
            case 10:
                return "striker";
                break;
            case 11:
                return "right wing";
                break;
            default:
                return "UNKNOWN";
                break;

        }
    }

    public static string AnalyzeOffField(object report)
    {
        switch (report)
        {
            case int number:
                return $"There are {number} supporters at the match.";
                break;
            case string text:
                return text;
                break;
            case Foul:
                return "The referee deemed a foul.";
                break;
            case Injury injury:
                return $"Oh no! {injury.GetDescription()} Medics are on the field.";
                break;
            case Incident incident:
                return $"{incident.GetDescription()}";
                break;
            case Manager manager:
                return $"{manager.Name}{(string.IsNullOrEmpty(manager.Club) ? string.Empty : $" ({manager.Club})")}";
            default:
                return "";
                break;
        }
    }
}
