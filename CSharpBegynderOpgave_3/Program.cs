//Lav et spil hvor man kan gætte et, af computeren, random genereret tal.






Random random = new Random();
int Resultat = random.Next(0, 11); //Generere et random tal imellem 0 og 100. (0 er med, men 101 er ikke)
Console.WriteLine("Gæt tallet fra 1-10");
int Input = Convert.ToInt32(Console.ReadLine());







//Dette er if statements og bruges til at sammenligne værdier, det skal bruges til spillet.
if (Input == Resultat)
{
    Console.WriteLine("Rigtigt");
}
else
    Console.WriteLine("Forkert");





Console.ReadKey();

