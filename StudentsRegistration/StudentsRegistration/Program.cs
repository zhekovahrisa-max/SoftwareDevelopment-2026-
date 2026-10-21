using System;

public class Class1
{
	public Class1()
	{

        private static int nextId = 1;

    static void Main(string[] args)
    {
        Console.WriteLine("Registraciq na uchenik");
        Console.WriteLine();

        int currentId = nextId++;


        string name = "";
        while (true)
        {
            Console.Write("Ime: ");
            name = Console.ReadLine();
            try
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    throw new ArgumentException("imeto ne moje da e prazno ");
                }
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Greshka: {ex.Message} opitai onovo");
            }
        }


        Student student = null;
        while (student == null)
        {
            try
            {
                student = new Student(currentId, name);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"greshka pri suuzdavaneto: {ex.Message}");
                break;
            }
        }


        int age;
        while (true)
        {
            Console.Write("Vuzrast: ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out age))
            {
                Console.WriteLine("Nevalidna vuzrast , opitai otnovo.");
                continue;
            }
            try
            {
                student.Age = age;
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Greshka : {ex.Message} opitai otnovo.");
            }
        }


        byte studentClass;
        while (true)
        {
            Console.Write("Klas: ");
            string input = Console.ReadLine();
            if (!byte.TryParse(input, out studentClass))
            {
                Console.WriteLine("Nevaliden klas opitai otnovo.");
                continue;
            }
            try
            {
                student.Grade = studentClass;
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Greshka: {ex.Message} opitai otnovo.");
            }
        }


        double averageGrade;
        while (true)
        {
            Console.Write("Uspeh: ");
            string input = Console.ReadLine();
            if (!double.TryParse(input, out averageGrade))
            {
                Console.WriteLine("Nevaliden uspeh , opitai otnovo");
                continue;
            }
            try
            {
                student.AverageScore = averageGrade;
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"greshka: {ex.Message} opitai otnovo.");
            }
        }


        decimal fee;
        while (true)
        {
            Console.Write("Taksa: ");
            string input = Console.ReadLine();
            if (!decimal.TryParse(input, out fee))
            {
                Console.WriteLine("Nevalidna taksa , opitai otnovo");
                continue;
            }
            try
            {
                student.Fee = fee;
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"greshka: {ex.Message} opitai otnovo.");
            }
        }


        bool hasScholarship;
        while (true)
        {
            Console.Write("Stipendiq (true/false): ");
            string input = Console.ReadLine();
            if (!bool.TryParse(input, out hasScholarship))
            {
                Console.WriteLine("Vuvedete true/false");
                continue;
            }
            student.HasScholarship = hasScholarship;
            break;
        }


        char classLetter;
        while (true)
        {
            Console.Write("Paralelka: ");
            string input = Console.ReadLine();
            if (!char.TryParse(input, out classLetter))
            {
                Console.WriteLine("Nevaliden simvol , vuvedete bukva");
                continue;
            }
            try
            {
                student.ClassLetter = classLetter;
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Грешка: {ex.Message} opitai otnovo.");
            }
        }


        DateTime birthDate;
        while (true)
        {
            Console.Write("Data na razjdane (dd.MM.yyyy): ");
            string input = Console.ReadLine();
            if (!DateTime.TryParse(input, out birthDate))
            {
                Console.WriteLine("Nevalidna data , opitai otnovo");
                continue;
            }
            try
            {
                student.BirthDate = birthDate;
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"greshka:  {ex.Message}  opitai otnovo.");
            }
        }


        Console.WriteLine();
        Console.WriteLine("=== DANNI NA UCHENIK ===");
        Console.WriteLine($"Id: {student.Id}");
        Console.WriteLine($"ime: {student.Name}");
        Console.WriteLine($"vuzrast: {student.Age}");
        Console.WriteLine($"klas: {student.Grade}");
        Console.WriteLine($"sreden uspeh: {student.AverageScore:F2}");
        Console.WriteLine($"Taksa: {student.Fee:F2} лв.");

        string scholarshipText = student.HasScholarship ? "Da" : "ne";
        Console.WriteLine($"Stipendiq: {scholarshipText}");

        Console.WriteLine($"Paralelka: {student.ClassLetter}");
        Console.WriteLine($"Data na razjdane: {student.BirthDate:dd.MM.yyyy}");

    }

}
}
