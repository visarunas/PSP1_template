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

        public int GetAttackDamage(Entity attacker, Entity target)
        {
            if (DoesWeaponHit(attacker, target))
            {
                return Math.Max(CalculateBaseDamage(attacker) - CalculateDefence(target), 0);
            }
            else
            {
                return 0;
            }
        }

        protected virtual bool DoesWeaponHit(Entity attacker, Entity target)
        {
            return (random.Next(1, 20) + attacker.ATTACK) > (random.Next(1, 10) + target.DODGE);
        }
        protected abstract int CalculateBaseDamage(Entity attacker);
        protected abstract int CalculateDefence(Entity target);
    }
}
