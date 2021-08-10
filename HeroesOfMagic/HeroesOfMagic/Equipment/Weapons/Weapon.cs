using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesOfMagic.Equipment.Weapons
{
    public abstract class Weapon
    {
        private int damagePoints;

        public int DamagePoints
        {
            get
            {
                return damagePoints;
            }

            set
            {
                if (value >= 0)
                {
                    this.damagePoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Damage Points value should be a positive number");
                }
            }
        }

        public abstract void SpecialAbility();
    }
}
