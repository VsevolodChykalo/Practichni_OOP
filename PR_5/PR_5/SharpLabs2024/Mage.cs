namespace CSharpLabs2024
{
    public abstract class Mage : Char
    {
        public int Mana { get; set; }

        protected Mage(string name, int hp, int mana) : base(name, hp)
        {
            Mana = mana;
        }

        public void CastSpell(ISpell spell, IDamageble target)
        {
            if (!HasEnoughMana(spell.ManaCost))
            {
                Console.WriteLine($"{Name} не вистачає мани для заклинання {spell.GetType().Name}.");
                return;
            }

            UseMana(spell.ManaCost);
            Console.WriteLine($"{Name} використовує {spell.GetType().Name} на {target.Name}");
            spell.CastSpell(target, this);
        }

        public void UseMana(int amount)
        {
            Mana -= amount;
            if (Mana < 0) Mana = 0;
        }

        public bool HasEnoughMana(int amount)
        {
            return Mana >= amount;
        }

        public new void ShowStats()
        {
            base.ShowStats();
            Console.WriteLine($"Мана: {Mana}");
        }
    }
}
