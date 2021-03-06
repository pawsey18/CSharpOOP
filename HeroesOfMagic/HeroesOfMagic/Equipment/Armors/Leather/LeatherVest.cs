


namespace HeroesOfMagic.Equipment.Armors.Light
{
    public class LeatherVest : Leather
    {
        private const int DEFAULT_ARMOR_POINTS = 10;

        public LeatherVest()
            : this(DEFAULT_ARMOR_POINTS)
        {
        }

        public LeatherVest(int armorPoints)
        {
            this.ArmorPoints = armorPoints;
        }
    }
}
