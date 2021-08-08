
using System;
using Weapons;


namespace HeroesOfMagic
{
    public class Knight
    {
        private const Hero DEFAULT_FACTION = Hero.Melee;
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 120;
        private const int DEFAULT_ABILITY_POINTS = 100;
        private const string DEFAULT_NAME = "Swordsman";

        private Hero hero;

        private int abilityPoints;
        private int healthPoints;
        private int level;

        private string name;

        private ChainLink bodyArmor;
        private Sword sword;

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
        public string BodyArmor { get; set; }
        public Sword SwordWeapon
        {
            get
            {
                return this.sword;
            }
            set
            {
                this.sword = value;
            }

        }

        public Knight(int abilityPoints, Hero hero, int healthPoints, int level, string name, string bodyArmor)
        {
            this.AbilityPoints = abilityPoints;
            this.Hero = hero;
            this.HealthPoints = healthPoints;
            this.Level = level;
            this.Name = name;
            this.BodyArmor = bodyArmor;
            this.SwordWeapon = new Sword();
        }

        public void Poke()
        {
            
        }

        public void Pray()
        {
            

        }

        public void DeathGlare()
        {

        }
    }
}
