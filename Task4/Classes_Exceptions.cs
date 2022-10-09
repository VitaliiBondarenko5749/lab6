class InvalidSongException : Exception //Дочірній клас, батько якого є сам клас Exception
{
    public InvalidSongException(string message) : base(message) { }
} 

//Підкласи для класу InvalidSongException
class InvalidArtistNameException : InvalidSongException //Дочірній клас, батьком якого є клас InvalidSongException
{ //Вийняток спрацює, коли буде неправильне ім'я виконавця
    public InvalidArtistNameException(string message) : base(message) { }
}
class InvalidSongNameException : InvalidSongException //Дочірній клас, батьком якого є клас InvalidSongException
{ //Вийняток спрацює, коли буде некоректне ім'я пісні
    public InvalidSongNameException(string message) : base(message) { }
}
class InvalidSongLengthException : InvalidSongException //Дочірній клас, батьком якого є клас InvalidSongException
{ //Клас спрацює, коли буде некоректна тривалість пісні
    public InvalidSongLengthException(string message) : base(message) { }  
}

//Підкласи для класу InvalidSongLengthException
class InvalidSongMinutesException : InvalidSongLengthException //Дочірній клас, батьком якого є клас InvalidSongLengthException
{ // Клас спрацює, коли буде некоректна кількість хвилин
    public InvalidSongMinutesException(string message) : base(message) { }
}
class InvalidSongSecondsException : InvalidSongLengthException //Дочірній клас, батьком якого є клас InvalidSongLengthException
{ //Клас спрацює, коли буде некоректна кількість секунд
    public InvalidSongSecondsException(string message) : base(message) { }
}

