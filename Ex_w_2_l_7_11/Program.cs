using System.ComponentModel.Design;

namespace W_2_l_7_11

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Ocena");

            Console.WriteLine("Podaj ocenę");
            int ocena = int.Parse(Console.ReadLine());

            if (ocena == 6)
            {
                Console.WriteLine("Celejący");
            }
            else if (ocena == 5)
            { Console.WriteLine("Bardzo dobry"); }

            else if (ocena == 4)
            { Console.WriteLine("Dobry"); }

            else if (ocena == 3)
            { Console.WriteLine("Dostateczny"); }

            else if (ocena == 2)
            { Console.WriteLine("Dopuszczający"); }

            else if (ocena == 1)

            { Console.WriteLine("Niedostateczny"); }

            else
            { Console.WriteLine("Nie ma takiej oceny"); };
        }
    }
}