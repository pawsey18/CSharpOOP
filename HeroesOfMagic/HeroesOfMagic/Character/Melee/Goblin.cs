using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesOfMagic.Heroes.Barbarian
{
    public class Goblin
    {
        private const Hero DEFAULT_HERO = Hero.Melee;
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 120;
        private const int DEFAULT_ABILITY_POINTS = 100;
        private const string DEFAULT_NAME = "Goblin";

        private readonly ChainLink DEFAULT_BODY_ARMOR = new ChainLink();
        private readonly Hammer DEFAULT_WEAPON = new Hammer();

        private Hero hero;

        private int abilityPoints;
        private int healthPoints;
        private int level;

        private string name;

        private ChainLink bodyArmor;
        private Hammer weapon;

        public int AbilityPoints
        {
            get
            {
                return this.abilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    this.abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Wrong value, the vale should be between 1 and 10");
                }
            }
        }

        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    this.healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Wrong value, the vale should be between 1 and 10");
                }
            }
        }

        public Hero Hero
        {
            get
            {
                return this.hero;
            }
            set
            {
                this.hero = value;
            }
        }

        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                if (value >= 0)
                {
                    this.level = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Level should be greater than 0");
                }
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 13)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "name should be at least 3 characters long");
                }
            }
        }
        public ChainLink BodyArmor
        {
            get
            {
                return this.bodyArmor;
            }
            set
            {
                this.bodyArmor = value;
            }
        }


        public Hammer Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }

        }

        public Goblin() :
            this(DEFAULT_NAME, DEFAULT_LEVEL)
        {

        }

        public Goblin(string name, int level) :
            this(name, level, DEFAULT_HEALTH_POINTS)
        {

        }

        public Goblin(string name, int level, int healthPoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthPoints;
            this.AbilityPoints = DEFAULT_ABILITY_POINTS;
            this.Hero = DEFAULT_HERO;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            this.Weapon = DEFAULT_WEAPON;
        }

        public void Strike()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void SkinHarden()
        {
            throw new NotImplementedException();
        }
    }
}
