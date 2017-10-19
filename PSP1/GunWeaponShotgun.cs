using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP1
{
    class GunWeaponShotgun : GunWeapon
    {
        protected override int CalculateBaseDamage(Entity attacker, Random random)
        {
            throw new NotImplementedException();
        }

        protected override int CalculateDefence(Entity target, Random random)
        {
            throw new NotImplementedException();
        }
    }
}
