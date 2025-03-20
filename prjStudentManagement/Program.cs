namespace prjStudentManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var StudentManager = new StudentManager();
            Console.WriteLine("Student Management Application");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View All Students");
            Console.WriteLine("0. Exit");

            while (true)
            {
                Console.Write("\nEnter your choice: ");
                string choice = Console.ReadLine();
                switch(choice)
                {
                    case "1":
                        Console.Write("Enter student name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter student age: ");
                        int age = int.Parse(Console.ReadLine());
                        var student = StudentManager.AddStudent(name, age);
                        Console.WriteLine($"Student added: [student]");
                        break;

                    case "2":
                        var students = StudentManager.GetStudents();
                        Console.WriteLine("All Students: ");
                        foreach(var s in students)
                        {
                            Console.WriteLine(s);
                        }
                        break;

                    case "0":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }
    }
}
