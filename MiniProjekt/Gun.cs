using System;

namespace MiniProjekt
{
    public class Gun : Weapon
    {

        protected Random accuracy;

        protected string gunType;

        public Gun()
        {
            Type = "Gun";
        }
    }
}