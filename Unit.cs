namespace Unity
{
    internal class Unit
    {
        private int currentHp;
        private int maxHp;
        private int attackPower;
        private int healingPower;
        private string unitName;
        private Random random;
        private double healPower;

        public int Hp { get { return currentHp; } }
        public string UnitName { get { return unitName; } }

        public bool IsDead { get; private set; }

        public Unit(string name, int maxHp, int attackPower, int healingPower)
        {
            this.unitName = name;
            this.maxHp = maxHp;
            this.currentHp = maxHp; // Start with full health
            this.attackPower = attackPower;
            this.healingPower = healingPower;
            this.random = new Random();
        }

        public void Attack(Unit unitToAttack)
        {
            double rng = random.NextDouble();
            rng = rng / 2 + 0.75f;
            int randDamage = (int)(attackPower * rng);
            unitToAttack.TakeDamage(randDamage);
            System.Console.WriteLine(unitName + " attacks " + unitToAttack.unitName + " for " + randDamage + " damage!");
        }
        public void TakeDamage(int damage)
        {
            currentHp -= damage;

            if (IsDead)
            {
                System.Console.WriteLine(UnitName + " has been defeated!");
            }
        }
        public void Heal()
        {
            double rng = random.NextDouble();
            rng = rng / 2 + 0.75f;
            int heal = (int)(rng * healPower);
            currentHp = heal + currentHp > maxHp ? maxHp : currentHp + heal;
            System.Console.WriteLine(unitName + " heals" + heal);
        }
    }
}