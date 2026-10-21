using System;

public class Class1
{
	public Class1()
	{

        internal class Student
    {
        public int Id { get; }

        private string name;
        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Imeto ne moje da bude prazno ili intervali.", nameof(Name));
                }
                name = value;
            }
        }

        private int age;
        public int Age
        {
            get => age;
            set
            {
                if (value < 6 || value > 20)
                {
                    throw new ArgumentOutOfRangeException(nameof(Age), "vuzrasta trqbva da e mejdu 6 i 20.");
                }
                age = value;
            }
        }

        private int grade;
        public int Grade
        {
            get => grade;
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentOutOfRangeException(nameof(Grade), "klasut trqbva da e mejdu 1 i 12 vklyuchitelno.");
                }
                grade = value;
            }
        }

        private double averageScore;
        public double AverageScore
        {
            get => averageScore;
            set
            {
                if (value < 2.00 || value > 6.00)
                {
                    throw new ArgumentOutOfRangeException(nameof(AverageScore), "sreden uspeh trqbva da e mejdu 2.0 i 6.0");
                }
                averageScore = value;
            }
        }

        private decimal fee;
        public decimal Fee
        {
            get => fee;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Fee), "taksata ne moje da e otricatelna.");
                }
                fee = value;
            }
        }

        public bool HasScholarship { get; set; }

        private char classLetter;
        public char ClassLetter
        {
            get => classLetter;
            set
            {
                if (!char.IsLetter(value))
                {
                    throw new ArgumentException("paralelkata trqbva da e bukva.", nameof(ClassLetter));
                }
                classLetter = value;
            }
        }

        private DateTime birthDate;
        public DateTime BirthDate
        {
            get => birthDate;
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentOutOfRangeException(nameof(BirthDate), "datata na razjdate ne trqbva da e budeshta data.");
                }
                birthDate = value;
            }
        }

        public Student(int id, string name)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(id), "indetifakatora trqbva da e polojitelno chislo");
            }
            Id = id;
            Name = name;
        }

    }
}
