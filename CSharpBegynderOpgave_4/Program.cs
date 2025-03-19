int Input;
int Counter = 0;
Random random = new Random();
int Resultat = random.Next(1, 11);

Console.WriteLine("Gæt tallet fra 1-10. du har 5 forsøg");
while (Counter < 5)
{
    Input = Convert.ToInt32(Console.ReadLine());
    if (Input == Resultat)
    {
        Console.WriteLine("DU er MEGET god!!!");
        break;
    }
    else
    {
        Console.WriteLine("Du er MEGET dårlig!!!");
        Counter++;
    
    }
}