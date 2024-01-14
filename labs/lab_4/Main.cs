using lab4_zad2;

namespace lab4_zad1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("zadanie 1:");
            List<Shape> shapes = new();

            shapes.Add(new Rectangle());
            shapes.Add(new Circle());
            shapes.Add(new Triangle());

            foreach (Shape shape in shapes)
            {
                shape.Draw();
            }


            Console.WriteLine();

            Console.WriteLine("zadanie 2:");
            // Create a teacher
            Nauczyciel teacher = new Nauczyciel();
            teacher.SetFirstName("Jan");
            teacher.SetLastName("Kowalski");
            teacher.SetPesel("84072799758");
            teacher.SetSchool("High School");
            teacher.SetCanGoHomeAlone(false); 

            
            teacher.TytulNaukowy = "Dr.";

            // Create students
            Uczeń student1 = new Uczeń();
            student1.SetFirstName("Anna");
            student1.SetLastName("Nowak");
            student1.SetPesel("67112872882");
            student1.SetSchool(" New High School");
            student1.ChangeSchool("High School");
            student1.SetCanGoHomeAlone(true); 

            Uczeń student2 = new Uczeń();
            student2.SetFirstName("Piotr");
            student2.SetLastName("Wiśniewski");
            student2.SetPesel("77100213272");
            student2.SetSchool("High School");
            student2.SetCanGoHomeAlone(false);

            // Add students to the teacher's collection
            teacher.Kolekcja_uczniów.Add(student1);
            teacher.Kolekcja_uczniów.Add(student2);

            Console.WriteLine($"Student's full name: {student1.GetFullName()}");
            Console.WriteLine($"Student's age: {student1.GetAge()}");
            Console.WriteLine($"Student's gender: {student1.GetGender()}");
            Console.WriteLine($"Student's education info: {student1.GetEducationInfo()}");
            Console.WriteLine($"Student can go home alone: {student1.CanGoAloneToHome()}");

            // Call methods and display information
            Console.WriteLine($"Teacher's full name: {teacher.GetFullName()}");
            Console.WriteLine($"Teacher's age: {teacher.GetAge()}");
            Console.WriteLine($"Teacher's gender: {teacher.GetGender()}");
            Console.WriteLine($"Teacher's education info: {teacher.GetEducationInfo()}");
            Console.WriteLine($"Teacher can go home alone: {teacher.CanGoAloneToHome()}");

            // Show class information
            Console.WriteLine();
            teacher.ShowClass(new DateTime(2023, 7, 12));


            // Check which students can go home alone
            Console.WriteLine();
            teacher.WhichStudentCanGoHomeAlone();
        }

    }
    
}
