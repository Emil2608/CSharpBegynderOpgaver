////Opgradér spillet fra Opgave_3 med et Loop sådan at man får flere forsøg når man gætter forkert




////Eksempel på while loop

////While loop der tæller til 10
//int counter = 0;
//while(counter < 10)
//{
//	Console.WriteLine(counter);
//	counter++;
//}

//Console.ReadKey();
//Console.WriteLine("");

////Eksempel på for loop
//for(int i = 0; i < 10; i += 2)
//{
//	Console.WriteLine(i);
//}
//Console.ReadKey();


//Lav et spil hvor man kan gætte et, af computeren, random genereret tal.






using System.Linq.Expressions;
using System.Runtime.InteropServices;


Random random = new Random();
int Resultat = random.Next(1, 11); //Generere et random tal imellem 0 og 100. (0 er med, men 101 er ikke)

    Console.WriteLine("Gæt tallet fra 1-10. du har 5 forsøg");
    Console.WriteLine("hvad skal tallene være. skriv  f.eks. 1-10");
int Input;
int Counter = 0;
while (Counter < 5)
{
    Input = Convert.ToInt32(Console.ReadLine());
    if (Input == Resultat)
    {
        Console.WriteLine("Rigtigt");
        break;
    }
    else
    {
        Console.WriteLine("Forkert. prøv igen");
        Counter++;

    }
}
   













Console.ReadKey();




