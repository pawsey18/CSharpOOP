using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesOfMagic.Weapons.Hammer
{
    public class Hammer
    {
        private int damage;

        public int Damage
        {
            get
            {
                return this.damage;

            }
            private set
            {
                this.damage = value;
            }
        }


        public Hammer()
        {
            this.Damage = 10;
        }
    }
}
