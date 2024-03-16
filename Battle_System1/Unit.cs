using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_System
{
    internal class Unit
    {
        private int curuntHP;
        private int maxHP;
        private int healpwoer;
        private int attackpower;
        private string UnitName;
        private Random random;
        public int HP { get { return curuntHP; } }
        public string unitname { get { return UnitName; } }
        public bool IsDead { get { return curuntHP <=0  ; } }


        public Unit( int maxHP, int healpwoer, int attackpower, string unitName)
        {
           
            this.maxHP = maxHP;
            this.curuntHP = maxHP;
            this.healpwoer = healpwoer;
            this.attackpower = attackpower;
            this.UnitName = unitName;
            this.random = new Random();
           
        }
        public void Attack (Unit unittoAttack)
        {
            double rng = random.NextDouble();
            rng = rng / 2 + 0.75f;
            int randDamage = (int)(attackpower * rng);
            unittoAttack.takedamge(randDamage);
            Console.WriteLine(UnitName +" attack " + unittoAttack.UnitName + " and deals " +  randDamage + " damages");
        }
        public void Heal ()
        {
            double rng = random.NextDouble();
            rng = rng / 2 + 0.75f;
            int heal = (int)(rng * healpwoer);
            curuntHP = heal + curuntHP > maxHP ? maxHP : curuntHP + heal;
            Console.WriteLine(unitname + " heals " + heal); 
        }
        public void takedamge (int damage)
        {
            curuntHP -= damage;
            if (IsDead)
            {
                Console.WriteLine(unitname + " has been defeated !!");
            }

        }
    }
}
