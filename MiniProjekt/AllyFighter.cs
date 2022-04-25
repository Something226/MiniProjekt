using System;

namespace MiniProjekt
{
    public class AllyFighter : Fighter
    {
        public AllyFighter()
        {
            hp = 100;

            strength = 5;

            name = enemyNames[number.Next(enemyNames.Count)];

            Rifle ak47 = new Rifle();

        }

    }
}