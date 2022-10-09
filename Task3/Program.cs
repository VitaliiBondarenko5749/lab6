class Program
{
    static void Main(string[] args)
    {
        Student student;
        Worker worker;
        try
        {
            for(int i = 0; i<1; ++i)
            {
                string[] input = Console.ReadLine().Split(' ');

                if (input.Length != 3)
                    throw new ArgumentException("Invalid length for student");

                string[] input1 = Console.ReadLine().Split(' ');

                if (input1.Length != 4)
                    throw new ArgumentException("Invalid length for worker");

                student = new(input[0], input[1], input[2]);
                worker = new(input1[0], input1[1], decimal.Parse(input1[2]), int.Parse(input1[3]));

                Array.Clear(input);
                Array.Clear(input1);

                Console.WriteLine();
                Console.WriteLine(student);
                Console.WriteLine(worker);
            }
        }
        catch(ArgumentException ex)
        {
            Console.WriteLine("\n" + ex.Message);
        }
    }
}