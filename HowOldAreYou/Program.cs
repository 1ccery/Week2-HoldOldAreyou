using System;

namespace HowOldAreYou
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TERE MiNA OLEN VANUSE PROGRAMM");
            //programm kysib kasutaja vanust
            //programm kasutaja arvutab synni aasta
            //kuvab synni aasta konsoolis

            Console.WriteLine("Mis teie nimi on?");

            string FirstName = Console.ReadLine();

            Console.WriteLine($"Tervist,  { FirstName}");

            Console.WriteLine("Kui vana te olete ?");

            int Age = Convert.ToInt32(Console.ReadLine());

            int Yearofbirth = 2021 - Age;

            Console.WriteLine("Teie olete sündinud aastal " + Yearofbirth);
 








        }
    }
}
