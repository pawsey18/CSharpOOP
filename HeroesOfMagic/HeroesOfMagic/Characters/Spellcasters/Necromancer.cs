using System;
using HeroesOfMagic;
using HeroesOfMagic.Characters.Spellcasters;
using HeroesOfMagic.Enums;
using HeroesOfMagic.Equipment.Armors.Light;
using HeroesOfMagic.Equipment.Weapons.Sharp;

namespace HeroesOfMagic.Characters.Spellcasters
{
    public class Necromancer : Spellcaster
    {
        private readonly LeatherVest DEFAULT_BODY_ARMOR = new LeatherVest();
        private readonly Sword DEFAULT_WEAPON = new Sword();

        public Necromancer()
            : this(Consts.Necromancer.NAME, 1)
        {
        }

        public Necromancer(string name, int level)
            : this(name, level, Consts.Necromancer.HEALTH_POINTS)
        {
        }

        public Necromancer(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.ManaPoints = Consts.Necromancer.MANA_POINTS;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.Hero = Hero.Spellcaster;
            base.IsAlive = true;
            base.Scores = 0;
        }

        public int ShadowRage()
        {
            return base.Weapon.DamagePoints + 10;
        }

        public int VampireTouch()
        {
            throw new NotImplementedException();
        }

        public int BoneShield()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            return this.ShadowRage();
        }

        public override int SpecialAttack()
        {
            return this.VampireTouch();
        }

        public override int Defend()
        {
            return this.BoneShield();
        }
    }
}
