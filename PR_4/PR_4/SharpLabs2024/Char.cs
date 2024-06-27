namespace CSharpLabs2024
{
    public abstract class Char : IDamageble
    {
        private int _hp;
        public string Name { get; set; }
        public int Hp
        {
            get { return _hp; }
            set { _hp = value < 0 ? 0 : value; }
        }
        private bool IsDefending { get; set; }

        protected Char(string name, int hp)
        {
            Name = name;
            Hp = hp;
            IsDefending = false;
        }

        public void TakeDamage(int damage)
        {
            if (IsDefending)
            {
                damage /= 2;
                Console.WriteLine($"{Name} заблокував частину шкоди! Шкода зменшена до {damage}.");
                IsDefending = false;
            }
            Hp -= damage;
            if (Hp < 0) Hp = 0;
            Console.WriteLine($"{Name} отримав {damage} шкоди. Залишилось здоров'я: {Hp}");
        }

        public void Defend()
        {
            IsDefending = true;
            Console.WriteLine($"{Name} захищається.");
        }

        public void ShowStats()
        {
            Console.WriteLine($"Ім'я: {Name}, Здоров'я: {Hp}");
        }
    }
}
