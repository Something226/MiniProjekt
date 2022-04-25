using System;

namespace MiniProjekt
{
    public class Rifle : Gun
    {
        Random dmgAmount;

        private int dmg;
        private int hitChance;

        public Rifle()
        {
            gunType = "Rifle";

            hitChance = accuracy.Next(0, 5);
            dmg = dmgAmount.Next(10, 20);
        }

        public int ReturnDmg()
        {
            return dmg;
        }
    }
}