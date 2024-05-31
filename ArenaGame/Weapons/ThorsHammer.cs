using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ArenaGame.Weapons
{
    public class ThorsHammer : IWeapon
    {
        public string Name { get ; set ; }

        public double AttackDamage { get; private set; }
      
        public double BlockingPower { get; private set; }

      



        public ThorsHammer(string name)
        {
            Random random = new Random();
            double lightningPower = 15;
            Name = name;
            AttackDamage = 30;
            BlockingPower = 5;
           double probability = random.NextDouble();
            if (probability < 0.10)
            {
                AttackDamage = AttackDamage+ lightningPower;
            }
        }
    }
}
