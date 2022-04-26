using System;

namespace MiniProjekt
{
    public class Rifle : Gun
    {
        protected Random dmg = new Random();

        private int dmgAmount;

        public Rifle()
        {
            gunType = "Rifle";

            dmgAmount = dmg.Next(5, 20);
        }

        public int ReturnDmg()
        {
            return dmgAmount;
        }
    }
}