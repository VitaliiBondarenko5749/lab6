class FoodFactory : Food
{
    //Властивості
    public override string Foods { get; set; }

    //Конструктор
    public FoodFactory(string f) : base(f) { }
}