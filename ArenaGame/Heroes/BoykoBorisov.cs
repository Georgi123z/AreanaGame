using ArenaGame.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class BoykoBorisov:Hero
    {
       
        public BoykoBorisov(string name, double armor,double strenght,IWeapon weapon) :
         base(name, armor, strenght, weapon)
        {
            
          
        }
        public override double Attack()
        {
           double damage=base.Attack();
            if (Health<=30)
            {
                damage = damage + 20;
            }
            return damage;
            
        }
    }
}
