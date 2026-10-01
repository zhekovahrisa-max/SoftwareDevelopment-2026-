using System.ComponentModel.Design;
using System.Threading.Channels;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string>zaglaviq = new List<string>();
            List<string> opisaniq = new List<string>();
            List<string> kraenSrok = new List<string>();
            List<bool> izpulnena = new List<bool>();

            bool raboti = true;

            while (raboti)
            {
                Console.WriteLine("===TODO MANEGER===");
                Console.WriteLine("1. Dobavi nova zadacha");
                Console.WriteLine("2.Vish vsichki zadachi");
                Console.WriteLine("3.Markirai zadacha kato izpulnena");
                Console.WriteLine("4. iztriy zadacha");
                Console.WriteLine("5. Izhod");
                Console.WriteLine("6. izberete opciq:");

                string izbor = Console.ReadLine();

                if (izbor == "1")
                {
                    Console.WriteLine("vuvedete zaglavie:");
                    string zaglavie = Console.ReadLine();

                    Console.WriteLine("vuvedete opisanie:");
                    string opisanie = Console.ReadLine();

                    Console.WriteLine("vuvedete kraen srok:");
                    string kraen = Console.ReadLine();

                    zaglaviq.Add(zaglavie);
                    opisaniq.Add(opisanie);
                    kraenSrok.Add(kraen);
                    izpulnena.Add(false);

                    Console.WriteLine("Zadachata ti e izpulnena uspushno");





                }
                else if (izbor == "2")
                {
                    if (zaglaviq.Count == 0)
                    {
                        Console.WriteLine("Nqma namereni zadachi");

                    }
                    else
                    {
                        for (int i = 0; i < zaglaviq.Count; i++)
                        {
                            string status = "";

                            if (izpulnena[1] == true)
                            {
                                status = "[X] izpulnena";

                            }
                            else
                            {
                                status = "[] Ne izpulnena";
                            }

                            Console.WriteLine((i + 1) + "." + zaglaviq[i] + "-" + "(Srok:" + kraenSrok[i] + ")" + status);

                        }
                    }

                }
                else if (izbor == "3") 
                {
                    Console.WriteLine("Vuvedete nomer na zadachat za markirane  ");
                    int nomer=int.Parse(Console.ReadLine());

                    if (nomer > 0 && nomer <= zaglaviq.Count) 
                    {
                        izpulnena[nomer - 1] = true;
                        Console.WriteLine("zadachata e markirana kato izpulena  ");
                    }
                    else
                    {
                        Console.WriteLine("Nevaliden nomer");
                 
                    }
                    



                }
                else if (izbor == "4")
                {
                    Console.WriteLine("vuvedete nomer na zadachata za iztrivane ");
                    int nomer = int.Parse(Console.ReadLine());

                    if (nomer > 0 && nomer <= zaglaviq.Count) 
                    {
                        int index = nomer - 1;
                        zaglaviq.RemoveAt(index);
                        opisaniq.RemoveAt(index);
                        kraenSrok.RemoveAt(index);
                        izpulnena.RemoveAt(index);

                        Console.WriteLine("zadachata e iztrita uspeshno");


                    }
                    else
                    {
                        Console.WriteLine("nevaliden nomer");
                    }

                }
                else if (izbor == "5")
                {
                 raboti = false;
                    Console.WriteLine("chao");
                }
                else
                {
                    Console.WriteLine("nevaliden izbor");
                }
            }

        }
    }
}
