namespace class06Recap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Sasho", "Popovski", "SEDC", "G3");
            Student s2 = new Student("Petko", "Petkovski", "SEDC", "G3");
            Student s3 = new Student("Krste", "Krstevski", "SEDC", "G3");
            Student s4 = new Student("Jovan", "Jovanovski", "SEDC", "G3");
            Student s5 = new Student("Josh", "Hamilton", "SEDC", "G3");

            Student[] students = new Student[5] { s1, s2, s3, s4, s5 };

            while (true)
            {
                Console.WriteLine("Please enter a search phrase:");
                string input = Console.ReadLine();

                // Search
                Student[] result = new Student[0];
                foreach(Student student in students) 
                {
                    if(student.GetFullName().ToLower().Contains(input.ToLower()))
                    {
                        Array.Resize(ref result, result.Length + 1);
                        result[result.Length - 1] = student;
                    }
                }

                //Print result
                if(result.Length == 0)
                {
                    Console.WriteLine("No results found.");
                } else
                {
                    foreach(Student student in result)
                    {
                        Console.WriteLine(student.GetStudentData());
                    }
                }


                Console.WriteLine("Do you want to search again?");
                string choice = Console.ReadLine().ToUpper();
                if(choice != "Y")
                {
                    break;
                }
                continue;
            }
        }
    }
}
