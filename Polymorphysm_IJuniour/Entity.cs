namespace Task_Polymorphysm
{
    public abstract class Entity
    {
        protected Entity(int health)
        {
            Health = health;
        }

        public int Health { get; private set; }

        public bool IsAlive()
        {
            return Health > 0;
        }

        public void TakeAttack(int damage)
        {
            TakeDamage(damage);
            if (IsAlive() == false)
            {
                Console.WriteLine("Я умер");
            }
        }

        protected abstract int ComputeDamage(int damage);

        private void TakeDamage(int damage)
        {
            Health -= ComputeDamage(damage);
        }
    }
}