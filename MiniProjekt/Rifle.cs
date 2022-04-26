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
        }

        public int ReturnDmg()
        {
            dmgAmount = dmg.Next(5, 20);
            return dmgAmount;
        }
    }
}