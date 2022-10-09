using System.Net.WebSockets;

class Song : Artist
{
    //Поля
    private string song_name; //Назва пісні
    private int minutes; //Кількість хвилин для плейлиста
    private int seconds; //Кількість секунд

    //Властивості
    public string SongName //Властивість для назви треку
    {
        get => this.song_name;
        set
        {
            if (value.Length >= 3 && value.Length <= 30)
                this.song_name = value;
            else
                throw new InvalidSongNameException("Song name should be between 3 and 30 symbols.");
        }
    }
    public int Minutes //Властивість для хвилин
    {
        get => this.minutes;
        set
        {
            if (value >= 0 && value <= 14)
                this.minutes = value;
            else
                throw new InvalidSongMinutesException("Song minutes should be between 0 and 14.");
        }
    }
    public int Seconds //Властивість для секунд
    {
        get => this.seconds;
        set
        {
            if (value >= 0 && value <= 59)
                this.seconds = value;
            else
                throw new InvalidSongSecondsException("Song seconds should be between 0 and 59.");
        }
    }

    //Конструктори
    public Song(string fn, string sn, string songn, int min, int sec) : base(fn, sn) 
    {
        if ((min < 0 && min > 14) && (sec < 0 && sec > 59))
            throw new InvalidSongLengthException("Invalid song length.");
        else
        {
            this.SongName = songn;
            this.Minutes = min;
            this.Seconds = sec;
        }
    }
    public Song(string fn, string songn, int min, int sec) : base(fn) 
    {
        if ((min < 0 && min > 14) && (sec < 0 && sec > 59))
            throw new InvalidSongLengthException("Invalid song length.");
        else
        {
            this.SongName = songn;
            this.Minutes = min;
            this.Seconds = sec;
        }
    }
}