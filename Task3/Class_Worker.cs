using System.Text;

class Worker : Human
{
    //Поля
    private decimal week_salary; //Зарплата в тиждень
    private int working_hours; //Скільки годин працює

    //Властивості
    public decimal WeekSalary //Властивість для перевірки зарплат
    {
        get => this.week_salary;
        set
        {
            if(value < 10) //Якщо зарплата < 10
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            else
                this.week_salary = value;
        }
    }
    public int WorkingHours
    {
        get => this.working_hours;
        set
        {
            if (value >= 1 && value <= 12)
                this.working_hours = value;
            else
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
        }
    }

    //Конструктор
    public Worker(string first_name, string last_name, decimal week_salary, int working_hours) : base(first_name, last_name)
    {
        this.WeekSalary = week_salary;
        this.WorkingHours = working_hours;
    }

    public override string ToString()
    {
        StringBuilder resultBuilder = new StringBuilder();
        resultBuilder.AppendLine($"First Name: {this.Fisrt_name}").AppendLine($"Last Name: {this.Last_name}")
            .AppendLine($"Week Salary: {this.WeekSalary:f2}").AppendLine($"Hours per day: {this.WorkingHours:f2}")
            .AppendLine($"Salary per hour: {this.WeekSalary / this.WorkingHours / 5:f2}");

        //вираз :f2 додає знаки після коми у string

        return resultBuilder.ToString();
    }

}