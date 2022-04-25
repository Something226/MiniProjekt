using System;

namespace MiniProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            AllyFighter fuling = new AllyFighter();
            EnemyFightre snuskig = new EnemyFightre();

            System.Console.WriteLine("Här demonstrerar jag arv i två led samt komposition");

            Console.ReadLine();

            FightSequence.Fight(fuling, snuskig);

            Console.ReadLine();




        }
    }
}
