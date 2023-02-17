namespace Task_Polymorphysm
{
    public class Human : Entity
    {
        public Human(int health, int agility)
            : base(health)
        {
            Agility = agility;
        }

        public int Agility { get; private set; }

        protected override int ComputeDamage(int damage)
        {
            damage /= Agility;
            return damage;
        }
    }
}