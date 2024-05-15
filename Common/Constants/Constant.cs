namespace Common.Constants;

public enum Gender
{
    Male,
    Female,
    Other
}
public static class GenderExtension
{
    public static List<string> TextValues = new List<string>()
    {
        "Nam",
        "Nữ",
        "Khác"
    };
    public static string GetText(this Gender gender)
    {
        try
        {
            return TextValues[(int)gender];
        }
        catch
        {
            return "n/a";
        }
    }
}

