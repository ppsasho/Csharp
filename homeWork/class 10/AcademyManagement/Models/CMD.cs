using System.Runtime.ExceptionServices;

namespace Models
{
    public static class CMD
    {
        public static string GetInput(string msg)
        {
            while (true)
            {
                Console.Write($"{msg}");
                string input = Console.ReadLine();
                if (input != "") return input;
                Console.WriteLine("Input is invalid, please try again.(don't leave empty fields!)");
                continue;
            }
        }
        public static bool ListRemove(Admin admin, string userType)
        {
            while (true)
            {
                switch (userType)
                {
                    case "admin":
                        string adminUserName = GetInput("Enter the admin's username:");
                        if (admin.Admins.Any(x => x.Username == adminUserName && admin.Username != adminUserName)) //foreach (Admin user in admin.Admins)
                        {
                            admin.Admins.Remove(admin.Admins.First(x => x.Username == adminUserName));
                            Console.WriteLine("The admin has been removed successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Please check the username's correct. (And you can't remove yourself)");
                            continue;
                        }
                        break;

                    case "trainer":
                        string trainerUserName = GetInput("Enter the trainer's username:");
                        if (admin.Trainers.Any(x => x.Username == trainerUserName))
                        {
                            admin.Trainers.Remove(admin.Trainers.First(x => x.Username == trainerUserName));
                            Console.WriteLine("The trainer has been removed successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Please check the username's correct");
                            continue;
                        }
                        break;

                    case "student":
                        string studentUserName = GetInput("Enter the student's username:");
                        if (admin.Students.Any(x => x.Username == studentUserName)) //foreach (Admin user in admin.Admins)
                        {
                            Student removedStudent = admin.Students.First(x => x.Username == studentUserName);
                            removedStudent.CurrentSubject.StudentsAttending.Remove(removedStudent.CurrentSubject.StudentsAttending.First(x => x.Username == studentUserName));
                            admin.Students.Remove(removedStudent);
                            Console.WriteLine("The student has been removed successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Please check the username's correct");
                            continue;
                        }
                        break;

                }
                switch (GetInput($"Would you like to remove another {userType}? (Y N)").ToUpper())
                {
                    case "Y":
                        continue;
                    case "N":
                    default:
                        Console.Clear();
                        return AdminLogin(admin);
                }
            }
        }
        public static bool ListAdd(Admin admin, string userType)
        {
            while (true)
            {
                switch (userType)
                {
                    case "admin":
                        string adminUserName = GetInput("Enter the new admin's username:");
                        if (admin.Admins.Any(x => x.Username == adminUserName))
                        {
                            Console.WriteLine("The username already exists!");
                            continue;
                        }
                        string adminName = GetInput("Enter the new admin's name:");
                        string adminPassword = GetInput("Enter the new admin's password:");
                        admin.Admins.Add(new(adminName, adminUserName, adminPassword, admin.Trainers, admin.Students, admin.Admins, admin.Subjects));
                        Console.WriteLine("The new admin has been registered!");
                        break;

                    case "trainer":
                        string trainerUserName = GetInput("Enter the new trainer's username:");
                        if (admin.Trainers.Any(x => x.Username == trainerUserName))
                        {
                            Console.WriteLine("The username already exists!");
                            continue;
                        }
                        string trainerName = GetInput("Enter the new trainer's name:");
                        string trainerPassword = GetInput("Enter the new trainer's password:");
                        admin.Trainers.Add(new(trainerName, trainerUserName, trainerPassword, admin.Students, admin.Subjects));
                        Console.WriteLine("The new trainer has been registered!");
                        break;

                    case "student":
                        string studentUserName = GetInput("Enter the new student's username:");
                        if (admin.Students.Any(x => x.Username == studentUserName))
                        {
                            Console.WriteLine("The username already exists!");
                            continue;
                        }
                        string studentName = GetInput("Enter the new students's name:");
                        string studentPassword = GetInput("Enter the new student's password:");
                        Student newStudent = new(studentName, studentUserName, studentPassword, admin.Subjects[0], new List<int> { });
                        admin.Students.Add(newStudent);
                        admin.Subjects[0].StudentsAttending.Add(newStudent);
                        Console.WriteLine("The new student has been registered!");
                        break;
                }
                switch (GetInput($"Would you like to add another {userType}? (Y N)").ToUpper())
                {
                    case "Y":
                        continue;
                    case "N":
                    default:
                        Console.Clear();
                        return AdminLogin(admin);
                }
            }

        }

