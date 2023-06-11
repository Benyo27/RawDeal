using System.Text.RegularExpressions;

namespace RawDeal;

public static class RegexController
{
    public static string Match(string input, string pattern) =>
        Regex.Match(input, pattern).Groups[1].Value;
}