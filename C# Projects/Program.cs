﻿string[] students = {"John", "Sara", "Drake", "Smith"};
Console.WriteLine("Enter a name! : ");
var name = Console.ReadLine();
foreach (string student in students)
{
    if (student.Equals(name))
    {
        Console.WriteLine($"{name} has been found in the system!");
    }

        for (int i = students.Length; i >= 0 ;i--)
        {
            if (i == 0)
            {
                Console.WriteLine("The name has not been found in the system!");
            }
        }
}
