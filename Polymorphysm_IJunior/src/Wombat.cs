namespace Task_Polymorphysm
{
    public class Wombat : Entity
    {
        public Wombat(int health, int armor)
            : base(health)
        {
            Armor = armor;
        }

        public int Armor { get; private set; }

        protected override int ComputeDamage(int damage)
        {
            damage -= Armor;
            return damage;
        }
    }
}