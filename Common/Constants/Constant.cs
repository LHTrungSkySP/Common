namespace Common.Constants;
public static class ContextItems
{
    public const string UserId = "UserId";
    public const string Username = "Username";
    public const string Permissions = "Permissions";
    //public const string Fullname = "Fullname";
    //public const string ProfileCode = "ProfileCode";
    //public const string Email = "Email";
}
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

