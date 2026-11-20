// Screen language. SystemBoost is sold in Korea only and its screen is Korean only: there is no language
// choice and the operating system's language is not looked at. A language.txt left by an earlier version
// (which offered English) is ignored. T stays so text drawn by hand keeps one place to pass through.
namespace SystemBoost.App.Services;

public static class Lang
{
    public const string Korean = "ko";

    /// The screen's language, sent to the server where it picks the language of a mail or an answer.
    public const string Code = Korean;

    /// The text as the screen shows it: the Korean text itself.
    public static string T(string text) => text;
}
