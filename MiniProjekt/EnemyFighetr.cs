using System;

namespace MiniProjekt
{
    public class EnemyFightre : Fighter
    {
        public EnemyFightre()
        {
            hp = 100;

            strength = 5;

            name = enemyNames[number.Next(enemyNames.Count)];


        }

    }
}