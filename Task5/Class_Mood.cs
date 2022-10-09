abstract class Mood
{
    //Властивості
    public abstract string[] Moods { get; }

    //Конструктор
    public Mood() 
    {
        Moods[0] = "Angry";
        Moods[1] = "Sad";
        Moods[2] = "Happy";
    }
}