using System.Buffers;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); //Ввожу розмірність
        string[][] arr = new string[n][];
        List<Song> playlist = new List<Song>(); //Список, у який будуть додаватись треки
        int added_songs = 0;

        for(int i = 0; i<n; ++i)
            arr[i] = Console.ReadLine().Split(';');

        Console.WriteLine();

            for (int i = 0; i < n; ++i)
            {
            try
            {
                if (arr[i].Length == 3)
                {
                    string time = arr[i][2];
                    string[] t = time.Split(':');
                    string[] surname = arr[i][0].Split(' ');

                    try
                    {
                        if (surname.Length == 1)
                        {
                            playlist.Add(new Song(surname[0], arr[i][0], int.Parse(t[0]), int.Parse(t[1])));
                            Console.WriteLine("Song added");
                            ++added_songs;
                        }
                        else if (surname.Length == 2)
                        {
                            playlist.Add(new Song(surname[0], surname[1], arr[i][0], int.Parse(t[0]), int.Parse(t[1])));
                            Console.WriteLine("Song added");
                            ++added_songs;
                        }
                    }
                    catch (InvalidSongException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                    throw new InvalidSongException("Inavlid song.");
            }
            catch (InvalidSongException ex)
            {
                Console.WriteLine(ex.Message);
            }
            }
        
        

        int hours = 0,  minutes = 0, seconds = 0;


        //Отримаємо кількість хвилин + секунд
        foreach(Song s in playlist)
        {
            minutes += s.Minutes;
            seconds += s.Seconds;
        }

        GetTime(ref hours, ref minutes, ref seconds);

        Console.WriteLine("Songs added: {0}", added_songs);
        Console.WriteLine($"Playlist length: {hours}h {minutes}m {seconds}s");
        Console.ReadKey();
    }

    static void GetTime(ref int h, ref int m, ref int s)
    {
        while(s >= 60)
        {
            s -= 60;
            ++m;
        }
        while(m >= 60)
        {
            m -= 60;
            ++h;
        }
    }
}