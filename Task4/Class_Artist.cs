class Artist
{
    //Поля
    private string first_name; // Ім'я
    private string last_name; //Прізвище

    //Властивості
    public string FirstName //Властивість для імені
    {
        get => this.first_name;
        set
        {
            int length = 0;

            if(LastName == null)
            {
                length = 0;
            }
            else
            {
                length = LastName.Length;
            }
            if (value.Length + length >= 3 && value.Length + length <= 20)
                this.first_name = value;
            else
                throw new InvalidArtistNameException("Artist name should be between 3 and 20 symbols.");
        }
    }
    public string LastName //Властивість для прізвища
    {
        get => this.last_name;
        set => this.last_name = value;
    }

    //Конструктори
    public Artist(string fn, string ln) : this(fn) { this.LastName = ln; }
    public Artist(string fn) { this.FirstName = fn; }
}