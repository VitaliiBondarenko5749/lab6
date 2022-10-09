using System.Globalization;
using System.Text;

public class Person // Клас людини
{
    //Оголошую поля
    private string name; // Ім'я (private protected або protected треба додати, щоб було поле доступно у дочірньому класі)
    private int age; // Вік (private protected або protected треба додати, щоб було поле доступно у дочірньому класі)

    //Властивості
    public string Name //Властивість для імені(я не думаю, що її треба перезавантажувати)
    {
        get => name;
        set
        {
            if (value.Length < 3)
                throw new ArgumentException("Name's length should not be less than 3 symbols");
            else
                name = value;
        }
    }
    public virtual int Age //Властивість для віку(зробили віртуальною щоб потім її можна було змінити у дочірньому класі)
    {
        get => age;
        set
        {
            if (value < 0)
                throw new ArgumentException("Age must be positive!");
            else
                age = value;
        }
    }

    //Конструктор
    public Person(string name, int age) { this.Name = name; this.Age = age; }

    //Перезавантаження методу ToString() від класу Object
    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append(String.Format("Name: {0}, Age: {1}", this.Name, this.Age));

        return stringBuilder.ToString();
    }
}