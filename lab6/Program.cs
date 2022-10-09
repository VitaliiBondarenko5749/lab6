/*
Task 1.
09.10.2022.
Bondarenko Vitalii.
*/

using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());

        try
        {
            Child child = new Child(name, age);
            Console.WriteLine(child); //Тут є уявно ToString(), який ми перезавантажили у класі Person

        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
    }
}