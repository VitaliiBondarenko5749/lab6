using System.Diagnostics;
using System.Timers;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            string[] input = Console.ReadLine().Split(' ');

            if (input.Length <= 0 && input.Length > 100)
                throw new ArgumentException("So many food");

            List<FoodFactory> foodFactories = new List<FoodFactory>();

            for (int i = 0; i < input.Length; ++i)
                foodFactories.Add(new(input[i]));

            GetMood(ref foodFactories);               
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void GetMood(ref List<FoodFactory> f)
    {
        int points = 0;
        MoodFactory m = new MoodFactory();

        foreach (FoodFactory p in f)
        {
            if (p.Foods.ToLower() == "apple" || p.Foods.ToLower() == "melon")
                ++points;
            else if (p.Foods.ToLower() == "cram")
                points += 2;
            else if (p.Foods.ToLower() == "lembas")
                points += 3;
            else if (p.Foods.ToLower() == "honeycake")
                points += 5;
            else if (p.Foods.ToLower() == "mushrooms")
                points -= 10;
            else
                --points;
        }

        string mood = "";

        if (points < -5)
            mood = m.Moods[0];
        if (points >= -5 && points <= 0)
            mood = m.Moods[1];
        if (points >= 1 && points <= 15)
            mood = m.Moods[2];
        if (points > 15)
            mood = m.Moods[3];

        Console.WriteLine("\n" + points + "\n" + mood);
    }
}
