using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP1
{
    class GunWeaponPistol : GunWeapon
    {
        protected override int CalculateBaseDamage(Entity attacker, Random random)
        {
            return 1;
        }

        protected override int CalculateDefence(Entity target, Random random)
        {
            return 1;
        }
    }
}
