using System;
using HeroesOfMagic.Enums;
using HeroesOfMagic.Equipment.Armors.Light;
using HeroesOfMagic.Equipment.Weapons.Sharp;

namespace HeroesOfMagic.Characters.Melee
{
    public class Assassin : Melee
    {
        private readonly LeatherVest DEFAULT_BODY_ARMOR = new LeatherVest();
        private readonly Sword DEFAULT_WEAPON = new Sword();

        public Assassin()
            : this(Consts.Assassin.NAME, 1)
        {
        }

        public Assassin(string name, int level)
            : this(name, level, Consts.Assassin.HEALTH_POINTS)
        {
        }

        public Assassin(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.AbilityPoints = Consts.Assassin.ABILITY_POINTS;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.Hero = Hero.Melee;
            base.IsAlive = true;
            base.Scores = 0;
        }

        public int Raze()
        {
            return base.Weapon.DamagePoints + 10;
        }

        public int BleedToDeath()
        {
            throw new NotImplementedException();
        }

        public int Survival()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            return this.Raze();
        }

        public override int SpecialAttack()
        {
            return this.BleedToDeath();
        }

        public override int Defend()
        {
            return this.Survival();
        }
    }
}
