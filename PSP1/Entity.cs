using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP1
{
    class Entity
    {
        public int STRENGTH = 5;
        public int DEFENCE = 4;
        public int SLICE_DEFENCE = 2;
        public int PIERCE_DEFENCE = 8;
        public int DODGE = 3;
        public int LUCK = 1;
        public int ATTACK = 6;

        public int health = 100;

        public Weapon weapon;

        public Entity(Weapon weapon)
        {
            this.weapon = weapon;
        }
    }
}
