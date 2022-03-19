using System;

namespace ConsoleApp3
{
    class Program
    {

            public static void Main()
            {
                teacher teacher = new teacher("Maria Skłodowska", 50);

                student student1 = new student("Jan Kowaslski", 21, "LAB-01");
                student student2 = new student("Jan Kowaslski", 21, "LAB-01");
                student student3 = new student("Jaś Fasola", 23, "LAB-02");

                student1.AddTask("Taks A", taskStatus.Waiting);
                student1.AddTask("Taks B", taskStatus.Waiting);
                student1.AddTask("Taks C", taskStatus.Rejected);

                student2.AddTask("Taks A", taskStatus.Waiting);
                student2.AddTask("Taks B", taskStatus.Waiting);
                student2.AddTask("Taks C", taskStatus.Rejected);

                student3.AddTask("Taks D", taskStatus.Done);
                student3.AddTask("Taks E", taskStatus.Waiting);
                student3.AddTask("Taks F", taskStatus.Waiting);

                student3.UpdateTask(1, taskStatus.Done);
                student3.UpdateTask(2, taskStatus.Progress);

                persons[] persons = { teacher, student1, student2, student3 };
                classroom classroom = new classroom("Sala Komputerowa", persons);

                Console.WriteLine(classroom);

                Console.WriteLine("student1 == student2: " + student1.Equals(student2)); // Output: student1 == student2: true
                Console.WriteLine("student1 == student3: " + student1.Equals(student3)); // Output: student1 == student3: false
            }
        
    }
}
