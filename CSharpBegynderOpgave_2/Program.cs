/*   Opgave 2
    - Udvid dit visitkort fra sidst ved at gøre brug af Forskellige datatyper, variabler og user input.
    - Se bunden af koden for eksempler
 */
using System;

class Program
{
    static void Main()
    {



        // Dine oprindelige variabler
        int xPosition = 5;
        int yPosition = 1;
        string Navn = "Emil";  // Navnet som vi svarer med

        // Sæt cursorpositionen
        Console.SetCursorPosition(xPosition, yPosition);
        Console.WriteLine("X");

        // Print den oprindelige strengvariabel
        string StrengVariabel = "TestStreng";
        Console.WriteLine(StrengVariabel);

        // Beregn og udskriv summen af to integer variabler
        int IntegerVariabel1 = 5;
        int IntegerVariabel2 = 5;
        Console.WriteLine(IntegerVariabel1 + IntegerVariabel2);

        // Bed brugeren om at skrive noget
        Console.WriteLine("Skriv noget:");

        // Læs brugerens input
        string brugerInput = Console.ReadLine();

        // Uanset hvad brugeren skriver, svar med "Emil"
        Console.WriteLine("Jeg hedder " + Navn);

        Console.ReadLine();  // Vent på at brugeren trykker Enter
    }
}








/*
    Console.SetCursorPosition(5, 1); //Sætter cursorens start position.

    string StrengVariabel = "Blablabla"; //En streng er det samme som en tekst.
    int IntegerVariabel = 0; //En Integer er et Heltal
    double DoubleVariable = 0.5; //En double er et komma-tal
    bool ErEnBoolVariabel = true; //En bool kan have 2 værdier. true eller false.    

    Console.ReadLine(); //Læser brugeren input og returnere en streng. kan f.eks gemmes i en variabel.
    
 */