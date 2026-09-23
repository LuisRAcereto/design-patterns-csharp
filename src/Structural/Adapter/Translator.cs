// The translator, adapts the Japanese speaker to the English Interface
public class Translator : IEnglishSpeaker
{
    private readonly JapaneseTeamMember _teamMember;

    public Translator(JapaneseTeamMember teamMember)
    {
        _teamMember = teamMember;
    }

    public void Speak(string message)
    {
        string translated = TranslateToJapanese(message);
        _teamMember.SpeakJapanese(translated);
    }

    private string TranslateToJapanese(string english) => english switch
    {
        "Good morning, team."           => "おはようございます、チームの皆さん。",
        "Please review the proposal."   => "提案書を確認してください。",
        _                               => $"[Japanese: {english}]"
    };
}