
using HeroesOfMagic.Character.Melee;
using System;
using Weapons;


namespace HeroesOfMagic
{
    public class Knight : Melee
    {
        private const Hero DEFAULT_HERO = Hero.Melee;

        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const int DEFAULT_ABILITY_POINTS = 10;

        private const string DEFAULT_NAME = "Knight";
        
        private readonly ChainLink DEFAULT_BODY_ARMOR = new ChainLink();
        private readonly Sword DEFAULT_WEAPON = new Sword();


        private ChainLink bodyArmor;
        private Sword weapon;

 
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
       

        public Sword Weapon
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

        public Knight() :
            this(DEFAULT_NAME, DEFAULT_LEVEL)
        {

        }

        public Knight(string name, int level) :
            this(name, level, DEFAULT_HEALTH_POINTS)
        {

        }

        public Knight(string name, int level, int healthPoints)
        { 
            
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthPoints;
            this.AbilityPoints = DEFAULT_ABILITY_POINTS;
            this.Hero = DEFAULT_HERO;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            this.Weapon = DEFAULT_WEAPON;
           
        }

        public void Poke()
        {
            throw new NotImplementedException();
        }

        public void Pray()
        {
            throw new NotImplementedException();

        }

        public void DeathGlare()
        {
            throw new NotImplementedException();
        }

        public override void Attack()
        {
            throw new NotImplementedException();
        }

        public override void SpecialAttack()
        {
            throw new NotImplementedException();
        }

        public override void Defend()
        {
            throw new NotImplementedException();
        }
    }
}
