using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public  class Spear:IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }
    

        public Spear(string name)
        {
        
            Name = name;
            AttackDamage = 20;
            BlockingPower = 10;
            if(AttackDamage<50)
            AttackDamage = AttackDamage + 5;
        }
        
    }
}
