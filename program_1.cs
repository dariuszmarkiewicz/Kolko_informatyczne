using System;

class Program
{
    static void Main() 
        {
            Console.Write("\n Podaj swoje imie: ");
            var imie = Console.ReadLine();
            
            Console.WriteLine("\n Witaj " + imie);
            
            Console.WriteLine("\n Nacisnij dowolny klwisz...");
            Console.ReadKey();
        }
}
