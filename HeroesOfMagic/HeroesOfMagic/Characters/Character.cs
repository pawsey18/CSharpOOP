using System;
using HeroesOfMagic.Characters.Interfaces;
using HeroesOfMagic.Enums;
using HeroesOfMagic.Equipment.Armors;
using HeroesOfMagic.Equipment.Weapons;

namespace HeroesOfMagic.Characters
{
    public abstract class Character : IAttack, IDefend
    {
        private Hero hero;

        private Weapon weapon;
        private Armor bodyArmor;

        private bool isAlive;

        private int healthPoints;
        private int level;
        private int scores;

        private string name;

        public Weapon Weapon
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

        public Armor BodyArmor
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

        public bool IsAlive
        {
            get
            {
                return this.isAlive;
            }

            protected set
            {
                this.isAlive = value;
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
                if (value >= 0 && value <= 120)
                {
                    this.healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 100.");
                }
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
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, level should always be positive.");
                }
            }
        }

        public int Scores
        {
            get
            {
                return this.scores;
            }

            set
            {
                this.scores = value;
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
                if (value.Length >= 3 && value.Length <= 9)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException(string.Empty, "Inappropriate length of name, name should be between 3 and 12 characters.");
                }
            }
        }

        public abstract int Attack();

        public abstract int SpecialAttack();

        public abstract int Defend();

        public void TakeDamage(int damage, string attackerName, string type)
        {
            if (this.Defend() < damage)
            {
                this.healthPoints = this.healthPoints - damage + this.Defend();

                if (this.healthPoints <= 0)
                {
                    this.isAlive = false;
                }
            }
            else
            {
                Console.WriteLine("Haha! Your damage was not enough to harm me!");
            }

            if (!this.isAlive)
            {
                Tools.TypeSpecificColorfulCW($"{this.name} received {damage} damage from {attackerName}, and is now dead!", type);
            }
            else
            {
                Tools.TypeSpecificColorfulCW($"{this.name} received {damage} damage from {attackerName}, and now has {this.healthPoints} healthpoints!", type);
            }
        }

        public void WonBattle()
        {
            this.scores++;

            if (this.scores % 10 == 0)
            {
                this.level++;
            }
        }

        int IAttack.SpecialAtack()
        {
            throw new NotImplementedException();
        }

        int IDefend.Depend()
        {
            throw new NotImplementedException();
        }
    }
}
