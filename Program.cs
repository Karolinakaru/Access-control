internal class Program
{
    private static void Main(string[] args)
    {
        int age;
        Console.WriteLine("Enter your age");
        if(int.TryParse(Console.ReadLine(), out age))
        {
            if (age >= 18)
            {
                Console.WriteLine("Access granted");
            }
            else if (age < 15)
                Console.WriteLine(" Access denied");
            else//15>age>18
            {
                Console.WriteLine("Do you have parental consent? Y/N");
                string answer = Console.ReadLine().ToUpper();
                switch (answer)
                {
                    case "Y":
                        Console.WriteLine("Access granted");
                        break;
                    case "N":
                        Console.WriteLine("Access denied");
                        break;
                    default:
                        Console.WriteLine("Incorrect data insered. Try again");
                        break;
                }
            }

        }

        else
            Console.WriteLine("Incorrect data insered. Try again");

    }
}

