namespace Week4Practical;

class Program
{
    static void Main(string[] args)
    {
        
        // Task 1 first object creation and value initialization
        Student  student1 = new Student();
        student1.Id=1;
        student1.Name="Nelson";
        student1.Address="Tarahara";


        // Task 1 second object creation and value initialization
        Student student2 = new Student();
        student2.Id=2;
        student2.Name="Ashish";
        student2.Address="Halgada";

        // Printing the Instace field values 
        Console.WriteLine($"{student1.Id}");
        Console.WriteLine($"{student1.Name}");
        Console.WriteLine($"{student1.Address}");
        Console.WriteLine();

        // Printing The second Instance field values
        Console.WriteLine($"{student2.Id}");
        Console.WriteLine($"{student2.Name}");
        Console.WriteLine($"{student2.Address}");
        Console.WriteLine();
        
        // Printing static field values
        Console.WriteLine($"{Student.schoolName}");


        

        
    }
}
