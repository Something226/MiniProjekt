using System;
using System.Collections.Generic;

namespace MiniProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Fighter, string> fighterStatus = new Dictionary<Fighter, string>();
            Stack<Fighter> fighterStack = new Stack<Fighter>();


            AllyFighter fuling = new AllyFighter();
            EnemyFightre snuskig = new EnemyFightre();

            System.Console.WriteLine("Här demonstrerar jag arv i två led samt komposition");

            Console.ReadLine();

            FightSequence.Fight(fuling, snuskig);

            Console.ReadLine();

            Console.WriteLine("Här demonstrerar jag exempel på hur dictionary kan brukas");

            fighterStatus.Add(fuling, "Han är ful");
            fighterStatus.Add(snuskig, "Han är snuskig");

            Console.WriteLine("En beskrivning på båda fighter-instanserna läggs till i dictionaryn, när man sedan stoppar in det i en writeline får vi beskrivnignen som fighter-instansen har fått");

            Console.ReadLine();

            System.Console.WriteLine(fighterStatus[fuling]);
            System.Console.WriteLine(fighterStatus[snuskig]);

            Console.ReadLine();

            Console.WriteLine("Här demonstrera jag exempel på hur Stack kan brukas");

            fighterStack.Push(fuling);
            fighterStack.Push(snuskig);

            Console.WriteLine("Fighter-instanserna läggs till i en Fighter-baserad Stack, Peek används sedan för att skriva ut den fightern som lagts till sist");

            Console.ReadLine();

            Console.WriteLine(fighterStack.Peek());

            Console.ReadLine();

        }
    }
}
