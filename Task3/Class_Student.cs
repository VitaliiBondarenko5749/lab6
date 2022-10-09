using System.Text;

class Student : Human
{
    // Поля
    private string faculty_number; // Номер факультету

    // Властивості
    public string Faculty_number //Властивість для faculty number
    {
        get => this.faculty_number;
        set
        {
            if (value.Length >= 5 && value.Length <= 10)
                this.faculty_number = value;
            else
                throw new ArgumentException("Invalid faculty number!");
        }
    }

    //Конструктор
    public Student(string first_name, string last_name, string faculty_number) : base(first_name, last_name)
    {
        this.Faculty_number = faculty_number;
    }

    //Перезавантажив метод ToString()
    public override string ToString()
    {
        StringBuilder resultBuilder = new StringBuilder();
        resultBuilder.AppendLine($"First Name: {this.Fisrt_name}").AppendLine($"Last Name: {this.Last_name}")
            .AppendLine($"Faculty number: {this.Faculty_number}");

        return resultBuilder.ToString();
    }
}