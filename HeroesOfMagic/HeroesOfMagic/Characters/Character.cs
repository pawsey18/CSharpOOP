using HeroesOfMagic.Characters.Interfaces;
using System;


namespace HeroesOfMagic.Character
{
    public abstract class Character : IAttack, IDefend
    {
        private Hero hero;
        
        private int healthPoints;
        private int level;
        
        private string name;

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
                    throw new ArgumentOutOfRangeException(string.Empty, "Wrong value, the vale should be between 1 and 100");
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

     

        public void Depend()
        {
            throw new NotImplementedException();
        }

        public void SpecialAtack()
        {
            throw new NotImplementedException();
        }

        public abstract void Attack();
        public abstract void SpecialAttack();
        public abstract void Defend();
    }
}
