namespace Pensumsjekk2
{
    internal class School
    {
        public class Student
        {
            public string navn;
            public int alder;
            public string kurs;
            public Student(string navn, int alder, string kurs)
            {
                this.navn = navn;
                this.alder = alder;
                this.kurs = kurs;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen til voksenskolen \n Ta vel imot elevene våre!");
            Console.WriteLine();
            var student1 = new Student("Heibert", 42, "Radiobilkjøring");
            var student2 = new Student("Hildibrand", 23, "Inspektør");
            var student3 = new Student("Godbert", 56, "Gullsmed");
            Console.WriteLine($"{student1.navn} er {student1.alder} år gammel og går {student1.kurs}-kurset");
            Console.WriteLine($"{student2.navn} er {student2.alder} år gammel og går {student2.kurs}-kurset");
            Console.WriteLine($"{student3.navn} er {student3.alder} år gammel og går {student3.kurs}-kurset");
            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            Console.WriteLine();
            Console.WriteLine("Det er altså:");
            foreach (Student student in students)
            {
                Console.WriteLine(student.navn);
            }
            Console.WriteLine();
            Console.WriteLine("Skriv inn et kurs for å få frem alle elever i dette kurset. (Må skrives nøyaktig med case)");
            string search = Console.ReadLine();
            foreach (Student s in students)
            {
                if (search == s.kurs) Console.WriteLine(s.navn);
            }
        }
    }
}