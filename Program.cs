namespace Week4Practical;

class Program
{
    static void Main(string[] args)
    {
        Student  student1 = new Student();
        student1.Id=1;
        student1.Name="Nelson";
        student1.Address="Tarahara";

        Student student2 = new Student();
        student2.Id=2;
        student2.Name="Ashish";
        student2.Address="Halgada";

        Console.WriteLine($"{student1.Id}");
        Console.WriteLine($"{student1.Name}");
        Console.WriteLine($"{student1.Address}");
        Console.WriteLine();

        Console.WriteLine($"{student2.Id}");
        Console.WriteLine($"{student2.Name}");
        Console.WriteLine($"{student2.Address}");
        Console.WriteLine();

        Console.WriteLine($"{Student.schoolName}");
        Console.WriteLine();

        Calculator calculator = new Calculator();
        calculator.PrintWelcome();
        int addResult = calculator.Add(10, 20);
        Console.WriteLine($"Addition of 10 and 20 is: {addResult}");
        int multiplyResult1 = calculator.Multiply(5, 3);
        Console.WriteLine($"Multiplication of 5 and 3 is: {multiplyResult1}");
        int multiplyResult2 = calculator.Multiply(7);
        Console.WriteLine($"Multiplication of 7 and 1 (default) is: {multiplyResult2}");
        Console.WriteLine();

        ParameterDemo paramDemo = new ParameterDemo();
        int myNumber = 5;
        Console.WriteLine($"Before Increase method: {myNumber}");
        paramDemo.Increase(ref myNumber);
        Console.WriteLine($"After Increase method: {myNumber}");
        Console.WriteLine();

        string name;
        paramDemo.GetFullName(out name);
        Console.WriteLine($"Full name retrieved: {name}");
        Console.WriteLine();

        int result1 = paramDemo.SumAll(1, 2, 3);
        Console.WriteLine($"Sum of 1, 2, 3 is: {result1}");
        int result2 = paramDemo.SumAll(10, 20, 30, 40, 50);
        Console.WriteLine($"Sum of 10, 20, 30, 40, 50 is: {result2}");
        int result3 = paramDemo.SumAll(100);
        Console.WriteLine($"Sum of just 100 is: {result3}");
        Console.WriteLine();

        Player player1 = new Player();
        player1.playerName = "Guest Player";
        player1.level = 1;
        player1.health = 50;
        Console.WriteLine($"Player 1 Name: {player1.playerName}");
        Console.WriteLine($"Player 1 Level: {player1.level}");
        Console.WriteLine($"Player 1 Health: {player1.health}");
        Console.WriteLine();

        Player player2 = new Player("Hero Warrior", 10, 100);
        Console.WriteLine($"Player 2 Name: {player2.playerName}");
        Console.WriteLine($"Player 2 Level: {player2.level}");
        Console.WriteLine($"Player 2 Health: {player2.health}");
        Console.WriteLine();

        Console.Write("Enter a day (e.g., Sunday, Monday, etc.): ");
        string? userDay = Console.ReadLine();
        DayType dayType;

        if (userDay?.ToLower() == "friday" || userDay?.ToLower() == "saturday")
        {
            dayType = DayType.Weekend;
            Console.WriteLine($"It is: {dayType}");
        }
        else
        {
            dayType = DayType.Weekday;
            Console.WriteLine($"It is: {dayType}");
        }
        Console.WriteLine();

        Book book1 = new Book("C# Programming", "John Doe", 49.99);
        Console.WriteLine($"Book 1 - Title: {book1.title}, Author: {book1.author}, Price: ${book1.price}");
        Book book2 = book1 with { title = "Advanced C#", price = 59.99 };
        Console.WriteLine($"Book 2 - Title: {book2.title}, Author: {book2.author}, Price: ${book2.price}");
        Console.WriteLine($"Book 1 (unchanged) - Title: {book1.title}, Author: {book1.author}, Price: ${book1.price}");
        Console.WriteLine();

        int marks = 0;
        int total = 0;

        Console.Write("Enter marks obtained: ");
        string? marksInput = Console.ReadLine();

        if (int.TryParse(marksInput, out marks))
        {
            Console.WriteLine($"Successfully parsed marks: {marks}");
        }
        else
        {
            Console.WriteLine("Invalid input for marks. Using default value 0.");
        }

        Console.Write("Enter total marks: ");
        string? totalInput = Console.ReadLine();

        if (int.TryParse(totalInput, out total))
        {
            Console.WriteLine($"Successfully parsed total: {total}");
        }
        else
        {
            Console.WriteLine("Invalid input for total. Using default value 0.");
        }

        double percentage = marks / total * 100;
        Console.WriteLine($"Percentage (BUGGY): {percentage}%");

        double percentageCorrect = (double)marks / total * 100;
        Console.WriteLine($"Percentage (CORRECT): {percentageCorrect}%");
        Console.WriteLine();
    }
}
