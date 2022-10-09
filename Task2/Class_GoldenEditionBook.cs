class GoldenEditionBook : Book
{
    //Створюємо конструктор
    public GoldenEditionBook(string author, string title, decimal price) : base(author, title, price) { }

    //Перезавантажуємо властивість
    public override decimal Price { get => base.Price * 1.3M; }
}