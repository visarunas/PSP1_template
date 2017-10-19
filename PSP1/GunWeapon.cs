using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP1
{
    abstract class GunWeapon
    {
        private int Ammo = 10;

        public int GetAttackDamage(Entity attacker, Entity target, Random random)
        {
            if (DoesWeaponHit(attacker, target, random) && CanShoot()) { 
                var damage = Math.Max(CalculateBaseDamage(attacker, random) - CalculateDefence(target, random), 0);
                DecrementAmmo();
                return damage;
            }
            else
            {
                return 0;
            }
        }

        protected virtual bool DoesWeaponHit(Entity attacker, Entity target, Random random)
        {
            return (random.Next(1, 20) + attacker.SHOOTING) > (random.Next(1, 10) + target.DODGE);
        }
        protected abstract int CalculateBaseDamage(Entity attacker, Random random);
        protected abstract int CalculateDefence(Entity target, Random random);
        protected virtual bool CanShoot()
        {
            return this.Ammo > 0;
        }
        protected virtual void DecrementAmmo()
        {
            this.Ammo--;
        }





    }
}
