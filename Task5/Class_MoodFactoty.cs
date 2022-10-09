using System.Text.Encodings.Web;

class MoodFactory : Mood
{
    //Властивості
    public override string[] Moods { get; } = { "", "", "", "" };

    //Конструктор
    public MoodFactory() : base()
    {
        Moods[3] = "JavaScript";
    }
}