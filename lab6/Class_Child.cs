class Child : Person
{
    //Для початку створюю конструктор
    public Child(string name, int age) : base(name, age) { }

    //Далі потрібно перезавантажити віртуальну властивість
    public override int Age
    {
        get => base.Age;

        set
        {
            if (value > 15)
                throw new ArgumentException("Age should not be more than 15");
            else 
                base.Age = value;
        }
    }

}