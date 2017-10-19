using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP1
{
    class WeaponSword : WeaponB
    {

        protected override int CalculateBaseDamage(Entity attacker, Random random)
        {
            return random.Next(1, 6) + (5 + attacker.STRENGTH);
        }

        protected override int CalculateBlockPoints(int damage, Entity target, Random random)
        {
            return random.Next(1, 6) + (2 + target.BLOCK);
        }

        protected override int CalculateDefence(Entity target, Random random)
        {
            return random.Next(1, 6) + target.DEFENCE + target.SLICE_DEFENCE + target.LUCK;
        }

        protected override bool DoesWeaponBlock(int damage, Entity target, Random random)
        {
            return random.Next(1, 4) > 2;
        }

        protected override bool DoesWeaponHit(Entity attacker, Entity target, Random random)
        {
            return (random.Next(1, 20) + 5 + attacker.ATTACK) > (random.Next(1, 6) + target.DODGE);
        }
    }
}
