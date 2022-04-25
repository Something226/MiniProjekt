using System;

namespace MiniProjekt
{
    public class FightSequence
    {
        /* Class description */
        /* Class creates a sequence for a fight, will be used by player to progress their fighter and allow for custom battles */

        //Fight-method, takes two fighter classes
        public static void Fight(Fighter AllyFighter, Fighter EnemyFightre)
        {
            //Writeline tells user fight has been initiated, Fighter.GetName used to display names of fighters to user
            Console.WriteLine(AllyFighter.GetName() + " and " + EnemyFightre.GetName() + " will now fight to the death!");

            //Fight-loop, both Fighter-classes attack each other ones per cycle of Fight-loop, if one Fighter's HP reaches 0, Fighter.GetAlive = False = Loop ends
            while (AllyFighter.GetAlive() && EnemyFightre.GetAlive())
            {
                AllyFighter.Attack(EnemyFightre);

                Console.WriteLine(AllyFighter.GetName() + " attacked " + EnemyFightre.GetName() + " for " + AllyFighter.GetDmgAmount() + ", " + EnemyFightre.GetName() + " now has: " + EnemyFightre.GetHP() + " HP");

                EnemyFightre.Attack(AllyFighter);

                Console.WriteLine(EnemyFightre.GetName() + " attacked " + AllyFighter.GetName() + " for " + EnemyFightre.GetDmgAmount() + ", " + AllyFighter.GetName() + " now has: " + AllyFighter.GetHP() + " HP\nPress ENTER to continue");

                Console.ReadLine();

                Console.Clear();

            }

            //if-statments tells player who won the fight, Dependant on Fighter.GetAlive()
            if (!EnemyFightre.GetAlive() && !AllyFighter.GetAlive())
            {
                Console.WriteLine("It's a draw!");
            }
            else if (!AllyFighter.GetAlive())
            {
                Console.WriteLine(EnemyFightre.GetName() + " won!");
            }
            else if (!EnemyFightre.GetAlive())
            {
                Console.WriteLine(AllyFighter.GetName() + " won!");
            }




        }


    }
}