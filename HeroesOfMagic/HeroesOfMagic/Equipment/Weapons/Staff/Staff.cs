using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesOfMagic
{
    public class Staff
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


        public Staff()
        {
            this.Damage = 10;
        }
    }
}
