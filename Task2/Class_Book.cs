using System.Text;

public class Book
{
    //Поля
    private string author; //Назва для автора
    private string title; //Назва заголовка
    private decimal price; //Ціна

    //Властивості
    public string Author 
    {
        get => this.author;
        set
        {
            if (value.Contains("1") || value.Contains("2") || value.Contains("3") || value.Contains("4") ||
                value.Contains("5") || value.Contains("6") || value.Contains("7") || value.Contains("8") ||
                value.Contains("9") || value.Contains("0")) //Перевірка чи є цифри
                throw new ArgumentException("Author not valid");
            else
                this.author = value;     
        }
    }
    public string Title 
    {
        get => this.title;
        set
        {
            if (value.Length < 3)
                throw new ArgumentException("Title not valid");
            else
                this.title = value;
        }
    }
    public virtual decimal Price 
    {
        get => this.price;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Price not valid");
            else
                this.price = value;
        }
    }

    //Коструктор
    public Book(string author, string title, decimal price)
    {
        this.Author = author;
        this.Title = title;
        this.Price = price;
    }

    //Перезавантаження методу ToString()
    public override string ToString()
    {
        StringBuilder resultBuilder = new StringBuilder();

        resultBuilder.AppendLine($"Type: {this.GetType().Name}").AppendLine($"Title: {this.Title}")
            .AppendLine($"Author: {this.Author}").AppendLine($"Price: {this.Price:f2}");
        string result = resultBuilder.ToString().TrimEnd();
        //TrimEnd() видаляє всі пробіли зі строки

        return result;
    }
}