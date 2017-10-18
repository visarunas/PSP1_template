using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP1
{
    abstract class Weapon
    {
        protected Random random = new Random();

        public int GetAttackDamage(Entity attacker, Entity target, Random random)
        {
            if (DoesWeaponHit(attacker, target, random))
            {
                return Math.Max(CalculateBaseDamage(attacker, random) - CalculateDefence(target, random), 0);
            }
            else
            {
                return 0;
            }
        }

        protected virtual bool DoesWeaponHit(Entity attacker, Entity target, Random random)
        {
            return (random.Next(1, 20) + attacker.ATTACK) > (random.Next(1, 10) + target.DODGE);
        }
        protected abstract int CalculateBaseDamage(Entity attacker, Random random);
        protected abstract int CalculateDefence(Entity target, Random random);
    }
}
