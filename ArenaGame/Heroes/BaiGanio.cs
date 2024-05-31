using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class BaiGanio:Hero
    {
        public BaiGanio(string name, double armor, double strenght, IWeapon weapon) :
        base(name, armor, strenght, weapon)
        {


        }
        public override double Defend(double damage)
        {
            double armorr = base.Armor;
            if (Health<50)
            {
                armorr = 40;
            }
            return base.Defend(damage);
        }
    }
}
