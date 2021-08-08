using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesOfMagic.Weapons.Axe
{
    public class Axe
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


        public Axe()
        {
            this.Damage = 10;
        }
    }
}
