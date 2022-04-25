using System;
using System.Collections.Generic;

namespace MiniProjekt
{
    public class Fighter
    {
        //variables for Fighter class
        protected Random number;

        protected Weapon weapon = new Weapon();

        //List with a set of names that will potentially be used to randomize enemyFighter name
        protected List<string> enemyNames = new List<string>() { "Arnold", "Script Kid", "Mikael Bergström", "Crewmate", "Walter White" };

        protected int hp;
        protected int strength;
        protected int dmgAmount;

        protected string name;

        protected bool isAlive;
        protected bool isEnemy;

        public Fighter()
        {
            number = new Random();

            isAlive = true;

            name = enemyNames[number.Next(enemyNames.Count)];

        }

        //attack-method, attacks selected target, uses weapon class to deal dmg
        public void Attack(Fighter target)
        {

            dmgAmount = strength;

            target.hp -= dmgAmount;

            if (target.hp <= 0)
            {
                target.hp = 0;

                target.isAlive = false;
            }
        }

        //returns isAlive
        public bool GetAlive()
        {
            return isAlive;
        }

        //returns isEnemy
        public bool GetIsEnemy()
        {
            return isEnemy;
        }

        //returns name
        public string GetName()
        {
            return name;
        }

        //returns hp
        public int GetHP()
        {
            return hp;
        }

        //returns dmgAmount
        public int GetDmgAmount()
        {
            return dmgAmount;
        }

    }
}