        public static bool AdminLogin(Admin admin)
        {
            Console.Clear();
            string userType = string.Empty;
            while (true)
            {

                Console.WriteLine($"Welcome {admin.FirstName}!");
                switch (GetInput("What would you like to see a list of?\n1)Admins\n2)Trainers\n3)Students\n\n4)Sign out\n"))
                {
                    case "1":
                        Console.Clear();
                        userType = "admin";
                        foreach (Admin user in admin.Admins) Console.WriteLine(user.FirstName);
                        break;

                    case "2":
                        Console.Clear();
                        userType = "trainer";
                        foreach (Trainer trainer in admin.Trainers) Console.WriteLine(trainer.FirstName);
                        break;

                    case "3":
                        Console.Clear();
                        userType = "student";
                        foreach (Student student in admin.Students) Console.WriteLine(student.FirstName);
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("Thanks for using our app!");
                        return false;

                    default:
                        Console.WriteLine("Please make sure you picked one number!");
                        continue;
                }

                switch (GetInput("Would you like to:\n1)Add someone to the list\n2)Remove someone from the list\n3)Go back\n"))
                {
                    case "1":
                        return ListAdd(admin, userType);

                    case "2":
                        return ListRemove(admin, userType);

                    case "3":
                    default:
                        Console.Clear();
                        continue;
                }
            }
        }
        public static bool AdminSignIn(List<Admin> admins)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the admin section!");
            while (true)
            {
                string username = GetInput("Enter your username:");
                if (!admins.Any(x => x.Username == username))
                {
                    Console.WriteLine("Username does not exist!");
                    continue;
                } while (true)
                {
                    string password = GetInput("Enter your password:");
                    if (!admins.Any(x => x.Username == username && x.CheckPassword(password)))
                    {
                        Console.WriteLine("Incorrect password, please try again!");
                        continue;
                    }
                    Admin admin = admins.First(x => x.Username == username);
                    return AdminLogin(admin);
                }

            }
        }

        public static bool TrainerLogin(Trainer trainer)
        {
            Console.Clear();
            Console.WriteLine($"Welcome {trainer.FirstName}!");
            while (true)
            {
                Console.Clear();
                switch (GetInput("What would you like to see a list of?\n1)Students\n2)Subjects\n"))
                {
                    case "1":
                        foreach (Student s in trainer.Students) Console.WriteLine(s.FirstName);
                        while (true)
                        {
                            switch (GetInput("Would you like to see a student's subject? (Y N)").ToUpper())
                            {
                                case "Y":
                                    string name = GetInput("Enter the student's Name");
                                    if (!trainer.Students.Any(x => x.FirstName.ToLower() == name.ToLower()))
                                    {
                                        Console.WriteLine("Please check you entered the student's name correctly.");
                                        continue;
                                    }
                                    else
                                    {
                                        Student foundStudent = trainer.Students.First(x => x.FirstName.ToLower() == name.ToLower());
                                        Console.WriteLine(foundStudent.CurrentSubject.Name);
                                        break;
                                    }

                                case "N":
                                default: break;
                            }
                            break;
                        }
                        break;

                    case "2":
                        foreach (Subject s in trainer.Subjects) Console.WriteLine($"{s.Name}\t-\t{s.StudentsAttending.Count} students");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please check that you entered one number!");
                        continue;
                }
                switch (GetInput("Would you like to:\n1)Go back\n2)Sign out\n"))
                {
                    case "1":
                        continue;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Thanks for using our app!");
                        return false;
                }
            }
        }

        public static bool TrainerSignIn(List<Admin> admins)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the trainer section!");
            while (true)
            {
                string username = GetInput("Enter your username:");
                if (!admins[0].Trainers.Any(x => x.Username == username))
                {
                    Console.WriteLine("Username does not exist!");
                    continue;
                } while (true)
                {
                    string password = GetInput("Enter your password:");
                    if (!admins[0].Trainers.Any(x => x.Username == username && x.CheckPassword(password)))
                    {
                        Console.WriteLine("Incorrect password, please try again!");
                        continue;
                    }
                    Trainer trainer = admins[0].Trainers.First(x => x.Username == username);
                    return TrainerLogin(trainer);
                }

            }
        }
        public static bool StudentLogIn(Student student)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Welcome {student.FirstName}!");
                Console.WriteLine($"Your current subject is {student.CurrentSubject.Name}");
                Console.Write("Your grades: ");
                foreach (int grade in student.Grades) Console.Write($"{grade} ");
                switch (GetInput("\nPress Y to sign out:").ToUpper())
                {
                    case "Y":
                        Console.Clear();
                        Console.WriteLine("Thanks for using our app!");
                        return false;
                    default:
                        continue;
                }
            }

        }
        public static bool StudentSignIn(List<Admin> admins)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the student section!");
            while (true)
            {
                string username = GetInput("Enter your username:");
                if (!admins[0].Students.Any(x => x.Username == username))
                {
                    Console.WriteLine("Username does not exist!");
                    continue;
                } while (true)
                {
                    string password = GetInput("Enter your password:");
                    if (!admins[0].Students.Any(x => x.Username == username && x.CheckPassword(password)))
                    {
                        Console.WriteLine("Incorrect password, please try again!");
                        continue;
                    }
                    Student student = admins[0].Students.First(x => x.Username == username);
                    return StudentLogIn(student);
                }

            }
        }
    }
}
