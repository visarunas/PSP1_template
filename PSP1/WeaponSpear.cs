using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP1
{
    class WeaponSpear : Weapon
    {

        protected override int CalculateBaseDamage(Entity attacker, Random random)
        {
            return random.Next(1, 10) + (10 + attacker.STRENGTH);
        }

        protected override int CalculateDefence(Entity target, Random random)
        {
            return random.Next(1, 6) + target.DEFENCE + target.SLICE_DEFENCE + target.LUCK;
        }

    }
}
