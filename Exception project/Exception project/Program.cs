namespace Exception_project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int nextId = 1;
            Console.WriteLine("Registraciq na uchenik");

            Console.Write("Ime: ");
            string name = Console.ReadLine();

            int age;
            Console.Write("Vuzrast: ");
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Nevalidna vuzrast , opitai otnovo.");
                Console.Write("Vuzrast");
            }
            byte studentClass;
            Console.WriteLine("Klas: ");
            while (!byte.TryParse(Console.ReadLine(), out studentClass))
            {
                Console.WriteLine("Nevaliden klas opitai otnovo.");
                Console.Write("Klas: ");
            }
            double avaregeGrade;
            Console.WriteLine("Uspeh: ");
            while (!double.TryParse(Console.ReadLine(), out avaregeGrade))
            {
                Console.WriteLine("Nevaliden uspeh , opitai otnovo");
                Console.Write("Uspeh: ");
            }
            decimal fee;
            Console.WriteLine("taksa: ");
            while (!decimal.TryParse(Console.ReadLine(), out fee))
            {
                Console.WriteLine("Nevalidna taksa , opitai otnovo");
                Console.Write("taksa: ");
            }
            bool hasScholarship;
            Console.WriteLine("Stipendiq(true/false):");
            while (!bool.TryParse(Console.ReadLine(), out hasScholarship))
            {
                Console.WriteLine("Vuvedete true/false");
                Console.Write("Stipendiq true/false");
            }
            char classLetter;
            Console.WriteLine("Pararelka:");
            while (!(char.TryParse(Console.ReadLine(), out classLetter)))
            {
                Console.WriteLine("Nevaliden simvol , vuvedete bukva");
                Console.Write("Paralelka:");

            }
            DateTime birthDate;
            Console.WriteLine("Data na razjdane: ");
            while (!DateTime.TryParse(Console.ReadLine(), out birthDate))
            {
                Console.WriteLine("Nevalidna data , opitai otnovo");
                Console.Write(" data na razjdane:");
            }
            Console.WriteLine();
            Console.WriteLine("DANNI");
            Console.WriteLine($"Ime: {name}");
            Console.WriteLine($"Vuzrast: {age}");
            Console.WriteLine($"Klas: {studentClass}");
            Console.WriteLine($"Uspeh: {avaregeGrade}");
            Console.WriteLine($"Taksa: {fee}");

            string scholarshipText = hasScholarship ? "Da" : "Ne";
            Console.WriteLine($"stipendiq: {scholarshipText}");

            Console.WriteLine($"Paralelka: {classLetter}");
            Console.WriteLine($"Дата на раждане: {birthDate:dd.MM.yyyy}");

            nextId++;



        }
    }
}
