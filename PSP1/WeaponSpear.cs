using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP1
{
    class WeaponSpear : WeaponB
    {

        protected override int CalculateBaseDamage(Entity attacker, Random random)
        {
            return random.Next(1, 10) + (10 + attacker.STRENGTH);
        }

        protected override int CalculateBlockPoints(int damage, Entity target, Random random)
        {
            return random.Next(1, 4) + (target.DEFENCE);
        }

        protected override int CalculateDefence(Entity target, Random random)
        {
            return random.Next(1, 4) + target.DEFENCE + target.PIERCE_DEFENCE + target.LUCK;
        }

        protected override bool DoesWeaponBlock(int damage, Entity target, Random random)
        {
            return random.Next(1, 6) > 4;
        }
    }
}
