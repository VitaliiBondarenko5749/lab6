public class Human
{
    //Поля
    string fisrt_name; // Ім'я
    string last_name; // Прізвище

    //Властивості
    public string Fisrt_name // Властивість до імені
    {
        get => this.fisrt_name;
        set
        {
            if (value[0].ToString() == value[0].ToString().ToLower() || value.Length < 3)
            {
                if (value[0].ToString() == value[0].ToString().ToLower()) //Якщо перша літера починається з маленької букви
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                else if (value.Length < 3) // Якщо маємо меше трьох букв у імені
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
            }
            else
                this.fisrt_name = value;
        }
    }
    public string Last_name // Властивість до прізвища
    {
        get => this.last_name;
        set
        {
            if (value[0].ToString() == value[0].ToString().ToLower() || value.Length < 2)
            {
                if (value[0].ToString() == value[0].ToString().ToLower()) //Якщо перша літера починається з маленької букви
                    throw new ArgumentException("Expected upper case letter! Argument: lastName");
                else if (value.Length < 2) // Якщо маємо меше трьох букв у імені
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: laststName");
            }
            else
                this.last_name = value;
        }
    }

    //Коструктор
    public Human(string fn, string ln) { this.Fisrt_name = fn; this.Last_name = ln; }
}